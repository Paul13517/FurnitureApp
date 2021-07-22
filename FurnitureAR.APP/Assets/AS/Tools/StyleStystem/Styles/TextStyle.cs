using System;
using TMPro;
using UnityEngine;

namespace Tools.StyleSystem.Styles
{
    [CreateAssetMenu(fileName = "Text style", menuName = "Styles/Text style")]
    public class TextStyle : Style<TextStyle>
    {
        public const Single DefaultFontSize = 15.0f;

        public const Single DefaultMinFontSize = 7.5f;

        public const Single DefaultMaxFontSize = 15.0f;

        public static Color DefaultTextColor = Color.black;

        public static TMPro.FontStyles DefaultFontStyle = TMPro.FontStyles.Normal;

        public static bool DefaultAutoSizeEnabled = false;

        private static TMP_FontAsset _defaultFontAsset;

        public static TMP_FontAsset DefaultFontAsset => _defaultFontAsset;

        public Attribute<TMP_FontAsset> FontAsset = new Attribute<TMP_FontAsset>(DefaultFontAsset);
        
        public Attribute<Single> FontSize = new Attribute<Single>(DefaultFontSize);

        public Attribute<Color> TextColor = new Attribute<Color>(DefaultTextColor);

        public Attribute<TMPro.FontStyles> FontStyle = new Attribute<TMPro.FontStyles>(DefaultFontStyle);

        public Attribute<Boolean> IsAutoSizeEnabled = new Attribute<Boolean>(DefaultAutoSizeEnabled); 
        
        [Header("If autosize enabled:")]

        public Attribute<Single> MinFontSize = new Attribute<Single>(DefaultMinFontSize);

        public Attribute<Single> MaxFontSize = new Attribute<Single>(DefaultMaxFontSize);

        private void OnEnable()
        {
         //   _defaultFontAsset ??= Resources.Load<TMP_FontAsset>("TextMesh Pro/Fonts/Roboto-Regular");
         //   Debug.Log(_defaultFontAsset is null);
        }
    }
}
