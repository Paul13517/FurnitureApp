using Tools.StyleSystem.Styles;
using UnityEngine;

namespace Tools.StyleSystem.Wrappers
{
    [ExecuteInEditMode]
    public class TouchHighlightedImageStyleHolder : MonoBehaviour, IStyleHolder
    {
        [SerializeField] public TouchHighlightedImageStyle[] Styles;

        private TouchHighlightedImage _image;

        private void Awake()
        {
            _image = GetComponent<TouchHighlightedImage>();
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
            var selectedStyle = Styles is null ? null : (Style.ThemeIndex < Styles.Length ? Styles[Style.ThemeIndex] : null);
            _image.BaseColor = StyleUtility.EvaluateAttribute(selectedStyle?.BaseColor, selectedStyle?.ParentStyle?.BaseColor, TouchHighlightedImageStyle.DefaultBaseColor);
            _image.HighlightedColor = StyleUtility.EvaluateAttribute(selectedStyle?.HighlightedColor, selectedStyle?.ParentStyle?.HighlightedColor, TouchHighlightedImageStyle.DefaultHighlightedColor);
            _image.TransitionSpeed = StyleUtility.EvaluateAttribute(selectedStyle?.TransitionSpeed, selectedStyle?.ParentStyle?.TransitionSpeed, TouchHighlightedImageStyle.DefaultTransitionSpeed);
        }
    }
}