using Tools.StyleSystem.Styles;
using UnityEngine;
using UnityEngine.UI;

namespace Tools.StyleSystem.Wrappers
{
    [ExecuteInEditMode]
    public class SuperEllipseImageStyleHolder : MonoBehaviour, IStyleHolder
    {
        [SerializeField] public SuperEllipseImageStyle[] ImageStyles;

        private Image _image;

        private SuperEllipse.SuperEllipseImageModifier _superEllipseImageModifier;

        private void Awake()
        {
            _image = GetComponent<Image>();
            _superEllipseImageModifier = GetComponent<SuperEllipse.SuperEllipseImageModifier>();
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

            _superEllipseImageModifier.CornerRadius = StyleUtility.EvaluateAttribute(imageStyle?.Radius, (imageStyle?.ParentStyle as SuperEllipseImageStyle)?.Radius, SuperEllipseImageStyle.DefaultRadius);

            _superEllipseImageModifier.Smoothness = StyleUtility.EvaluateAttribute(imageStyle?.Smoothness, (imageStyle?.ParentStyle as SuperEllipseImageStyle)?.Smoothness, SuperEllipseImageStyle.DefaultSmoothness);
        }
    }
}
