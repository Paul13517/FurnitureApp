using System;
using UnityEngine;

namespace Tools
{
    public class RectVisibleListener : MonoBehaviour
    {
        public Boolean Visible { get; private set; }
        
        public event Action OnVisible;

        private RectTransform _rectTransform;

        private static Rect _screenSpaceRect;

        private static Camera _camera;
        
        private void Awake()
        {
            if (_camera is null)
            {
                _camera = Camera.main;
                _screenSpaceRect = new Rect(0.0f, 0.0f, Screen.width, Screen.height);
            }
            _rectTransform = GetComponent<RectTransform>();
        }

        private void Update()
        {
            var visibility = _rectTransform.GetScreenRect(_camera).Overlaps(_screenSpaceRect);
            
            if (visibility && !Visible)
                OnVisible?.Invoke();

            Visible = visibility;
        }
    }
}