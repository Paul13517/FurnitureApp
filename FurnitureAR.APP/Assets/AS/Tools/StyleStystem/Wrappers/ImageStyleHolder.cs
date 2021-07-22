using Tools.StyleSystem.Styles;
using UnityEngine;
using UnityEngine.UI;

namespace Tools.StyleSystem.Wrappers
{
    [ExecuteInEditMode]
    public class ImageStyleHolder : MonoBehaviour, IStyleHolder
    {
        [SerializeField] public ImageStyle[] ImageStyles;

        private Image _image;

        private void Awake()
        {
            _image = GetComponent<Image>();
            Apply();
        }

#if UNITY_EDITOR

        private void OnEnable()
        {
            Awake();
        }

        private void Update()
        {
            Awake();
        }

#endif

        public void Apply()
        {
            var imageStyle = ImageStyles is null ? null : (Style.ThemeIndex < ImageStyles.Length ? ImageStyles[Style.ThemeIndex] : null);
            _image.color = StyleUtility.EvaluateAttribute(imageStyle?.Color, imageStyle?.ParentStyle?.Color, ImageStyle.DefaultColor);
        }
    }
}
