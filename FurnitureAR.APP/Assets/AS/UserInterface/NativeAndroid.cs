using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace AS.UserInterface
{
    public static class NativeAndroid
    {
        public static AndroidJavaObject MainActivity => _mainActivity ??= new AndroidJavaClass("com.unity3d.player.UnityPlayer")
            .GetStatic<AndroidJavaObject>("currentActivity");

        public static AndroidJavaClass Build => _build ??= new AndroidJavaClass("android.os.Build");

        public static AndroidJavaClass BuildVersion => _buildVersion ??= new AndroidJavaClass("android.os.Build$VERSION");

        public static AndroidJavaObject UnityPlayer => _unityPlayer ??= MainActivity.Get<AndroidJavaObject>("mUnityPlayer");
        
        private static AndroidJavaClass _build; 
        
        private static AndroidJavaClass _buildVersion; 
        
        private static AndroidJavaObject _mainActivity;

        private static AndroidJavaClass _toastClass;

        private static AndroidJavaObject _unityPlayer;
            
        public static Int32 ApiVersion => BuildVersion.GetStatic<Int32>("SDK_INT");

        public const Int32 SystemUIFlagImmersiveSticky = 0x00001000;
        
        public const Int32 SystemUIFlagLayoutStable = 0x00000100;
        
        public const Int32 SystemUIFlagLayoutFullscreen = 0x00000400;
        
        public const Int32 SystemUIFlagLayoutHideNavigation = 0x00000200;
        
        public const Int32 SystemUIFlagHideNavigation = 0x00000002;
        
        public const Int32 SystemUIFlagFullscreen = 0x00000004;

        public const Int32 SystemUIFlagLightStatusBar = 0x00002000;
        
        public const Int32 SystemUIFlagLightNavigationBar = 0x00000010;

        
        public abstract class OnSystemUiVisibilityChangeListener : AndroidJavaProxy
        {
            protected OnSystemUiVisibilityChangeListener()
                : base("android.view.View$OnSystemUiVisibilityChangeListener")
            {
            }
            
            // ReSharper disable once InconsistentNaming
            public abstract void onSystemUiVisibilityChange(Int32 visibility);
        }
        
        public static void RunOnAndroidUiThread(Action action)
        {
            try
            {
                MainActivity.Call("runOnUiThread", new AndroidJavaRunnable(() => action?.Invoke()));
            }
            catch (Exception exception)
            {
                Debug.LogError(exception);
            }
        }

        public static async Task RunOnAndroidUiThreadAsync(Action action)
        {
            try
            {
                var returnTask = new TaskCompletionSource<Boolean>();

                RunOnAndroidUiThread(() =>
                {
                    action?.Invoke();
                    returnTask.SetResult(true);
                });

                await returnTask.Task;
            }
            catch (Exception exception)
            {
                Debug.LogError(exception);
            }
        }

        public static void RunOnAndroidUiThreadSync(Action action)
        {
            try
            {
                var waitHandle = new ManualResetEvent(false);

                RunOnAndroidUiThread(() =>
                {
                    action?.Invoke();
                    waitHandle.Set();
                });

                waitHandle.WaitOne();
            }
            catch (Exception exception)
            {
                Debug.LogError(exception);
            }
        }

        public static AndroidJavaObject GetResources() => MainActivity.Call<AndroidJavaObject>("getResources");
        
        public static AndroidJavaObject GetWindow() => MainActivity.Call<AndroidJavaObject>("getWindow");
        
        public static Int32 GetStatusBarHeight()
        {
            if(Application.platform is RuntimePlatform.Android)
            {
                var resources = GetResources();
                
                var resourcesId = resources.Call<Int32>("getIdentifier", "status_bar_height", "dimen", "android");

                if (resourcesId > 0)
                    return resources.Call<Int32>("getDimensionPixelSize", resourcesId);
            }
            return 0;
        }

        public static AndroidJavaObject GetDecorView() => GetWindow().Call<AndroidJavaObject>("getDecorView");

        public enum Theme
        {
            Dark, Light
        }
        
        public static void SetStatusBarTheme(Theme theme)
        {
            if (ApiVersion >= 23)
            {
                RunOnAndroidUiThread(() =>
                {
                    var decorView = GetDecorView();
                    var themeId = (Int32) theme;
                    var systemUiVisibility = decorView.Call<Int32>("getSystemUiVisibility");
                    if(themeId is 1)
                        decorView.Call("setSystemUiVisibility", systemUiVisibility | SystemUIFlagLightStatusBar);
                    else 
                        decorView.Call("setSystemUiVisibility", systemUiVisibility & ~SystemUIFlagLightStatusBar);
                });
            }
        }
        
        public static void SetNavigationBarTheme(Theme theme)
        {
            if (ApiVersion >= 23)
            {
                RunOnAndroidUiThread(() =>
                {
                    var decorView = GetDecorView();
                    var themeId = (Int32) theme;
                    var systemUiVisibility = decorView.Call<Int32>("getSystemUiVisibility");
                    if(themeId is 1)
                        decorView.Call("setSystemUiVisibility", systemUiVisibility | SystemUIFlagLightNavigationBar);
                    else 
                        decorView.Call("setSystemUiVisibility", systemUiVisibility & ~SystemUIFlagLightStatusBar);
                });
            }
        }

        public static void SetStatusBarColor(Int32 color)
        {
            RunOnAndroidUiThread(() =>
            {
                GetWindow().Call("setStatusBarColor", color);
            });
        }
        
        public static void SetNavigationBarColor(Int32 color)
        {
            RunOnAndroidUiThread(() =>
            {
                GetWindow().Call("setNavigationBarColor", color);
            });
        }

        
        public static void MakeToast(String text, Boolean longToast = false)
        {
            _toastClass ??= new AndroidJavaClass("android.widget.Toast");
            RunOnAndroidUiThread(() =>
            {
                _toastClass.CallStatic<AndroidJavaObject>("makeText", MainActivity, text, longToast? 1 : 0).Call("show"); 
            });
        }
    }
}