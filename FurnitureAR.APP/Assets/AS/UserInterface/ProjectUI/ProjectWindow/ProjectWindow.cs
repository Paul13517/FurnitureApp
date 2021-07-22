using System;
using AS.UserInterface;
using Generated;
using GoogleARCore.Examples.HelloAR;
using S123.Models.Project;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UserInterface.Generated;
using UserInterface.ProjectUI.Project3DView;
using UserInterface.Tools;
using Tools.WindowSystem;
using Image = UnityEngine.UI.Image;
using Object = UnityEngine.Object;

namespace UserInterface.ProjectUI
{

    public class ProjectWindow : Window
    {

        private ProjectViewModel _viewModel;
        
        private readonly Int32 _projectId;
        
        private Transform[] _outputsItemHolders;

        private SwipeDetector _swipeDetector;
        
        private readonly IReactiveProperty<(Project, String error)?> _project;
        
        private readonly String _preInitProjectName;

        private ProjectWindowPortraitLayoutBinding _binding;

        private readonly ReactivePropertyNoInit<Boolean> _loadingModel = new ReactivePropertyNoInit<Boolean>();

        private readonly Int32 _parentDirectoryId;
        
        private Transform[] _inputsItemHolders;
        
        public ProjectWindow(Int32 projectId, Int32 parentDirectoryId)
        {
            _projectId = projectId;
            _parentDirectoryId = parentDirectoryId;
            _viewModel = new ProjectViewModel(projectId);
            OnDetach += () => _viewModel.Dispose();
        }
        
        public ProjectWindow(IReactiveProperty<(Project, String error)?> projectProperty, String preInitProjectName, Int32 parentDirectoryId)
        {
            _project = projectProperty;
            _preInitProjectName = preInitProjectName;
            _parentDirectoryId = parentDirectoryId;
            _viewModel = new ProjectViewModel(projectProperty, preInitProjectName);
            OnDetach += () => _viewModel.Dispose();
        }
        
        private void CreateInputItems(Transform root, Int32 count)
        {
            _inputsItemHolders = new Transform[count];
            for (var i = 0; i < count; i++)
            {
                var go = new GameObject("ItemHolder");
                var rectTransform = go.AddComponent<RectTransform>();
                rectTransform.sizeDelta = new Vector2(0.0f, LayoutsContainer.TextFieldReadOnlyLayout.GetComponent<RectTransform>().sizeDelta.y);
                go.transform.SetParent(root, false);
                _inputsItemHolders[i] = go.transform;
            }
        }
        
        private void CreateInputAttributeField(Int32 index, AttributeField attributeField)
        {
            switch (attributeField)
            {
                case TextAttributeField textField:
                {
                    var fieldGameObject = Object.Instantiate(LayoutsContainer.TextFieldInputLayout, _inputsItemHolders[index], false);

                    var fieldBinding = new TextFieldInputLayoutBinding(fieldGameObject);
                    
                    fieldBinding.TitleText.TextMeshProUGUI.text = textField.Name;

                    var inputField = fieldBinding.InputField.TMP_InputField;

                    inputField.text = attributeField.Value.Value;

                    inputField.characterValidation = textField.Type switch
                    {
                        TextAttributeFieldType.String => TMP_InputField.CharacterValidation.None,
                        TextAttributeFieldType.Single => TMP_InputField.CharacterValidation.Decimal,
                        TextAttributeFieldType.Integer => TMP_InputField.CharacterValidation.Integer,
                        _ => inputField.characterValidation
                    };

                    inputField.onValueChanged.AddListener(attributeField.UpdateValue);
                    break;
                }
                case TreeAttributeField treeField:
                {
                    var fieldGameObject = Object.Instantiate(LayoutsContainer.TreeFieldInputLayout, _inputsItemHolders[index], false);

                    var fieldBinding = new TreeFieldInputLayoutBinding(fieldGameObject);

                    fieldBinding.TitleText.TextMeshProUGUI.text = treeField.Name;

                    treeField.Value.Subscribe(newValue => 
                        fieldBinding.ValueText.TextMeshProUGUI.text = newValue)
                        .AddTo(fieldGameObject);
                    
                    treeField.Icon.Subscribe(sprite =>
                        fieldBinding.Icon.Image.sprite = sprite)
                        .AddTo(fieldGameObject);
                
                    fieldGameObject.GetComponentInChildren<Button>().onClick.AddListener(() =>
                        GetWindowsHolder(holder => 
                            this.OpenWindow(holder, new ProjectTreeAttributeWindow.ProjectTreeAttributeWindow(treeField))
                        )
                    );
                    break;
                }
            }
        }
        
