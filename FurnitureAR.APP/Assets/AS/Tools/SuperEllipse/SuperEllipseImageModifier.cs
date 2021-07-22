using System;
using UnityEngine;
using UnityEngine.UI;

namespace Tools.SuperEllipse
{
    [ExecuteInEditMode]
    public class SuperEllipseImageModifier : MonoBehaviour
    {
        [SerializeField] public Single CornerRadius = 10.0f;
        
        [Range(0.0f, 1.0f)]
        public Single Smoothness = 0.1f;

        private Image _image;
        
        private static readonly Int32 RadiusId = Shader.PropertyToID("_Radius");
        
        private static readonly Int32 RectAspectId = Shader.PropertyToID("_RectAspect");
        
        private static readonly Int32 SmoothnessId = Shader.PropertyToID("_Smoothness");
        
        private void Init()
        {
            _image = GetComponent<Image>();
        }
    
        protected void Awake()
        {
            Init();
            Update();
        }

        #if UNITY_EDITOR
        private void OnValidate()
        {
            Init();
        }
        #endif

        private void Update()
        {
            var size = _image.rectTransform.rect;
            var modifiedMaterial = _image.GetModifiedMaterial(_image.material);
            modifiedMaterial.SetFloat(RadiusId, CornerRadius / size.width);
            modifiedMaterial.SetFloat(RectAspectId, size.width / size.height);
            modifiedMaterial.SetFloat(SmoothnessId, Smoothness);
        }
    }
}
