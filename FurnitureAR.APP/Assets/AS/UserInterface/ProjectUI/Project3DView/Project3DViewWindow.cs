using Generated;
using Tools.WindowSystem;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using UserInterface.Generated;

namespace UserInterface.ProjectUI.Project3DView
{
    public class Project3DViewWindow : FullscreenWindow
    {
        private ProjectViewModel _viewModel;

        private GameObject _modelGameObject;

        private Project3DViewWindowBinding _binding; 
        
        public Project3DViewWindow(ProjectViewModel viewModel)
        {
            _viewModel = viewModel;
            OnDetach += () =>
            {
                GetWindowFrame(windowFrame =>
                {
                    windowFrame.parent.GetComponent<Image>().enabled = true;
                    _binding.Image.Image.enabled = true;
                    var com = Camera.main.GetComponent<MobilemaxCamera>();
                    com.enabled = false;
                });
            };
        }

        protected override GameObject CreateView()
        {
            var layout = Object.Instantiate(LayoutsContainer.Project3DViewWindow);
            _binding = new Project3DViewWindowBinding(layout);
            _viewModel.Request3DModelAsync();
            _binding.BackIcon.Button.onClick.AddListener(() =>
            {
                GetWindowsHolder(holder =>
                {
                    holder.DetachWindow(this);
                });
            });
            _viewModel.Model3D.Subscribe(go =>
            {
                _binding.LoadingBar.GameObject.SetActive(false);
                _binding.Image.Image.enabled = false;
                
                GetWindowFrame(windowFrame => windowFrame.parent.GetComponent<Image>().enabled = false);
                
                Camera.main.transform.position = new Vector3(0.0f, 0.0f, -5.0f);
                Camera.main.transform.rotation = Quaternion.identity;
                var com = Camera.main.GetComponent<MobilemaxCamera>();
                com.targetOffset = Vector3.zero;
                com.target = go.transform;
                com.enabled = true;
                
            }).AddTo(layout);
            return layout;
        }
        
    }
}
