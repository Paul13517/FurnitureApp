using System;
using UnityEngine;
namespace Generated
{
    public class DirectoryTreeListElementBinding
    {
        public readonly GameObject GameObject;
        private UnityEngine.RectTransform _rectTransform;
        public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
        private UnityEngine.CanvasRenderer _canvasRenderer;
        public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
        private Tools.TouchHighlightedImage _touchHighlightedImage;
        public Tools.TouchHighlightedImage TouchHighlightedImage => _touchHighlightedImage ??= GameObject.GetComponent<Tools.TouchHighlightedImage>();
        private Tools.StyleSystem.Wrappers.TouchHighlightedImageStyleHolder _touchHighlightedImageStyleHolder;
        public Tools.StyleSystem.Wrappers.TouchHighlightedImageStyleHolder TouchHighlightedImageStyleHolder => _touchHighlightedImageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.TouchHighlightedImageStyleHolder>();
        private UnityEngine.UI.Button _button;
        public UnityEngine.UI.Button Button => _button ??= GameObject.GetComponent<UnityEngine.UI.Button>();
        private Tools.RectVisibleListener _rectVisibleListener;
        public Tools.RectVisibleListener RectVisibleListener => _rectVisibleListener ??= GameObject.GetComponent<Tools.RectVisibleListener>();
        public DirectoryTreeListElementBinding(GameObject gameObject) => GameObject = gameObject;
        public class IconBackgroundBinding
        {
            public readonly GameObject GameObject;
            public IconBackgroundBinding(GameObject gameObject) => GameObject = gameObject;
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
        private IconBackgroundBinding _iconBackground;
        public IconBackgroundBinding IconBackground => _iconBackground ??= new IconBackgroundBinding(GameObject.transform.Find("IconBackground").gameObject);
        public class ContentIconBinding
        {
            public readonly GameObject GameObject;
            public ContentIconBinding(GameObject gameObject) => GameObject = gameObject;
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
        private ContentIconBinding _contentIcon;
        public ContentIconBinding ContentIcon => _contentIcon ??= new ContentIconBinding(GameObject.transform.Find("ContentIcon").gameObject);
        public class ArrowIconBinding
        {
            public readonly GameObject GameObject;
            public ArrowIconBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private ArrowIconBinding _arrowIcon;
        public ArrowIconBinding ArrowIcon => _arrowIcon ??= new ArrowIconBinding(GameObject.transform.Find("ArrowIcon").gameObject);
        public class ContentTextBinding
        {
            public readonly GameObject GameObject;
            public ContentTextBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
            private Tools.StyleSystem.Wrappers.TMP_StyleHolder _tMP_StyleHolder;
            public Tools.StyleSystem.Wrappers.TMP_StyleHolder TMP_StyleHolder => _tMP_StyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.TMP_StyleHolder>();
        }
        private ContentTextBinding _contentText;
        public ContentTextBinding ContentText => _contentText ??= new ContentTextBinding(GameObject.transform.Find("ContentText").gameObject);
    }
}