        private void InitToolWindow()
        {
            _viewModel.InputFieldsCount
                .Subscribe(count =>
                {
                    CreateInputItems(_binding.Content1.RectTransform, count);
                    for (var i = 0; i < count; i++)
                    {
                        var fieldCallback = new ReactiveCommand<(Int32 index, AttributeField field)>();
                        fieldCallback.Subscribe(it => CreateInputAttributeField(it.index, it.field)).AddTo(_inputsItemHolders[i]);
                        _viewModel.RequestInputFieldAt(i, fieldCallback);
                    }
                })
                .AddTo(_binding.Content1.GameObject);
            
            GetWindowsHolder(holder =>
            {
                Observable.EveryUpdate().Subscribe(it =>
                {
                    _binding.ViewPager.IsEnabled = IsClickable;
                    if (!IsVisible) return;
                    if (IsClickable && Input.GetKeyDown(KeyCode.Escape))
                    {
                        if (_binding.ViewPager.Scroll > -0.5f)
                            holder.DetachWindow(this);
                        else 
                            _binding.ViewPager.Position = 0;
                    }
                });
            });
            _binding.BackIcon2.Button.onClick.AddListener(() =>
            {
                _binding.ViewPager.Position = 0;
            });
            // GetWindowsHolder(windowHolder =>
            // {
            //     _toolSpecificationWindow = new ProjectToolSpecificationWindow(_viewModel);
            //     windowHolder.AttachWindow(_toolSpecificationWindow);
            //     _toolSpecificationWindow.GetWindowFrame(windowFrame =>
            //     {
            //
            //         windowFrame.anchorMin = new Vector2(1.0f, 0.0f);
            //         windowFrame.anchorMax = new Vector2(2.0f, 1.0f);
            //         
            //         _swipeDetector = new SwipeDetector(15, 100);
            //
            //         var p = 0.0f;
            //
            //         _toolSpecificationWindow.Binding.BackIcon.Button.onClick.AddListener(() => p = 0.0f);
            //
            //         Observable.EveryUpdate().Subscribe(it =>
            //         {
            //             if (!IsVisible) return;
            //             if (IsClickable && Input.GetKeyDown(KeyCode.Escape))
            //             {
            //                 if (p < 0)
            //                     p = 0.0f;
            //                 else
            //                     windowHolder.DetachWindow(this);
            //             }
            //
            //             windowFrame.anchorMin = Vector2.Lerp(windowFrame.anchorMin, new Vector2(p + 1.0f, 0.0f), Time.deltaTime * 25.0f);
            //             windowFrame.anchorMax = Vector2.Lerp(windowFrame.anchorMax, new Vector2(p + 2.0f, 1.0f), Time.deltaTime * 25.0f);
            //
            //             if (Input.GetMouseButtonDown(0))
            //                 _swipeDetector.PushTouch(Input.mousePosition, TouchPhase.Began);
            //             else if (Input.GetMouseButtonUp(0))
            //                 _swipeDetector.PushTouch(Input.mousePosition, TouchPhase.Ended);
            //             else
            //                 _swipeDetector.PushTouch(Input.mousePosition, TouchPhase.Moved);
            //         }).AddTo(windowFrame);
            //         
            //         var start = false;
            //         var windowFramePos = windowFrame.anchorMin.x;
            //         var scrollRectScroll = 0.0f;
            //         var scrollRectScroll1 = 0.0f;
            //         
            //         _swipeDetector.OnDrag += position =>
            //         {
            //             if (!IsVisible) return;
            //
            //             if (!start)
            //             {
            //                 _toolSpecificationWindow.IsClickable = false;
            //                 IsClickable = false;
            //                 windowFramePos = p;
            //                 start = true;
            //                 scrollRectScroll = _binding.ScrollView.ScrollRect.normalizedPosition.y;
            //                 scrollRectScroll1 = _toolSpecificationWindow.Binding.ScrollView.ScrollRect.normalizedPosition.y;
            //             }
            //
            //             p = (position.x / Screen.width + windowFramePos);
            //             if (p > 0.0f)
            //                 p = 0.0f;
            //             else if (p < -1.0f)
            //                 p = -1.0f;
            //             _binding.ScrollView.ScrollRect.normalizedPosition = new Vector2(0.0f, scrollRectScroll);
            //             _toolSpecificationWindow.Binding.ScrollView.ScrollRect.normalizedPosition = new Vector2(0.0f, scrollRectScroll1);
            //         };
            //
            //         _swipeDetector.OnStopDrag += () =>
            //         {
            //             if (!IsVisible) return;
            //
            //             _toolSpecificationWindow.IsClickable = true;
            //             IsClickable = true;
            //             start = false;
            //             p = windowFrame.anchorMin.x > 0.5f ? 0 : -1;
            //         };
            //
            //         _swipeDetector.OnSwipe += dir =>
            //         {
            //             if (!IsVisible) return;
            //
            //             if (dir is SwipeDetector.SwipeDirection.Left || dir is SwipeDetector.SwipeDirection.Right)
            //                 p = dir is SwipeDetector.SwipeDirection.Left ? -1 : 0;
            //         };
            //     });
            //     OnDetach += () => windowHolder.DetachWindow(_toolSpecificationWindow);
            // });


        }

