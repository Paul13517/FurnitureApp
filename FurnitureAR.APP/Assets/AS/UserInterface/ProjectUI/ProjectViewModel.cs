using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AS.Tools;
using S123.Models.Project;
using S123.Models.Project.InverseKinematics;
using S123.Models.Tree;
using S123.Network;
using UniRx;
using UnityEngine;
using Object = UnityEngine.Object;

public class ProjectOwner
{
    public readonly String Name;

    public readonly String Link;

    public ProjectOwner(String name, String link) => (Name, Link) = (name, link);
}

namespace UserInterface.ProjectUI
{
    public class ProjectViewModel : ViewModelForNetwork
    {
        public enum View 
        {
            Main,
            Front,
            Top,
            Left, 
            Right
        }

        public const Int32 CalculationTimeOutMs = 30000;
        
        public const Int32 CalculationStatusRequestIntervalMs = 1000;
        
        public IReactiveProperty<String> ProjectName => _projectName;

        public IReactiveProperty<ProjectOwner> ProjectOwner => _projectOwner;
        
        public IReactiveProperty<Int32> DirectoryId => _directoryId;

        public IReactiveProperty<Int32> OutputsFieldsCount => _outputsFieldsCount;
        
        public IReactiveProperty<Int32> InputFieldsCount => _inputFieldsCount;

        public IReactiveProperty<Boolean> HasInputs => _hasInputs;

        public IReactiveProperty<Project> Project => _projectProperty;

        public IReactiveProperty<GameObject> Model3D => _model3D;
        
        private readonly ReactivePropertyNoInit<String> _projectName = new ReactivePropertyNoInit<String>();
        
        private readonly ReactivePropertyNoInit<ProjectOwner> _projectOwner = new ReactivePropertyNoInit<ProjectOwner>();
        
        private readonly ReactivePropertyNoInit<Int32> _directoryId = new ReactivePropertyNoInit<Int32>();

        private readonly ReactivePropertyNoInit<Int32> _outputsFieldsCount = new ReactivePropertyNoInit<Int32>();
        
        private readonly ReactivePropertyNoInit<Int32> _inputFieldsCount = new ReactivePropertyNoInit<Int32>();

        private readonly ReactivePropertyNoInit<Boolean> _hasInputs = new ReactivePropertyNoInit<Boolean>();
        
        private readonly ReactivePropertyNoInit<Project> _projectProperty = new ReactivePropertyNoInit<Project>();
        
        private readonly ReactivePropertyNoInit<GameObject> _model3D = new ReactivePropertyNoInit<GameObject>();
        
        private readonly AsyncCacheBuffer<Int32, AttributeField> _loadedOutputFields = new AsyncCacheBuffer<Int32, AttributeField>();
        
        private readonly AsyncCacheBuffer<Int32, AttributeField> _loadedInputFields = new AsyncCacheBuffer<Int32, AttributeField>();

        private readonly AsyncCacheBuffer<Int32, Directory> _relocatedDirectories = new AsyncCacheBuffer<Int32, Directory>();

        private readonly AsyncCacheBuffer<View, Sprite> _loadedViews = new AsyncCacheBuffer<View, Sprite>();

        private Project _project;

        private IKOutput[] _filteredOutputs;
        
        private IKInput[] _filteredInputs;

        private String _projectDataGuid;

        private readonly TaskCompletionSource<Boolean> _3dModelLoadingToken = new TaskCompletionSource<Boolean>(false);

        private readonly GameObject _model3d = new GameObject();
        
        public ProjectViewModel(Int32 projectId) => InitByProjectId(projectId);

        public ProjectViewModel(IReactiveProperty<(Project project, String error)?> projectLateInit, String projectName)
        {
            projectLateInit.Where(it => it.HasValue).Select(it => it!.Value).Subscribe(project =>
            {
                if(project.error is null) 
                    InitByProject(project.project, projectName);
                else
                {
                    base.CancelLoading();
                    base.SetLoadStatus(UserInterface.LoadStatus.Error);
                }
            });
            
        }

        public async Task Request3DModelAsync()
        {
            if(_model3D.Value)
                return;
            
            await WaitForInit();
            _model3D.SetValueAndForceNotify(await CreateModel(_project, _model3d));
        }

