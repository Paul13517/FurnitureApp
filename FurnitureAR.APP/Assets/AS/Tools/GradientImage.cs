using System;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

namespace Tools
{
    [ExecuteInEditMode]
    public class GradientImage : Image
    {
        public Color TopColor = Color.white;
        
        public Color BottomColor = Color.black;

        private static readonly Int32 TopColorId = Shader.PropertyToID("_TopColor");

        private static readonly Int32 BottomColorId = Shader.PropertyToID("_BottomColor");

        protected override void Awake()
        {
            base.Awake();
            Update();
        }

        private void Update()
        {
            var modifiedMaterial = GetModifiedMaterial(material);
            modifiedMaterial.SetColor(TopColorId, TopColor);
            modifiedMaterial.SetColor(BottomColorId, BottomColor);
        }
    }
    
#if UNITY_EDITOR
    [CustomEditor(typeof(GradientImage))]
    public class GradientImageImageEditor : Editor
    {
        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();
            
            var materialProperty = serializedObject.FindProperty("m_Material");
            var topColorProperty = serializedObject.FindProperty("TopColor");
            var bottomColorProperty = serializedObject.FindProperty("BottomColor");
            
            var materialField = new PropertyField(materialProperty);
            var topColorField = new PropertyField(topColorProperty); 
            var bottomColorField = new PropertyField(bottomColorProperty); 
            
            materialField.Bind(serializedObject);
            topColorField.Bind(serializedObject);
            bottomColorField.Bind(serializedObject);
            
            root.Add(materialField);
            root.Add(topColorField);
            root.Add(bottomColorField);
            
            return root;
        }
    }
#endif
}
