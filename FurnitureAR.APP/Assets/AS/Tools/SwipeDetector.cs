using System;
using Tools;
using UnityEngine;

namespace UserInterface.Tools
{
    public sealed class SwipeDetector
    {
        public enum SwipeDirection
        {
            Left,
            Right,
            Up,
            Down
        }

        public enum DragOrientation
        {
            Undefined,
            Vertical,
            Horizontal
        }
        
        public event Action<SwipeDirection> OnSwipe;
        
        public event Action<Vector2> OnDrag;
        
        public event Action OnStopDrag;
        
        public event Action OnStartDrag;

        public readonly Int32 TouchDistanceThresholdDp;
        
        public readonly Int32 MinimumVelocityToSwipeDp;
        
        private readonly TouchVelocityTracker _velocityTracker = new TouchVelocityTracker();
        
        private Vector3 _downMousePosition;

        private Boolean _isStartDrag;

        private DragOrientation _dragOrientation;

        private Vector3 _dragPosition;
        private Vector3 _downDragPosition;
        private Vector3 _flingOffsetPosition;
        
        public SwipeDetector(Int32 touchDistanceThresholdDp, Int32 minimumVelocityToSwipePx)
        {
            TouchDistanceThresholdDp = touchDistanceThresholdDp;
            MinimumVelocityToSwipeDp = minimumVelocityToSwipePx;
        }

        public void PushTouch(Vector3 mousePosition, TouchPhase touchEvent)
        {
            _velocityTracker.PushTouch(mousePosition);
            switch (touchEvent)
            {
                case TouchPhase.Began:
                {
                    _downDragPosition = _dragPosition;
                    _downMousePosition = mousePosition;
                    _isStartDrag = true;
                    _velocityTracker.Reset();
                    break;
                }
                case TouchPhase.Canceled:
                {
                    _isStartDrag = false;
                    break;
                }
                case TouchPhase.Moved:
                    if (!_isStartDrag)
                        return;

                    if (Vector2.Distance(_downMousePosition, mousePosition) > TouchDistanceThresholdDp * PlatformDisplayMetrics.DpDensity && _dragOrientation == DragOrientation.Undefined)
                    {
                        var diff = (mousePosition - _downMousePosition);
                        var distance = diff.magnitude;
                        var dir = diff / distance;
                        _dragOrientation = Mathf.Abs(dir.x) > Mathf.Abs(dir.y) ? DragOrientation.Horizontal : DragOrientation.Vertical;
                        _flingOffsetPosition = mousePosition - _downMousePosition;
                        OnStartDrag?.Invoke();
                    }

                    if (_dragOrientation is DragOrientation.Horizontal)
                    {
                        _dragPosition.x = -_downMousePosition.x + mousePosition.x - _flingOffsetPosition.x;
                        OnDrag?.Invoke(_dragPosition);
                    }
                    
                    break;
                case TouchPhase.Ended:
                {
                    if (_dragOrientation != DragOrientation.Undefined)
                        OnStopDrag?.Invoke();
                    
                    _dragOrientation = DragOrientation.Undefined;
                    if (!_isStartDrag)
                        return;

                    _isStartDrag = false;

                    var velocity = _velocityTracker.ComputeVelocity(0.5f);

                    if (Mathf.Abs(velocity) < MinimumVelocityToSwipeDp * PlatformDisplayMetrics.DpDensity)
                    {
                        return;
                    }
                    
                    var diff = (mousePosition - _downMousePosition);
                    var distance = diff.magnitude;
                    var dir = diff / distance;
                    if (distance > TouchDistanceThresholdDp * PlatformDisplayMetrics.DpDensity)
                    {
                        if (Mathf.Abs(dir.x) > Mathf.Abs(dir.y))
                            if(_dragOrientation is DragOrientation.Horizontal)
                                OnSwipe?.Invoke(dir.x > 0 ? SwipeDirection.Right : SwipeDirection.Left);
                        else if(_dragOrientation is DragOrientation.Vertical)
                                OnSwipe?.Invoke(dir.y > 0 ? SwipeDirection.Up : SwipeDirection.Down);
                    }

                    break;
                }
            }
        }
    }
}