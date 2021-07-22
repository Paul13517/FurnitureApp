using System;
using UnityEngine;
namespace Generated
{
    public class TreeFieldReadOnlyLayoutBinding
    {
        public readonly GameObject GameObject;
        private UnityEngine.RectTransform _rectTransform;
        public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
        public TreeFieldReadOnlyLayoutBinding(GameObject gameObject) => GameObject = gameObject;
        public class BaseFieldBinding
        {
            public readonly GameObject GameObject;
            public BaseFieldBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
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
        public class IconBinding
        {
            public readonly GameObject GameObject;
            public IconBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private Tools.SuperEllipse.SuperEllipseImageModifier _superEllipseImageModifier;
            public Tools.SuperEllipse.SuperEllipseImageModifier SuperEllipseImageModifier => _superEllipseImageModifier ??= GameObject.GetComponent<Tools.SuperEllipse.SuperEllipseImageModifier>();
            private Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder _superEllipseImageStyleHolder;
            public Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder SuperEllipseImageStyleHolder => _superEllipseImageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder>();
        }
        private IconBinding _icon;
        public IconBinding Icon => _icon ??= new IconBinding(GameObject.transform.Find("Icon").gameObject);
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
