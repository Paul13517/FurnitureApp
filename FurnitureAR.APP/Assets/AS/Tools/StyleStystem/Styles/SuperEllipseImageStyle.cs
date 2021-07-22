using System;
using UnityEngine;

namespace Tools.StyleSystem.Styles
{
    [CreateAssetMenu(fileName = "Super ellipse image style", menuName = "Styles/Super ellipse image style")]
    public class SuperEllipseImageStyle : ImageStyle
    {
        public const Single DefaultRadius = 0.0f;

        public const Single DefaultSmoothness = 0.1f;

        public Attribute<Single> Radius = new Attribute<Single>(DefaultRadius);

        public Attribute<Single> Smoothness = new Attribute<Single>(DefaultSmoothness);
    }
}