using Generated;
using GoogleARCore.Examples.HelloAR;
using Tools.WindowSystem;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using UserInterface.Generated;

namespace UserInterface.ProjectUI.ProjectARWindow
{
    
    public class ProjectARWindow : FullscreenWindow
    {
        private readonly ProjectViewModel _projectViewModel;

        public ProjectARWindow(ProjectViewModel projectViewModel) => _projectViewModel = projectViewModel;

        private GameObject _arModule;
        
        protected override GameObject CreateView()
        {
            var layout = Object.Instantiate(LayoutsContainer.ProjectARViewWindow);

            var binding = new ProjectARViewWindowBinding(layout);
            
            _projectViewModel.Request3DModelAsync();

            _projectViewModel.Model3D.Subscribe(model =>
                {
                    binding.LoadingBar.GameObject.SetActive(false);
                    GetWindowFrame(windowFrame => windowFrame.parent.GetComponent<Image>().enabled = false);
                    HelloARController.SelectedModel = model;
                    _arModule = Object.Instantiate(LayoutsContainer.ARModule);
                })
                .AddTo(layout);

            binding.BackIcon.Button.onClick.AddListener(() =>
            {
                GetWindowsHolder(holder => holder.DetachWindow(this));
            });            
            
            OnDetach += () =>
            {
                GetWindowFrame(windowFrame => windowFrame.parent.GetComponent<Image>().enabled = true);
                if(_arModule)
                    Object.Destroy(_arModule);
            };
            
            return layout;
        }
    }
}