using System;
using UnityEngine;
namespace Generated
{
    public class TextFieldInputLayoutBinding
    {
        public readonly GameObject GameObject;
        private UnityEngine.RectTransform _rectTransform;
        public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
        private UnityEngine.CanvasRenderer _canvasRenderer;
        public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
        public TextFieldInputLayoutBinding(GameObject gameObject) => GameObject = gameObject;
        public class ButtonBinding
        {
            public readonly GameObject GameObject;
            public ButtonBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.UI.Button _button;
            public UnityEngine.UI.Button Button => _button ??= GameObject.GetComponent<UnityEngine.UI.Button>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private Tools.TouchHighlightedImage _touchHighlightedImage;
            public Tools.TouchHighlightedImage TouchHighlightedImage => _touchHighlightedImage ??= GameObject.GetComponent<Tools.TouchHighlightedImage>();
            private Tools.StyleSystem.Wrappers.TouchHighlightedImageStyleHolder _touchHighlightedImageStyleHolder;
            public Tools.StyleSystem.Wrappers.TouchHighlightedImageStyleHolder TouchHighlightedImageStyleHolder => _touchHighlightedImageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.TouchHighlightedImageStyleHolder>();
        }
        private ButtonBinding _button;
        public ButtonBinding Button => _button ??= new ButtonBinding(GameObject.transform.Find("Button").gameObject);
        public class InputFieldBinding
        {
            public readonly GameObject GameObject;
            public InputFieldBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TMP_InputField _tMP_InputField;
            public TMPro.TMP_InputField TMP_InputField => _tMP_InputField ??= GameObject.GetComponent<TMPro.TMP_InputField>();
        }
        private InputFieldBinding _inputField;
        public InputFieldBinding InputField => _inputField ??= new InputFieldBinding(GameObject.transform.Find("InputField").gameObject);
        public class BaseFieldBinding
        {
            public readonly GameObject GameObject;
            public BaseFieldBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
        }
        private BaseFieldBinding _baseField;
        public BaseFieldBinding BaseField => _baseField ??= new BaseFieldBinding(GameObject.transform.Find("BaseField").gameObject);
        public class LineSpacingTopBinding
        {
            public readonly GameObject GameObject;
            public LineSpacingTopBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private LineSpacingTopBinding _lineSpacingTop;
        public LineSpacingTopBinding LineSpacingTop => _lineSpacingTop ??= new LineSpacingTopBinding(GameObject.transform.Find("BaseField/LineSpacingTop").gameObject);
        public class LineSpacingBottomBinding
        {
            public readonly GameObject GameObject;
            public LineSpacingBottomBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private LineSpacingBottomBinding _lineSpacingBottom;
        public LineSpacingBottomBinding LineSpacingBottom => _lineSpacingBottom ??= new LineSpacingBottomBinding(GameObject.transform.Find("BaseField/LineSpacingBottom").gameObject);
        public class TitleTextBinding
        {
            public readonly GameObject GameObject;
            public TitleTextBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
            private Tools.StyleSystem.Wrappers.TMP_StyleHolder _tMP_StyleHolder;
            public Tools.StyleSystem.Wrappers.TMP_StyleHolder TMP_StyleHolder => _tMP_StyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.TMP_StyleHolder>();
        }
        private TitleTextBinding _titleText;
        public TitleTextBinding TitleText => _titleText ??= new TitleTextBinding(GameObject.transform.Find("BaseField/TitleText").gameObject);
        public class ValueTextBinding
        {
            public readonly GameObject GameObject;
            public ValueTextBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
            private Tools.StyleSystem.Wrappers.TMP_StyleHolder _tMP_StyleHolder;
            public Tools.StyleSystem.Wrappers.TMP_StyleHolder TMP_StyleHolder => _tMP_StyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.TMP_StyleHolder>();
        }
        private ValueTextBinding _valueText;
        public ValueTextBinding ValueText => _valueText ??= new ValueTextBinding(GameObject.transform.Find("ValueText").gameObject);
    }
}
