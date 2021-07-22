using System;
using System.Threading.Tasks;
using AS.UserInterface;
using Generated;
using S123.Network.Models;
using Tools.WindowSystem;
using UnityEngine;
using UserInterface.DirectoryTreeUI;
using UserInterface.Generated;
using Object = UnityEngine.Object;

namespace UserInterface.AuthWindow
{

    public class AuthWindow : Window
    {
        public const String PreferencesTag = "Account";

        protected override GameObject CreateView()
        {
            var layout = Object.Instantiate(LayoutsContainer.AuthWindow);

            var binding = new AuthWindowBinding(layout);

            var auth = binding.AuthorizeController;

            binding.Image0.Button.onClick.AddListener(() =>
            {
                binding.Image0.Button.enabled = false;
                binding.LoadingBar.GameObject.SetActive(true);
                Authorize(auth, it =>
                {
                    if (it)
                        GetWindowsHolder(holder => { this.OpenWindow(holder, new DirectoryTreeWindow(349399)); });

                    binding.LoadingBar.GameObject.SetActive(false);
                    binding.Image0.Button.enabled = true;
                });
            });

            return layout;
        }

        async Task<Boolean> Authorize(AuthorizeController authorizeController, Action<Boolean> onSuccess)
        {
            string username = "render1@arkatech.ru";
            string password = "efe63115efa7dfde28d17486382e589f1d0ab4a79cd76860f69f82c04a25761a";
            AuthorizeResult result = await authorizeController.Authorize(username, password);
            if (result.authenticationResult != 1)
            {
                Debug.LogError("Authorize error");
                onSuccess.Invoke(false);
                return false;
            }

            Debug.Log("Authorization successfull");
            onSuccess.Invoke(true);
            return true;
        }
    }
}