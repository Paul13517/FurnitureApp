using System;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace Tools.WindowSystem
{
    public abstract class Window
    {
        public abstract class WindowsHolder
        {
            public abstract void AttachWindow(Window window);
            
            public abstract void DetachWindow(Window window);
            
            protected void AttachWindowAccessor(Window window, RectTransform rectTransform) => window.AttachToWindowsHolder(rectTransform, this);

            protected void DetachWindowAccessor(Window window) => window.DetachFromWindowsHolder();
        }

        public event Action OnAttach;

        public event Action OnDetach;

        public event Action<Boolean> OnVisibilityChange;

        public event Action<Boolean> OnClickabilityChange;

        public Boolean IsAttached { get; private set; }

        public Boolean IsVisible
        {
            get => _isVisible;
            set
            {
                _isVisible = value;
                OnVisibilityChange?.Invoke(value);
                if (_windowFrameCanvas != null)
                {
                    _windowFrameCanvas.enabled = value;
                }
            }
        }

        public Boolean IsClickable
        {
            get => _isClickable;
            set
            {
                _isClickable = value;
                OnClickabilityChange?.Invoke(value);
                if (_windowFrameGraphicRaycaster != null)
                {
                    _windowFrameGraphicRaycaster.enabled = value;
                }
            }
        }

        private GameObject _view;

        private RectTransform _windowFrame;

        private Canvas _windowFrameCanvas;

        private GraphicRaycaster _windowFrameGraphicRaycaster;

        private WindowsHolder _windowsHolder;

        private Boolean _isVisible = true;

        private Boolean _isClickable = true;

        protected abstract GameObject CreateView();

        protected virtual void OnDestroyView() {}

        public void RecreateView()
        {
            if (!IsAttached)
            {
                return;
            }
            DestroyView();
            CreateViewInternal();
        }

        private void AttachToWindowsHolder(RectTransform root, WindowsHolder windowsHolder)
        {
            if (IsAttached)
            {
                DetachFromWindowsHolder();
            }

            if (root == null)
            {
                return;
            }

            _windowFrame = CreateWindowFrame(root);

            _windowFrameCanvas = AddCanvasToWindowFrame(_windowFrame);
            _windowFrameGraphicRaycaster = AddGraphicsRaycasterToWindowFrame(_windowFrame);

            CreateViewInternal();

            IsAttached = true;
            _windowsHolder = windowsHolder;
            OnAttach?.Invoke();
        }

        private void DetachFromWindowsHolder()
        {
            if (IsAttached)
            {
                OnDetach?.Invoke();
                DestroyView();
                Object.Destroy(_windowFrame.gameObject);
                IsAttached = false;
            }
        }

        private void CreateViewInternal()
        {
            _view = CreateView();
            if (_view != null)
            {
                _view.transform.SetParent(_windowFrame, false);
            }
        }

        private void DestroyView()
        {
            if (_view != null)
            {
                OnDestroyView();
                Object.Destroy(_view);
            }
        }

        public void GetWindowFrame(Action<RectTransform> windowReadyCallback)
        {
            if (_windowFrame is null)
            {
                void AttachCallback()
                {
                    windowReadyCallback?.Invoke(_windowFrame);
                    OnAttach -= AttachCallback;
                }

                OnAttach += AttachCallback;
            }
            else
            {
                windowReadyCallback?.Invoke(_windowFrame);
            }
        }
        
        public void GetWindowsHolder(Action<WindowsHolder> holderReadyCallback)
        {
            if (_windowsHolder is null)
            {
                void AttachCallback()
                {
                    holderReadyCallback?.Invoke(_windowsHolder);
                    OnAttach -= AttachCallback;
                }

                OnAttach += AttachCallback;
            }
            else
            {
                holderReadyCallback?.Invoke(_windowsHolder);
            }
        }
        
        private RectTransform CreateWindowFrame(RectTransform windowHolderRoot)
        {
            var windowFrameGameObject = new GameObject("WindowFrame");
            var windowFrame = windowFrameGameObject.AddComponent<RectTransform>();
            windowFrame.sizeDelta = Vector2.zero;
            windowFrame.anchorMin = Vector2.zero;
            windowFrame.anchorMax = Vector2.one;
            windowFrame.SetParent(windowHolderRoot, false);
            return windowFrame;
        }

        private Canvas AddCanvasToWindowFrame(RectTransform windowFrame)
        {
            var canvas = windowFrame.gameObject.AddComponent<Canvas>();
            canvas.enabled = _isVisible;
            return canvas;
        }

        private GraphicRaycaster AddGraphicsRaycasterToWindowFrame(RectTransform windowFrame)
        {
            var graphicRaycaster = windowFrame.gameObject.AddComponent<GraphicRaycaster>();
            graphicRaycaster.enabled = _isClickable;
            return graphicRaycaster;
        }
    }
}