        private static async Task<GameObject> CreateModel(Project project, GameObject gameObject)
        {
            try
            {
                var controller = gameObject.AddComponent<ProjectController>();
                controller.Data = project;
                await controller.Initialize();
                if(project.ProjectCategoryType == CategoryType.FLOOR || project.ProjectCategoryType == CategoryType.DOOR)
                    gameObject.transform.localPosition += (await controller.GetVisualBounds()).max / 2.0f;
                return gameObject;
            }
            catch
            {
                return null;
            }
        }
        
        public async void Recompute(ReactiveProperty<(Project, String error)?> onComputeEnd)
        {
            try
            {
                await base.WaitForInit();
                
                var original = _project.FindOriginal();
                var ik = original.IK;

                var inputsDict = CompileInputs(_loadedInputFields.Items.Select(it => it.Value));
                
                var clone = await _project.Calculate(await CalculationAttributes.FromIK(ik, inputsDict));

                await WaitCalculationsForComplete(clone.CalcId);
                
                onComputeEnd.SetValueAndForceNotify((clone, null));
            }
            catch (Exception exception)
            {
                if (exception is OperationCanceledException)
                    Debug.Log("Остановка перерасчета проекта!");
                else
                    Debug.LogError(exception.Message + "\n" + exception.StackTrace);
                
                onComputeEnd.SetValueAndForceNotify((null, "Error"));
            }
        }
        
        public async void RequestOutputFieldAt(Int32 index, IReactiveCommand<(Int32 index, AttributeField field)> onOutputFieldLoaded)
        {
            try
            {
                await base.WaitForInit();
                LoadOutputAt(index, onOutputFieldLoaded);
            }
            catch (Exception exception)
            {
                if (exception is OperationCanceledException)
                    Debug.Log("Остановка загрузки output'а проекта!");
                else
                    Debug.LogError(exception.Message);
            }
        }
        
        public async void RequestInputFieldAt(Int32 index, IReactiveCommand<(Int32 index, AttributeField field)> onInputFieldLoaded)
        {
            try
            {
                await base.WaitForInit();
                LoadInputAt(index, onInputFieldLoaded);
            }
            catch (Exception exception)
            {
                if (exception is OperationCanceledException)
                    Debug.Log("Остановка загрузки input'а проекта!");
                else
                    Debug.LogError(exception.Message);
            }
        }
        
        public async void RequestView(View view, IReactiveCommand<Sprite> onViewLoaded)
        {
            try
            {
                await base.WaitForInit();

                var link = $"calculations/{_projectDataGuid}/{view.ToString().ToLower()}.jpg";
                
                onViewLoaded?.Execute(await _loadedViews.Get(view, LoadImage(link)));
            }
            catch (Exception exception)
            {
                if (exception is OperationCanceledException)
                    Debug.Log($"Остановка загрузки view {view} проекта!");
                else
                    Debug.LogError(exception.Message);
            }
        }

        protected override void OnDispose()
        {
            Debug.Log("DISPOSE");
            
            Object.Destroy(_model3d);
            
            foreach (var loadedView in _loadedViews.Items.Select(it => it.Value).Where(it => it != null))
                Object.Destroy(loadedView.texture);
        }

        private async void LoadIconAtTreeField(TreeAttributeField field)
        {
            try
            {
                var valueIdDirectory = await GetDirectory(field.ValueId, false);
                field.SetIcon(await RestController.GetIcon(valueIdDirectory, base.CancellationToken));
            }
            catch (Exception exception)
            {
                if (exception is OperationCanceledException)
                    Debug.Log("Остановка загрузки иконки TreeField!");
                else
                    Debug.LogError(exception.Message);
            }
        }
        
        private async void LoadOutputAt(Int32 index, IReactiveCommand<(Int32 index, AttributeField field)> onOutputFieldLoaded)
        {
            try
            {
                var attribute = _filteredOutputs[index];

                var directory = await GetDirectory(attribute.DirectoryId);
                
                onOutputFieldLoaded?.Execute((index, await _loadedOutputFields.Get(index, AddField(directory, attribute.Type, attribute.Value, attribute.ValueId))));
            }
            catch (Exception exception)
            {
                if (exception is OperationCanceledException)
                    Debug.Log("Остановка загрузки output'а проекта!");
                else
                    Debug.LogError(exception.Message);
            }
        }

