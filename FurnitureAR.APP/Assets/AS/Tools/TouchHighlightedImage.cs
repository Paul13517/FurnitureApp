using System;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

namespace Tools
{
    public class TouchHighlightedImage : Image, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
    {
        public Color BaseColor = Color.white;

        public Color HighlightedColor = Color.black;

        public Single TransitionSpeed = 3.0f;

        public Single TransitionDelaySeconds = 0.1f;

        private Single _transitionDelayTimer; 
        
        private Boolean _isDown;

        public void OnPointerDown(PointerEventData data)
        {
            _transitionDelayTimer = TransitionDelaySeconds;
            _isDown = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _isDown = false;
        }
        
        public void OnPointerExit(PointerEventData eventData)
        {
            _isDown = false;
        }

        protected override void Start()
        {
            base.Start();
            color = BaseColor;
        }
        
        private void Update()
        {
            _transitionDelayTimer -= Time.deltaTime;
            if (_isDown && _transitionDelayTimer <= 0.0f)
            {
                color = Color.Lerp(color, HighlightedColor, TransitionSpeed * Time.deltaTime);
            }
            else
            {
                color = Color.Lerp(color, BaseColor, TransitionSpeed * Time.deltaTime);
            }
        }
        
        #if UNITY_EDITOR
        protected override void OnValidate()
        {
            base.OnValidate();
            color = BaseColor;
        }
        #endif
    }
    
    #if UNITY_EDITOR
    [CustomEditor(typeof(TouchHighlightedImage))]
    public class TouchHighlightedImageEditor : Editor
    {
        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();
            
            var baseColorProperty = serializedObject.FindProperty("BaseColor");
            var highlightedColorProperty = serializedObject.FindProperty("HighlightedColor");
            var transitionSpeedProperty = serializedObject.FindProperty("TransitionSpeed");

            var baseColorField = new PropertyField(baseColorProperty); 
            var highlightedColorField = new PropertyField(highlightedColorProperty); 
            var transitionSpeedField= new PropertyField(transitionSpeedProperty); 
            
            baseColorField.Bind(serializedObject);
            highlightedColorField.Bind(serializedObject);
            transitionSpeedField.Bind(serializedObject);
            
            root.Add(baseColorField);
            root.Add(highlightedColorField);
            root.Add(transitionSpeedField);
            
            return root;
        }
    }
    #endif
}
