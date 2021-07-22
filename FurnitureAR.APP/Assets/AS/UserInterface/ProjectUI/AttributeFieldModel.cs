using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace UserInterface.ProjectUI
{
    public abstract class AttributeField
    {
        public String Name;

        public IReactiveProperty<String> Value => _value;
        
        public readonly Int32 LocalId;
        
        private ReactiveProperty<String> _value;

        public void UpdateValue(String newValue) => _value.SetValueAndForceNotify(newValue); 
        
        protected AttributeField(Int32 localId, String name, String value) => (LocalId, Name, _value) = (localId, name, new ReactiveProperty<String>(value));
    }

    public class TreeAttributeField : AttributeField
    {
        public IReactiveProperty<Sprite> Icon => _icon; 
        
        private readonly ReactivePropertyNoInit<Sprite> _icon = new ReactivePropertyNoInit<Sprite>();

        public Int32 ValueId;

        public readonly IReadOnlyList<Int32> Directories;
        
        public TreeAttributeField(Int32 localId, String name, String value, Int32 valueId, IReadOnlyList<Int32> directories) : base(localId, name, value)
        {
            ValueId = valueId;
            Directories = directories;
        }

        public void SetIcon(Sprite sprite) => _icon.SetValueAndForceNotify(sprite);
    }
    
    public enum TextAttributeFieldType
    {
        String,
        Single, 
        Integer
    }
    
    public class TextAttributeField : AttributeField
    {
        public readonly TextAttributeFieldType Type;

        public TextAttributeField(Int32 localId, String name, String value, TextAttributeFieldType type) : base(localId, name, value)
            => Type = type;
    }
    
}