using Generated;
using Tools.WindowSystem;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using UserInterface.Generated;

namespace UserInterface.ProjectUI
{
    public class Project2DViewWindow : FullscreenWindow
    {
        private ProjectViewModel _viewModel;
        
        public Project2DViewWindow(ProjectViewModel viewModel) => _viewModel = viewModel;

        protected override GameObject CreateView()
        {
            var layout = Object.Instantiate(LayoutsContainer.Project2DViewWindow);
            var binding = new Project2DViewWindowBinding(layout);
            
            LoadView(binding.MainView.Image, ProjectViewModel.View.Main);
            LoadView(binding.FrontView.Image, ProjectViewModel.View.Front);
            LoadView(binding.TopView.Image, ProjectViewModel.View.Top);
            LoadView(binding.LeftView.Image, ProjectViewModel.View.Left);
            LoadView(binding.RightView.Image, ProjectViewModel.View.Right);
         
            binding.BackIcon.Button.onClick.AddListener(() => GetWindowsHolder(holder => holder.DetachWindow(this)));
            
            return layout;
        }

        private void LoadView(Image image, ProjectViewModel.View view)
        {
            var loadSpriteCallback = new ReactiveCommand<Sprite>();
            loadSpriteCallback.Subscribe(sprite =>
            {
                image.sprite = sprite;
                Object.Destroy(image.transform.GetChild(0).gameObject);
            }).AddTo(image);
            _viewModel.RequestView(view, loadSpriteCallback);
        }
    }

}