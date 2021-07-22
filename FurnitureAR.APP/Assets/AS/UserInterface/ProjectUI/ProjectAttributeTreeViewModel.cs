using System;
using System.Collections.Generic;
using AS.Tools;
using S123.Models.Tree;
using UniRx;
using UnityEngine;

namespace UserInterface.ProjectUI
{
    public class ProjectAttributeTreeViewModel : ViewModelForNetwork
    {
        public IReactiveProperty<String> AttributeName => _attributeName;

        public IReactiveProperty<Int32> ItemCount => _itemCount;
        
        public IReactiveProperty<Int32> SelectedItem => _selectedItem;
        
        private readonly ReactivePropertyNoInit<String> _attributeName = new ReactivePropertyNoInit<String>();
        
        private readonly ReactivePropertyNoInit<Int32> _itemCount = new ReactivePropertyNoInit<Int32>();
        
        private readonly ReactivePropertyNoInit<Int32> _selectedItem = new ReactivePropertyNoInit<Int32>();

        private readonly List<Directory> _directories = new List<Directory>();

        private readonly AsyncCacheBuffer<Int32, Sprite> _loadedIcons = new AsyncCacheBuffer<Int32, Sprite>();

        private readonly TreeAttributeField _treeAttribute;
        
        public ProjectAttributeTreeViewModel(TreeAttributeField treeAttribute)
        {
            _treeAttribute = treeAttribute;
            Init(treeAttribute);
        }

        public async void SelectAt(Int32 index)
        {
            try
            {
                await base.WaitForInit();

                _treeAttribute.UpdateValue(_directories[index].Name);
                _treeAttribute.ValueId = _directories[index].Id;
                _treeAttribute.SetIcon(_loadedIcons.Items[index]);
                _treeAttribute.Name = _directories[index].Name;
                _selectedItem.SetValueAndForceNotify(index);
            }
            catch
            {
                Debug.LogError("Select вызыван до инициализации!");
            }
        }
        
        public async void RequestChildIconAt(Int32 index, IReactiveCommand<(Int32 index, String name, Sprite icon)> onItemLoaded)
        {
            try
            {
                await base.WaitForInit();
                
                onItemLoaded.Execute((index, _directories[index].Name, await _loadedIcons.Get(index, RestController.GetIcon(_directories[index], base.CancellationToken))));

            }
            catch(Exception exception)
            {
                if (exception is OperationCanceledException)
                    Debug.Log($"Остановка загрузки элемента списка {index} древополя");
                else
                    Debug.LogError(exception.Message);
            }
        }

        private async void Init(TreeAttributeField treeAttribute)
        {
            try
            {
                foreach (var directoryId in treeAttribute.Directories)
                {
                    var directory = await Directory.Get(directoryId, base.CancellationToken);
                    directory = await directory.GetSelfOrRelocation(base.CancellationToken);
                    var childrenDirectories = await directory.GetChildren( false, base.CancellationToken );
                    foreach (var childDirectory in childrenDirectories)
                        _directories.Add(await childDirectory.GetSelfOrRelocation(base.CancellationToken));
                    

                    base.SetInitComplete();
                    base.SetLoadStatus(UserInterface.LoadStatus.Success);

                    _attributeName.SetValueAndForceNotify(treeAttribute.Name);
                    _itemCount.SetValueAndForceNotify(_directories.Count);
                }
            }
            catch (Exception exception)
            {
                if (exception is OperationCanceledException)
                {
                    Debug.Log($"Остановка загрузке полядеревоwtf");
                    base.SetLoadStatus(UserInterface.LoadStatus.Cancel);
                }
                else
                {
                    Debug.LogError(exception.Message);
                    base.SetLoadStatus(UserInterface.LoadStatus.Error);
                }
                
                CancelLoading();
            }
        }
    }
}
