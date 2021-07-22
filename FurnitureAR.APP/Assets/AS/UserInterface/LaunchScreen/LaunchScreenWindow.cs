using AS.UserInterface;
using Tools.StyleSystem.Styles;
using UnityEngine;
using UnityEngine.UI;
using UserInterface.DirectoryTreeUI;
using UserInterface.Generated;
using Tools.WindowSystem;

namespace UserInterface
{

    public class LaunchScreenWindow : Window 
    {
        protected override GameObject CreateView()
        {
            var layout = Object.Instantiate(LayoutsContainer.LaunchScreenWindow);
            
            layout.transform.Find("Launch").GetComponent<Button>().onClick.AddListener(() =>
            {
                GetWindowsHolder(holder =>
                {
                    this.OpenWindow(holder, new DirectoryTreeWindow(349399));
                });
            });
            
            layout.transform.Find("ThemeSwitch").GetComponent<Button>().onClick.AddListener(() =>
            {
                GetWindowsHolder(holder =>
                {
                    Style.ThemeIndex = (Style.ThemeIndex + 1) % 2;
                    (holder as DefaultWindowsHolderMonoBehaviour.WindowsHolder)?.RecreateWindowsView();
                });
            });
            
            return layout;
        }
    }
}
