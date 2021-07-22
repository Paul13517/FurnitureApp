using System;
using System.Collections.Generic;
using AS.UserInterface;
using Tools.StyleSystem;
using Tools.StyleSystem.Styles;
using UnityEngine;

namespace Tools.WindowSystem
{
    public sealed class DefaultWindowsHolderMonoBehaviour : MonoBehaviour
    {
        public sealed class WindowsHolder : Window.WindowsHolder
        {
            public event Action OnUiRecreate;

            private readonly HashSet<Window> _windows = new HashSet<Window>();

            private readonly RectTransform _rectTransform;

            public WindowsHolder(RectTransform rectTransform) => _rectTransform = rectTransform;

            public override void AttachWindow(Window window)
            {
                _windows.Add(window);
                AttachWindowAccessor(window, _rectTransform);
            }

            public override void DetachWindow(Window window)
            {
                _windows.Remove(window);
                DetachWindowAccessor(window);
            }

            public void RecreateWindowsView()
            {
                OnUiRecreate?.Invoke();
                foreach (var window in _windows)
                {
                    window.RecreateView();
                }
            }
        }

        [SerializeField] private ImageStyle _statusBarColorStyle;
        
        [SerializeField] private ImageStyle _navigationBarColorStyle;
        
        public WindowsHolder Instance => _instanceForLazyInit ??= new WindowsHolder(GetComponent<RectTransform>());

        private WindowsHolder _instanceForLazyInit;

        private void OnApplicationFocus(Boolean hasFocus)
        {
         
        }

        public void Awake()
        {
            Instance.OnUiRecreate += () => GetComponent<IStyleHolder>().Apply();
            if (!(Application.platform is RuntimePlatform.Android)) 
                return;
            
            Screen.fullScreen = false;
            NativeAndroid.RunOnAndroidUiThread(() =>
            {
                NativeAndroid.GetWindow().Call("setStatusBarColor", 0);
                NativeAndroid.GetWindow().Call("clearFlags", 0x00000400);
                NativeAndroid.UnityPlayer.Call("setSystemUiVisibility",
                    NativeAndroid.UnityPlayer.Call<Int32>("getSystemUiVisibility") &
                    ~(
                        NativeAndroid.SystemUIFlagImmersiveSticky |
                        NativeAndroid.SystemUIFlagLayoutStable |
                        NativeAndroid.SystemUIFlagLayoutFullscreen |
                        NativeAndroid.SystemUIFlagHideNavigation |
                        NativeAndroid.SystemUIFlagLayoutHideNavigation |
                        NativeAndroid.SystemUIFlagFullscreen)
                );
                NativeAndroid.MakeToast("SET");
            });

            NativeAndroid.RunOnAndroidUiThread(() =>
            {
                var window = NativeAndroid.MainActivity.Call<AndroidJavaObject>("getWindow");
                window.Call("addFlags", 0x80000000);
                window.Call("clearFlags", 0x04000000);
                window.Call("setStatusBarColor", 0);
                window.Call<AndroidJavaObject>("getDecorView")
                    .Call("setSystemUiVisibility", 0x00000100 | 0x00000400);
            });
            NativeAndroid.SetStatusBarTheme(NativeAndroid.Theme.Light);
            NativeAndroid.SetNavigationBarTheme(NativeAndroid.Theme.Dark);
            NativeAndroid.SetNavigationBarColor(0);
        }
    }
}