using UnityEngine;

namespace Tools.StyleSystem.Styles
{
    [CreateAssetMenu(fileName = "Image style", menuName = "Styles/Image style")]
    public class ImageStyle : Style<ImageStyle>
    {
        public static Color DefaultColor = UnityEngine.Color.white;

        public Attribute<Color> Color = new Attribute<Color>(DefaultColor);
    }
}