        private async void LoadInputAt(Int32 index, IReactiveCommand<(Int32 index, AttributeField field)> onInputFieldLoaded)
        {
            try
            {
                var attribute = _filteredInputs[index];

                var directory = await GetDirectory(attribute.DirectoryId);

                onInputFieldLoaded?.Execute((index, await _loadedInputFields.Get(index, AddField(directory, attribute.Type, attribute.Value, attribute.ValueId))));
            }
            catch (Exception exception)
            {
                if (exception is OperationCanceledException)
                    Debug.Log("Остановка загрузки input'а проекта!");
                else
                    Debug.LogError(exception.Message);
            }
        }
        
        private Task<AttributeField> AddField(Directory directory, AttributeType type, String value, String valueId)
        {
            if (type  != AttributeType.AttributeTypeEnum.TREE)
                return Task.Run(() => new TextAttributeField(directory.LocalId,
                    directory.Name,
                    value,
                    GetType(type)) as AttributeField);

            var field = new TreeAttributeField(directory.LocalId, directory.Name, value,
                Int32.Parse(valueId), type.GetTreeTypeDirectoryIDs());

            LoadIconAtTreeField(field);

            return Task.Run(() => field as AttributeField);
        }

        private async Task WaitCalculationsForComplete(Int32 calculationId)
        {
            var timer = 0;

            while (timer < CalculationTimeOutMs)
            {
                var calc = await NetworkClient.GetCalculation( calculationId, CancellationToken );

                if (calc.status == 4)
                    return;

                await Task.Delay( CalculationStatusRequestIntervalMs );
                timer += CalculationStatusRequestIntervalMs;
            }

            throw new Exception("Истекло время ожидания пересчета");
        }

        private static Dictionary<Int32, MinAttributeData> CompileInputs(IEnumerable<AttributeField> fields) => 
            fields.ToDictionary(field => field.LocalId, 
        field => new MinAttributeData(field.Value.Value, field is TreeAttributeField treeField? treeField.ValueId.ToString() : "-1"));
        
        private static IKInput[] FilterInputs(IEnumerable<IKInput> inputs) => inputs.Where(it => it.Order > 0).OrderBy(it => it.Order).ToArray();

        private static IKOutput[] FilterOutputs(IEnumerable<IKOutput> outputs) => outputs.Where(it => it.Order > 0).OrderBy(it => it.Order).ToArray();

        private async void InitByProjectId(Int32 projectId)
        {
            try
            {
                var directory = await Directory.Get(projectId, base.CancellationToken);
                
                directory = await directory.GetSelfOrRelocation(base.CancellationToken);
                
                _project = await S123.Models.Project.Project.Get(directory, base.CancellationToken);

                var projectInfo = (await NetworkClient.GetProjectInfo(directory.Id, base.CancellationToken));
               
                _projectOwner.SetValueAndForceNotify(new ProjectOwner(projectInfo.owner.name, projectInfo.owner.website));
                
                _projectDataGuid = projectInfo.calc_data_guid;
                
                _directoryId.SetValueAndForceNotify(directory.Id);

                _filteredInputs = FilterInputs(_project.IK.Inputs);
                _filteredOutputs = FilterOutputs(_project.IK.Outputs);
                
                _projectProperty.SetValueAndForceNotify(_project);
                _projectName.SetValueAndForceNotify(directory.Name);

                _outputsFieldsCount.SetValueAndForceNotify(_filteredOutputs.Length);
                _inputFieldsCount.SetValueAndForceNotify(_filteredInputs.Length);
                _hasInputs.SetValueAndForceNotify(_filteredInputs.Length > 0);
                
                SetInitComplete();
                base.SetLoadStatus(UserInterface.LoadStatus.Success);
            }
            catch (Exception exception)
            {
                if (exception is OperationCanceledException)
                {
                    Debug.Log("Остановка загрузки пересчитанного проекта!");
                    base.SetLoadStatus(UserInterface.LoadStatus.Cancel);
                }
                else
                {
                    Debug.LogError(exception.Message);
                    base.SetLoadStatus(UserInterface.LoadStatus.Error);
                }

                base.CancelLoading();
            }
        }