        public void Refresh()
        {
            _viewModel.Dispose();
            if (_project is null)
            {
                _viewModel = new ProjectViewModel(_projectId);
                RecreateView();
            }
            else
            {
                _viewModel = new ProjectViewModel(_project, _preInitProjectName);
                RecreateView();
            }

        }

        protected override GameObject CreateView()
        {

            var layout = Object.Instantiate(LayoutsContainer.ProjectWindowPortraitLayout);

            var binding = new ProjectWindowPortraitLayoutBinding(layout);
            _binding = binding;
            
            InitToolWindow();

            GetWindowsHolder(windowsHolder =>
            {
                binding.BackIcon.Button.onClick.AddListener(() =>
                {
                    WindowAnimateTransitions.CloseWindow(windowsHolder, this);
                });
            });
            
            binding.RefreshIcon.Button.onClick.AddListener(Refresh);
            _viewModel.DirectoryId.Subscribe(id =>             binding.InternetIcon.Button.onClick.AddListener(() => Application.OpenURL("https://system123.ru/sl/?directory=" + id))).AddTo(layout);

            _viewModel.ProjectName.Subscribe(binding.MainTitleBar.MainTitleBarController.SetText)
                .AddTo(layout);

            _viewModel.OutputsFieldsCount.Subscribe(count =>
            {
                CreateOutputItems(binding.OutputsFieldsContainer.RectTransform, count);
                
                LayoutRebuilder.ForceRebuildLayoutImmediate(binding.Content.RectTransform);
                
                for (var i = 0; i < count; i++)
                {
                    var fieldCallback = new ReactiveCommand<(Int32 index, AttributeField field)>();
                    fieldCallback.Subscribe(it => CreateAttributeField(it.index, it.field)).AddTo(_outputsItemHolders[i]);
                    _viewModel.RequestOutputFieldAt(i, fieldCallback);
                }
            }).AddTo(layout);

            _viewModel.LoadStatus.Subscribe(state =>
            {
                binding.LoadErrorBar.LoadStatusBarController.SetStatus(state);
                if (!(state is LoadStatus.Success)) 
                    return;
                binding.MainTitleBar.GameObject.SetActive(true);

            }).AddTo(layout);

            var viewLoadCallback = new ReactiveCommand<Sprite>();
            
            viewLoadCallback.Subscribe(image =>
            {
                binding.MainView.Image.sprite = image;
                binding.MainView.GameObject.SetActive(true);
            }).AddTo(binding.MainView.GameObject);

            _viewModel.RequestView(ProjectViewModel.View.Main, viewLoadCallback);

            _viewModel.HasInputs
                .Where(hasInputs => hasInputs is true)
                .Subscribe(_ => OnHasInputs(layout.transform, binding.ScrollView.ScrollRect, binding.MainView.RectTransform))
                .AddTo(layout);

           binding.Enter2DButton.Button.onClick.AddListener(() => GetWindowsHolder(holder => 
                
                this.OpenWindow(holder, new Project2DViewWindow(_viewModel))));
        
            binding.EnterARButton.Button.onClick.AddListener(() =>
            {
                GetWindowsHolder(holder =>
                {
                    this.OpenWindow(holder, new ProjectARWindow.ProjectARWindow(_viewModel));
                });
            });
            
            binding.Enter3DButton.Button.onClick.AddListener(() =>
            {
                GetWindowsHolder(windowHolder =>
                {
                    this.OpenWindow(windowHolder, new Project3DViewWindow(_viewModel));
                });
            });
            
            binding.RecomputeButton.Button.onClick.AddListener(() =>
            {
                var recomputeCallback = new ReactiveProperty<(Project, String error)?>();
                
                _viewModel.Recompute(recomputeCallback);
                
                GetWindowsHolder(holder =>
                {
                    this.OpenWindow(holder, new ProjectWindow(recomputeCallback, _viewModel.ProjectName.Value, _viewModel.DirectoryId.Value));
                });
            });

            _viewModel.ProjectOwner.Subscribe(it =>
            {
                binding.OwnerName.TextMeshProUGUI.text = "Производитель: " +  it.Name;
                binding.OwnerLink.TextMeshProUGUI.text = it.Link;
                binding.BaseField.Button.onClick.AddListener(() =>
                {
                    Application.OpenURL(it.Link.Contains(":") ? it.Link : "https://" + it.Link);
                });
            }).AddTo(layout);
            
            _loadingModel.Subscribe(it =>
            {
                // CanClose = !it;
                // IsClickable = false;
                // _binding.GameObject.transform.Find("LoadingBar").gameObject.SetActive(true);
            }).AddTo(layout);
            
            return layout;
        }

