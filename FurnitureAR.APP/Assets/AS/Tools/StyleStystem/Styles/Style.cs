using System;
using UnityEngine;

namespace Tools.StyleSystem.Styles
{

    public abstract class Style : ScriptableObject
    {
        public static Int32 ThemeIndex = 0;

        [Serializable]
        public class Attribute<T>
        {
            [SerializeField] private T _value;

            public T Value
            {
                set
                {
                    _value = value;
                    UseParent = false;
                }
                get => _value;
            }

            public Boolean UseParent = false;

            public Attribute(T value) => _value = value;
        }
    }

    public abstract class Style<TParentStyle> : Style where TParentStyle : Style
    {
        public TParentStyle ParentStyle;

        public static TParentStyle Create() => ScriptableObject.CreateInstance<TParentStyle>();
    }

    public static class StyleUtility
    {
        public static T EvaluateAttribute<T>(Style.Attribute<T> styleAttribute, Style.Attribute<T> parentStyleAttribute, T fallback)
            => styleAttribute is null ? fallback : styleAttribute.UseParent ? parentStyleAttribute is null ? fallback : parentStyleAttribute.Value : styleAttribute.Value;
    }
}
