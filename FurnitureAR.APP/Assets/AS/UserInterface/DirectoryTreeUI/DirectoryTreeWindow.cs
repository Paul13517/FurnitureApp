using System;
using AS.UserInterface;
using Generated;
using Tools.AnimationUtility;
using UniRx;
using UnityEngine;
using UserInterface.Generated;
using UserInterface.ProjectUI;
using Tools.WindowSystem;
using Object = UnityEngine.Object;

namespace UserInterface.DirectoryTreeUI
{

    public class DirectoryTreeWindow : FullscreenWindow
    {
        public readonly Int32 DirectoryId;
        
        private DirectoryTreeViewModel _viewModel;
        
        private DirectoryTreeListElementBinding[] _listElements;

        private MonoBehaviourAnimations.MonoBehaviourStub _monobehaviourStub;

        private Transform _windowFrame;

        private WindowsHolder _windowsHolder;
        
        public DirectoryTreeWindow(Int32 directoryId)
        {
            GetWindowsHolder(windowHolder => _windowsHolder = windowHolder);
            GetWindowFrame(windowFrame =>
            {
                _windowFrame = windowFrame;
                _monobehaviourStub = windowFrame.gameObject.AddComponent<MonoBehaviourAnimations.MonoBehaviourStub>();
            });
            DirectoryId = directoryId;
            _viewModel = new DirectoryTreeViewModel(directoryId);
            OnDetach += () => _viewModel.Dispose();
        }
        
        public void Refresh()
        {
            _viewModel.Dispose();
            _viewModel = new DirectoryTreeViewModel(DirectoryId);
            RecreateView();
        }
        
        private void GoToParent(Int32 parentId)
        {
            GetWindowsHolder(holder =>
            {
                WindowAnimateTransitions.CloseWindow(holder, this);
            });
        }
        
        protected override GameObject CreateView()
        {
            var layout = Object.Instantiate(LayoutsContainer.DirectoryTreeWindowLayout);
            
            var binding = new DirectoryTreeWindowLayoutBinding(layout);
            
            _viewModel.DirectoryName
                .Subscribe(binding.MainTitleBar.MainTitleBarController.SetText)
                .AddTo(layout);

            _viewModel.DirectoryId.Subscribe(parentId =>
            {

                binding.BackIcon.Button.onClick.AddListener(() =>
                {
                    GetWindowFrame(windowFrame =>
                    {
                        GetWindowsHolder(holder =>
                        {
                            GoToParent(parentId);
                        });
                    });
                });
            }).AddTo(layout);
            
            binding.RefreshIcon.Button.onClick.AddListener(Refresh);
            _viewModel.DirectoryId.Subscribe(id =>            binding.InternetIcon.Button.onClick.AddListener(() => Application.OpenURL("https://system123.ru/sl/?directory=" + id))).AddTo(layout);
            
            _viewModel.ChildCount
                .Subscribe(childCount => CreateElements(childCount, binding.Content.RectTransform))
                .AddTo(layout);

            _viewModel.LoadStatus.Subscribe(binding.LoadErrorBar.LoadStatusBarController.SetStatus).AddTo(layout);
            
            return layout;
        }

        private void CreateElements(Int32 elementsCount, Transform root)
        {
            _listElements = new DirectoryTreeListElementBinding[elementsCount];

            for (var i = 0; i < _listElements.Length; i++)
            {
                _listElements[i] = new DirectoryTreeListElementBinding(Object.Instantiate(LayoutsContainer.DirectoryTreeListElement, root, false));

                var infoCallback = new ReactiveCommand<(Int32 index, DirectoryInfo id)>();

                infoCallback.Subscribe(SetListElementDirectoryInfo).AddTo(_listElements[i].GameObject);
                
                var iconCallback = new ReactiveCommand<(Int32 index, Sprite id)>();
                
                iconCallback.Subscribe(SetListElementIcon).AddTo(_listElements[i].GameObject);
                
                _viewModel.RequestChildDataAt(i, infoCallback, iconCallback);
            }
        }
        private void SetListElementIcon((Int32 position, Sprite icon) data)
        {
            var (index, icon) = data;
            var element = _listElements[index];
            _listElements[index].ContentIcon.Image.sprite = icon;
        }

        private void SetListElementDirectoryInfo((Int32 position, DirectoryInfo directoryInfo) data)
        {
            var (index, directoryInfo) = data;

            _listElements[index].ContentText.TextMeshProUGUI.text = directoryInfo.Name;

            _listElements[index].Button.onClick.AddListener(() => OpenTreeElement(directoryInfo));
        }

        private void OpenTreeElement(DirectoryInfo directoryInfo)
        {
            GetWindowsHolder(holder =>
            {
                switch (directoryInfo.Type)
                {
                    case S123Type.PROJECT:
                        this.OpenWindow(holder, new ProjectWindow(directoryInfo.Id, DirectoryId));
                        break;
                    default:
                        this.OpenWindow(holder, new DirectoryTreeWindow(directoryInfo.Id));
                        break;
                }
            });
        }
    }
}
