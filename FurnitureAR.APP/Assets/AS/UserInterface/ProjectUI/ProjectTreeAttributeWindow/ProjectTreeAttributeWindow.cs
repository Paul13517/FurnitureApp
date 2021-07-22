using System;
using Generated;
using Tools.WindowSystem;
using UniRx;
using UnityEngine;
using UserInterface.Generated;
using Object = UnityEngine.Object;

namespace UserInterface.ProjectUI.ProjectTreeAttributeWindow
{
    public class ProjectTreeAttributeWindow : FullscreenWindow
    {
        private ProjectAttributeTreeViewModel _viewModel;
        
        private readonly TreeAttributeField _treeAttributeField;

        private GridElementTempBinding[] _items;
        
        public ProjectTreeAttributeWindow(TreeAttributeField treeAttributeField)
        {
            _treeAttributeField = treeAttributeField;
            _viewModel = new ProjectAttributeTreeViewModel(treeAttributeField);
            OnDetach += () => _viewModel.Dispose();
        }

        public void Refresh()
        {
            _viewModel.Dispose();
            _viewModel = new ProjectAttributeTreeViewModel(_treeAttributeField);
            RecreateView();
        }

        protected override GameObject CreateView()
        {
            var layout = Object.Instantiate(LayoutsContainer.ProjectTreeAttributeWindow);
            
            var binding = new ProjectTreeAttributeWindowBinding(layout);
            
            
            _viewModel.AttributeName
                .Subscribe(binding.MainTitleBar.MainTitleBarController.SetText)
                .AddTo(layout);
            
            _viewModel.LoadStatus
                .Subscribe(binding.LoadErrorBar.LoadStatusBarController.SetStatus).AddTo(layout);

            _viewModel.ItemCount.Subscribe(count =>
            {
                CreateItems(binding.Content.RectTransform, count);

                for (var i = 0; i < count; i++)
                {
                    var onItemLoadCallback = new ReactiveCommand<(Int32 index, String name, Sprite icon)>();
                    onItemLoadCallback.
                        Subscribe(itemInfo => CreateItem(itemInfo.index, itemInfo.name, itemInfo.icon))
                        .AddTo(_items[i].GameObject);
                    
                    _viewModel.RequestChildIconAt(i, onItemLoadCallback);
                }
            }).AddTo(layout);

            _viewModel.SelectedItem.Subscribe(item => Close()).AddTo(layout);
            
            binding.BackIcon.Button.onClick.AddListener(Close);
            binding.RefreshIcon.Button.onClick.AddListener(Refresh);

            return layout;
        }

        private void Close()
        {
            GetWindowsHolder(holder => holder.DetachWindow(this));
        }

        private void CreateItem(Int32 index, String name, Sprite icon)
        {
            var item = _items[index];

            Object.Destroy(item.Icon.ImageStyleHolder);
            
            item.Icon.Image.sprite = icon;
            item.Icon.Image.color = Color.white;
            
            item.TextTMP.TextMeshProUGUI.text = name;
            
            item.Button.onClick.AddListener(() => _viewModel.SelectAt(index));
        }
        
        private void CreateItems(Transform root, Int32 count)
        {
            _items = new GridElementTempBinding[count];
            for (var i = 0; i < count; i++)
                _items[i] = new GridElementTempBinding(Object.Instantiate(LayoutsContainer.GridElementTemp, root, false));
        }
    }
}