        private async void InitByProject(Project project, String projectName)
        {
            try
            {
                _project = project;
                
                var projectInfo = (await NetworkClient.GetProjectInfo(project.DirectoryId, base.CancellationToken));
               
                _projectOwner.SetValueAndForceNotify(new ProjectOwner(projectInfo.owner.name, projectInfo.owner.website));
                
                _projectDataGuid = project.DataGuid;

                _filteredInputs = FilterInputs(_project.IK.Inputs);
                _filteredOutputs = FilterOutputs(_project.IK.Outputs);
                
                _projectProperty.SetValueAndForceNotify(_project);
                _projectName.SetValueAndForceNotify(projectName);
                _outputsFieldsCount.SetValueAndForceNotify(_filteredOutputs.Length);
                _inputFieldsCount.SetValueAndForceNotify(_filteredInputs.Length);
                _hasInputs.SetValueAndForceNotify(_filteredInputs.Length > 0);
                
                _directoryId.SetValueAndForceNotify(project.DirectoryId);
                
                base.SetInitComplete();
                base.SetLoadStatus(UserInterface.LoadStatus.Success);
            }
            catch (Exception exception)
            {
                if (exception is OperationCanceledException)
                {
                    Debug.Log("Остановка загрузки пересчитанного проекта!");
                    base.SetLoadStatus(UserInterface.LoadStatus.Cancel);
                }
                else
                {
                    Debug.LogError(exception.Message);
                    base.SetLoadStatus(UserInterface.LoadStatus.Error);
                }

                base.CancelLoading();
            }
        }

        private async Task<Directory> GetDirectory(Int32 directoryId, Boolean withSelfOrRelocation = true)
        {
            async Task<Directory> Get()
            {
                var directory =  await Directory.Get(directoryId, base.CancellationToken);
                if (withSelfOrRelocation)
                    directory = await directory.GetSelfOrRelocation(base.CancellationToken);
                return directory;
            }

            return await _relocatedDirectories.Get(directoryId, Get());
        }
        
        private async Task<Sprite> LoadImage(String link)
        {
            var bytes = await NetworkClient.GetFile(link, base.CancellationToken);

            var texture = await TexturesContainer.LoadFromRawData(bytes);
            
            return Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), Vector2.one * 0.5f);
        }

        private static TextAttributeFieldType GetType(AttributeType attributeType)
        {
            if (attributeType == AttributeType.AttributeTypeEnum.NONE)
                return TextAttributeFieldType.String;

            if (attributeType == AttributeType.AttributeTypeEnum.DATE)
                return TextAttributeFieldType.String;

            if (attributeType == AttributeType.AttributeTypeEnum.DESC)
                return TextAttributeFieldType.String;

            if (attributeType == AttributeType.AttributeTypeEnum.REQUEST)
                return TextAttributeFieldType.String;

            if (attributeType == AttributeType.AttributeTypeEnum.STRING)
                return TextAttributeFieldType.String;

            if (attributeType == AttributeType.AttributeTypeEnum.INTEGER)
                return TextAttributeFieldType.Integer;

            if (attributeType == AttributeType.AttributeTypeEnum.PRICE)
                return TextAttributeFieldType.Integer;

            if (attributeType == AttributeType.AttributeTypeEnum.FLOAT)
                return TextAttributeFieldType.Single;

            if (attributeType == AttributeType.AttributeTypeEnum.WIDTH)
                return TextAttributeFieldType.Single;

            if (attributeType == AttributeType.AttributeTypeEnum.HEIGHT)
                return TextAttributeFieldType.Single;

            if (attributeType == AttributeType.AttributeTypeEnum.DEPTH)
                return TextAttributeFieldType.Single;
            
            var value = typeof(AttributeType).GetProperty("type", BindingFlags.NonPublic | BindingFlags.Instance)?.GetValue(attributeType);
            
            throw new InvalidEnumArgumentException($"Неопознанный тип: {value}!");
        }
    }
}