        private async void OpenAR(Project project)
        {
            ProjectController controller = new GameObject().AddComponent<ProjectController>();
            controller.Data = project;
            await controller.Initialize();
            _binding.GameObject.transform.parent.parent.GetComponent<Image>().enabled = false;
            IsVisible = false;
            HelloARController.SelectedModel = controller.gameObject;
            SceneManager.LoadScene("HelloAR", LoadSceneMode.Additive);
        }
        
        private void OnHasInputs(Transform layout, ScrollRect scrollRect, RectTransform mainView)
        {
        //    var toolSpecsBar = Object.Instantiate(LayoutsContainer.ToolSpecsBar, layout, false).GetComponent<RectTransform>();

          //  toolSpecsBar.SetSiblingIndex(1);

            var scrollRectRectTransform = scrollRect.GetComponent<RectTransform>();
            var scrollRectOffset = scrollRectRectTransform.offsetMax;

            //var toolSpecsBarWidth = toolSpecsBar.rect.width;

            var mainViewOffset = mainView.offsetMin;
            
          //  mainViewOffset = new Vector2(mainViewOffset.x - (toolSpecsBarWidth + scrollRectOffset.x), mainViewOffset.y);
            mainView.offsetMin = mainViewOffset;

         //   scrollRectRectTransform.offsetMax = new Vector2(-toolSpecsBarWidth, scrollRectOffset.y);
        }

        private void SetSwipeDetector(Transform lifecycleOwner, Action onSwipeLeft)
        {
            _swipeDetector = new SwipeDetector(50, 100);

            Observable.EveryUpdate().Subscribe(it =>
            {
                if (Input.GetMouseButtonDown(0))
                    _swipeDetector.PushTouch(Input.mousePosition, TouchPhase.Began);
                else if (Input.GetMouseButtonUp(0))
                    _swipeDetector.PushTouch(Input.mousePosition, TouchPhase.Ended);
                else
                    _swipeDetector.PushTouch(Input.mousePosition, TouchPhase.Moved);
                
            }).AddTo(lifecycleOwner);

            _swipeDetector.OnSwipe += direction =>
            {
                if (!IsClickable)
                    return;

                if (direction == SwipeDetector.SwipeDirection.Left)
                    onSwipeLeft?.Invoke();
            };
        }
        
        private void CreateOutputItems(Transform root, Int32 count)
        {
            _outputsItemHolders = new Transform[count];
            for (var i = 0; i < count; i++)
            {
                var go = new GameObject("ItemHolder");
                var rectTransform = go.AddComponent<RectTransform>();
                rectTransform.sizeDelta = new Vector2(0.0f, LayoutsContainer.TextFieldReadOnlyLayout.GetComponent<RectTransform>().sizeDelta.y);
                go.transform.SetParent(root, false);
                _outputsItemHolders[i] = go.transform;
            }
        }

        private void CreateAttributeField(Int32 index, AttributeField attributeField)
        {
            switch (attributeField)
            {
                case TextAttributeField textField:
                {
                    var fieldGameObject = Object.Instantiate(LayoutsContainer.TextFieldReadOnlyLayout, _outputsItemHolders[index], false);
                    var fieldBinding = new TextFieldInputLayoutBinding(fieldGameObject);
                    fieldBinding.ValueText.TextMeshProUGUI.text = textField.Value.Value;
                    fieldBinding.TitleText.TextMeshProUGUI.text = textField.Name;
                    break;
                }
                case TreeAttributeField treeField:
                {
                    var fieldGameObject = Object.Instantiate(LayoutsContainer.TreeFieldReadOnlyLayout, _outputsItemHolders[index], false);

                    var fieldBinding = new TreeFieldInputLayoutBinding(fieldGameObject);
                    
                    fieldBinding.ValueText.TextMeshProUGUI.text = treeField.Value.Value;
                    fieldBinding.TitleText.TextMeshProUGUI.text = treeField.Name;

                    treeField.Icon.Subscribe(sprite => fieldBinding.Icon.Image.sprite = sprite).AddTo(fieldGameObject);
                    break;
                }
            }
        }
    }
}
