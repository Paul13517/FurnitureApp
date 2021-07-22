using System;
using System.Collections.Generic;
using Tools;
using UnityEngine;
using Image = UnityEngine.UI.Image;

namespace AS.Tools
{
    public enum Orientation
    {
        Horizontal,
        Vertical,
    }
    
    [ExecuteInEditMode]
    public sealed class ViewPager : Image//, IPointerDownHandler, IPointerUpHandler, IDragHandler
    {
        // #if UNITY_EDITOR
        // [UnityEditor.CustomEditor(typeof(ViewPager))]
        // public class ViewPagerEditor : UnityEditor.Editor
        // {
        //     public override void OnInspectorGUI() => DrawDefaultInspector();
        // }
        // #endif
        
        public Orientation Orientation;

        public Int32 SwipeVelocity = 100;

        public Single OverScrollModifier = 0.0f;

        public Single FlingDistance = 20.0f;

        public Boolean IsEnabled = true;
        
        public Single Scroll { get; private set; }
        
        public Single Position
        {
            set => _roundScroll = -value;
        }

        public Boolean IsBeginDrag { get; private set; } = false;

        private Orientation? _dragOrientation = null;

        private Single _downScroll = 0.0f;

        private IReadOnlyList<RectTransform> _children;

        private Single _roundScroll = 0.0f;

        private Boolean _swipePositive = false;

        private Vector2 _pressPosition;
        
        private readonly TouchVelocityTracker _velocityTracker = new TouchVelocityTracker();

        public void UpdateChildrenTransform()
        {
            var rectTransforms = new List<RectTransform>();
            
            foreach(Transform child in transform)
            {
                var childRectTransform = child.GetComponent<RectTransform>();
                if(!childRectTransform)
                    continue;
                
                childRectTransform.anchorMin = new Vector2(0.0f, 0.0f);
                childRectTransform.anchorMax = new Vector2(1.0f, 1.0f);
                rectTransforms.Add(childRectTransform);
            }

            _children = rectTransforms;
        }
        
        public void OnPointerDown(Vector2 mousePosition)
        {
            _velocityTracker.Reset();
            _pressPosition = mousePosition;
            _velocityTracker.PushTouch(mousePosition);
            _downScroll = Scroll;
        }

        public void OnPointerUp(Vector2 position)
        {
            _velocityTracker.PushTouch(position);

            IsBeginDrag = false;

            var velocity = _velocityTracker.ComputeVelocity(1.0f);
            
            if (_dragOrientation == Orientation)
            {
                SwipeVelocity = 250;
                if (velocity > SwipeVelocity * PlatformDisplayMetrics.DpDensity)
                    _roundScroll = _swipePositive ? Mathf.RoundToInt(_downScroll + 1.0f) : Mathf.RoundToInt(_downScroll - 1.0f);
                else
                    _roundScroll = Mathf.RoundToInt(Scroll);

                _roundScroll = Mathf.Clamp(_roundScroll, -_children.Count + 1, 0);
            }

            _dragOrientation = null;
        }
        
        public void OnDrag(Vector2 position)
        {
            if(_dragOrientation is null)
                IsBeginDrag = true;
            _velocityTracker.PushTouch(position);
            if (Vector2.Distance(position, _pressPosition) > FlingDistance * PlatformDisplayMetrics.DpDensity && _dragOrientation is null)
            {
                var diff = (position - _pressPosition);
                var direction = diff.normalized;
                _dragOrientation = Mathf.Abs(direction.x) > Mathf.Abs(direction.y) ?
                    Orientation.Horizontal : Orientation.Vertical;
                _downScroll -= GetMousePosition(diff);

                _swipePositive = Orientation switch
                {
                    Orientation.Horizontal => Mathf.Sign(direction.x) > 0,
                    Orientation.Vertical => Mathf.Sign(direction.y) > 0,
                    _ => throw new ArgumentOutOfRangeException()
                };

                if (_dragOrientation != Orientation)
                    IsBeginDrag = false;
            }

            if (_dragOrientation == Orientation)
            {
                Scroll = GetMousePosition(position) - GetMousePosition(_pressPosition) + _downScroll;
                var clampedScroll = Mathf.Clamp(Scroll, -_children.Count + 1, 0);
                Scroll = clampedScroll + (Scroll - clampedScroll) * OverScrollModifier;
            }
        }

        private Single GetMousePosition(Vector2 position)
        {
            if (Camera.main is { } cam)
            {
                var viewPortPosition = cam.ScreenToViewportPoint(position);
                
                if (Orientation is Orientation.Vertical)
                    return viewPortPosition.y;
                
                return viewPortPosition.x;
            }

            return 0.0f;
        }

        protected override void Awake()
        {
            base.Awake();
            UpdateChildrenTransform();
        }
        
        private void Update()
        {
            if (!IsEnabled)
                return;
            
            if (Input.GetMouseButtonDown(0))
                OnPointerDown(Input.mousePosition);

            if (Input.GetMouseButtonUp(0))
                OnPointerUp(Input.mousePosition);
            
            if(Input.GetMouseButton(0))
                OnDrag(Input.mousePosition);
            
            switch (Application.isPlaying)
            {
                case false:
                    UpdateChildrenTransform();
                    break;
            }

            switch (IsBeginDrag)
            {
                case false:
                    Scroll = Mathf.Lerp(Scroll, _roundScroll, Time.deltaTime * 10.0f);
                    break;
            }
            
            switch (_children)
            {
                case null:
                    return;
            }

            for (var i = 0; i < _children.Count; i++)
            {
                var child = _children[i];
                switch (Orientation)
                {
                    case Orientation.Horizontal:
                        child.anchorMin = new Vector2(i + Scroll, 0.0f);
                        child.anchorMax = new Vector2(i + 1.0f + Scroll, 1.0f);
                        break;
                    case Orientation.Vertical:
                        child.anchorMin = new Vector2(0.0f, i + Scroll);
                        child.anchorMax = new Vector2( 1.0f, i + 1.0f + Scroll);
                        break;
                }
            }
        }
    }
}