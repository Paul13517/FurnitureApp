using System;
using Tools;
using UnityEngine;
using UnityEngine.UI;
using Tools.WindowSystem;

namespace UserInterface
{

    public class LaunchScript : MonoBehaviour
    {
        [SerializeField] private DefaultWindowsHolderMonoBehaviour _defaultWindowsHolderMonoBehaviour;

        [SerializeField] private CanvasScaler _canvasScaler;

        private Boolean _needRecreateUi;

        private Vector2 _lastDimens;

        private Vector2 _lastScreenSize;
        
        public void Awake()
        {
            _defaultWindowsHolderMonoBehaviour.Instance.AttachWindow(new AuthWindow.AuthWindow());
        }

        public void OnDimensionsChange(Single dpDensity, Single textScaleFactor)
        {
            _needRecreateUi = true;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                _needRecreateUi = true;
            }

            var dimens = new Vector2(PlatformDisplayMetrics.DpDensity, PlatformDisplayMetrics.TextScaleFactor);
            
            if (_lastDimens != dimens)
            {
                _needRecreateUi = true;
                _lastDimens = new Vector2(PlatformDisplayMetrics.DpDensity, PlatformDisplayMetrics.TextScaleFactor);
            }

            var screenSize = new Vector2(Screen.width, Screen.height);
            
            if (_lastScreenSize != screenSize)
            {
                _needRecreateUi = true;
                _lastScreenSize = screenSize;
            }
            
            if (_needRecreateUi)
            {
                _canvasScaler.scaleFactor = PlatformDisplayMetrics.DpDensity;
                _needRecreateUi = false;
                _defaultWindowsHolderMonoBehaviour.Instance.RecreateWindowsView();
            }
        }
    }
}
