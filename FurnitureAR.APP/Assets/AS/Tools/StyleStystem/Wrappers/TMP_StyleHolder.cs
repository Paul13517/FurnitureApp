using Tools.StyleSystem.Styles;
using UnityEngine;

namespace Tools.StyleSystem.Wrappers
{

    [ExecuteInEditMode]
    public class TMP_StyleHolder : MonoBehaviour, IStyleHolder
    {
        [SerializeField] public TextStyle[] TextStyles;

        private TMPro.TextMeshProUGUI _textMeshPro;
        
        private void Awake()
        {
            _textMeshPro = GetComponent<TMPro.TextMeshProUGUI>();
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

            var textStyle = TextStyles is null? null : (Style.ThemeIndex < TextStyles.Length? TextStyles[Style.ThemeIndex] : null);

            _textMeshPro.color = StyleUtility.EvaluateAttribute(textStyle?.TextColor, textStyle?.ParentStyle?.TextColor, TextStyle.DefaultTextColor);
            _textMeshPro.fontStyle = StyleUtility.EvaluateAttribute(textStyle?.FontStyle, textStyle?.ParentStyle?.FontStyle, TextStyle.DefaultFontStyle);

            _textMeshPro.font = StyleUtility.EvaluateAttribute(textStyle?.FontAsset, textStyle?.ParentStyle?.FontAsset, TextStyle.DefaultFontAsset);
            
            var autoSize = StyleUtility.EvaluateAttribute(textStyle?.IsAutoSizeEnabled, textStyle?.ParentStyle?.IsAutoSizeEnabled, TextStyle.DefaultAutoSizeEnabled);

            _textMeshPro.enableAutoSizing = autoSize;

            if(autoSize)
            {
                _textMeshPro.fontSizeMin = StyleUtility.EvaluateAttribute(textStyle?.MinFontSize, textStyle?.ParentStyle?.MinFontSize, TextStyle.DefaultMinFontSize) * PlatformDisplayMetrics.TextScaleFactor;
                _textMeshPro.fontSizeMax = StyleUtility.EvaluateAttribute(textStyle?.MaxFontSize, textStyle?.ParentStyle?.MaxFontSize, TextStyle.DefaultMaxFontSize) * PlatformDisplayMetrics.TextScaleFactor;
            }
            else
            {
                _textMeshPro.fontSize = StyleUtility.EvaluateAttribute(textStyle?.FontSize, textStyle?.ParentStyle?.FontSize, TextStyle.DefaultFontSize) * PlatformDisplayMetrics.TextScaleFactor;
            }
        }
    }
}
