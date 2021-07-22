using System;
using UnityEngine;

namespace Tools
{
    [ExecuteInEditMode]
    public class PlatformDisplayMetrics : MonoBehaviour
    {

        [SerializeField] private Single _editorDpDensity = 1.0f;
        
        [SerializeField] private Single _editorTextScaleFactor = 1.0f;

        public static Single DpDensity { get; private set; } = 1.0f;

        public static Single TextScaleFactor { get; private set; } = 1.0f;
        
        #if UNITY_ANDROID
        private AndroidJavaClass _unityPlayerActivityClass;
        #endif

        private void OnApplicationFocus(Boolean hasFocus)
        {
            if (hasFocus)
            {
                CalculateDimensions();
            }
        }
        
        private void Awake()
        {
            #if UNITY_ANDROID
            _unityPlayerActivityClass  = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            #endif
            CalculateDimensions();
        }

        private void CalculateDimensions()
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                #if UNITY_ANDROID
                var displayMetrics = _unityPlayerActivityClass
                    .GetStatic<AndroidJavaObject>("currentActivity")
                    .Call<AndroidJavaObject>("getApplicationContext")
                    .Call<AndroidJavaObject>("getResources")
                    .Call<AndroidJavaObject>("getDisplayMetrics");
                DpDensity = displayMetrics.Get<Single>("density");
                TextScaleFactor = displayMetrics.Get<Single>("scaledDensity") / DpDensity;
                #endif
            }
            else
            {
                DpDensity = _editorDpDensity;
                TextScaleFactor = _editorTextScaleFactor;
            }
        }
    }
}
