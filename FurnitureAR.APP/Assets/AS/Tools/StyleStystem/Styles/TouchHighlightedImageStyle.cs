using System;
using UnityEngine;

namespace Tools.StyleSystem.Styles
{
    [CreateAssetMenu(fileName = "Touch highlighted image style", menuName = "Styles/Touch highlighted image style")]
    public class TouchHighlightedImageStyle : Style<TouchHighlightedImageStyle>
    {
        public static Color DefaultBaseColor = Color.white;
        
        public static Color DefaultHighlightedColor = Color.black; 
        
        public const Single DefaultTransitionSpeed = 5.0f; 
        
        public Attribute<Color> BaseColor = new Attribute<Color>(DefaultBaseColor);
        
        public Attribute<Color> HighlightedColor = new Attribute<Color>(DefaultHighlightedColor);
        
        public Attribute<Single> TransitionSpeed = new Attribute<Single>(DefaultTransitionSpeed);
    }
}