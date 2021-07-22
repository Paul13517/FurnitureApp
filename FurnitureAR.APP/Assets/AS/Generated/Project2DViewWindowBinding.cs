using System;
using UnityEngine;
namespace Generated
{
    public class Project2DViewWindowBinding
    {
        public readonly GameObject GameObject;
        private UnityEngine.RectTransform _rectTransform;
        public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
        private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
        public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        private UnityEngine.CanvasRenderer _canvasRenderer;
        public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
        private UnityEngine.UI.Image _image;
        public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
        public Project2DViewWindowBinding(GameObject gameObject) => GameObject = gameObject;
        public class ScrollViewBinding
        {
            public readonly GameObject GameObject;
            public ScrollViewBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.ScrollRect _scrollRect;
            public UnityEngine.UI.ScrollRect ScrollRect => _scrollRect ??= GameObject.GetComponent<UnityEngine.UI.ScrollRect>();
        }
        private ScrollViewBinding _scrollView;
        public ScrollViewBinding ScrollView => _scrollView ??= new ScrollViewBinding(GameObject.transform.Find("Scroll View").gameObject);
        public class ViewportBinding
        {
            public readonly GameObject GameObject;
            public ViewportBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
        }
        private ViewportBinding _viewport;
        public ViewportBinding Viewport => _viewport ??= new ViewportBinding(GameObject.transform.Find("Scroll View/Viewport").gameObject);
        public class ContentBinding
        {
            public readonly GameObject GameObject;
            public ContentBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.UI.ContentSizeFitter _contentSizeFitter;
            public UnityEngine.UI.ContentSizeFitter ContentSizeFitter => _contentSizeFitter ??= GameObject.GetComponent<UnityEngine.UI.ContentSizeFitter>();
            private UnityEngine.UI.VerticalLayoutGroup _verticalLayoutGroup;
            public UnityEngine.UI.VerticalLayoutGroup VerticalLayoutGroup => _verticalLayoutGroup ??= GameObject.GetComponent<UnityEngine.UI.VerticalLayoutGroup>();
        }
        private ContentBinding _content;
        public ContentBinding Content => _content ??= new ContentBinding(GameObject.transform.Find("Scroll View/Viewport/Content").gameObject);
        public class MainViewBinding
        {
            public readonly GameObject GameObject;
            public MainViewBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.UI.AspectRatioFitter _aspectRatioFitter;
            public UnityEngine.UI.AspectRatioFitter AspectRatioFitter => _aspectRatioFitter ??= GameObject.GetComponent<UnityEngine.UI.AspectRatioFitter>();
            private Tools.SuperEllipse.SuperEllipseImageModifier _superEllipseImageModifier;
            public Tools.SuperEllipse.SuperEllipseImageModifier SuperEllipseImageModifier => _superEllipseImageModifier ??= GameObject.GetComponent<Tools.SuperEllipse.SuperEllipseImageModifier>();
            private Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder _superEllipseImageStyleHolder;
            public Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder SuperEllipseImageStyleHolder => _superEllipseImageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder>();
        }
        private MainViewBinding _mainView;
        public MainViewBinding MainView => _mainView ??= new MainViewBinding(GameObject.transform.Find("Scroll View/Viewport/Content/MainView").gameObject);
        public class FrontViewBinding
        {
            public readonly GameObject GameObject;
            public FrontViewBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.UI.AspectRatioFitter _aspectRatioFitter;
            public UnityEngine.UI.AspectRatioFitter AspectRatioFitter => _aspectRatioFitter ??= GameObject.GetComponent<UnityEngine.UI.AspectRatioFitter>();
            private Tools.SuperEllipse.SuperEllipseImageModifier _superEllipseImageModifier;
            public Tools.SuperEllipse.SuperEllipseImageModifier SuperEllipseImageModifier => _superEllipseImageModifier ??= GameObject.GetComponent<Tools.SuperEllipse.SuperEllipseImageModifier>();
            private Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder _superEllipseImageStyleHolder;
            public Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder SuperEllipseImageStyleHolder => _superEllipseImageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder>();
        }
        private FrontViewBinding _frontView;
        public FrontViewBinding FrontView => _frontView ??= new FrontViewBinding(GameObject.transform.Find("Scroll View/Viewport/Content/FrontView").gameObject);
        public class TopViewBinding
        {
            public readonly GameObject GameObject;
            public TopViewBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.UI.AspectRatioFitter _aspectRatioFitter;
            public UnityEngine.UI.AspectRatioFitter AspectRatioFitter => _aspectRatioFitter ??= GameObject.GetComponent<UnityEngine.UI.AspectRatioFitter>();
            private Tools.SuperEllipse.SuperEllipseImageModifier _superEllipseImageModifier;
            public Tools.SuperEllipse.SuperEllipseImageModifier SuperEllipseImageModifier => _superEllipseImageModifier ??= GameObject.GetComponent<Tools.SuperEllipse.SuperEllipseImageModifier>();
            private Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder _superEllipseImageStyleHolder;
            public Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder SuperEllipseImageStyleHolder => _superEllipseImageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder>();
        }
        private TopViewBinding _topView;
        public TopViewBinding TopView => _topView ??= new TopViewBinding(GameObject.transform.Find("Scroll View/Viewport/Content/TopView").gameObject);
        public class LeftViewBinding
        {
            public readonly GameObject GameObject;
            public LeftViewBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.UI.AspectRatioFitter _aspectRatioFitter;
            public UnityEngine.UI.AspectRatioFitter AspectRatioFitter => _aspectRatioFitter ??= GameObject.GetComponent<UnityEngine.UI.AspectRatioFitter>();
            private Tools.SuperEllipse.SuperEllipseImageModifier _superEllipseImageModifier;
            public Tools.SuperEllipse.SuperEllipseImageModifier SuperEllipseImageModifier => _superEllipseImageModifier ??= GameObject.GetComponent<Tools.SuperEllipse.SuperEllipseImageModifier>();
            private Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder _superEllipseImageStyleHolder;
            public Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder SuperEllipseImageStyleHolder => _superEllipseImageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder>();
        }
        private LeftViewBinding _leftView;
        public LeftViewBinding LeftView => _leftView ??= new LeftViewBinding(GameObject.transform.Find("Scroll View/Viewport/Content/LeftView").gameObject);
        public class RightViewBinding
        {
            public readonly GameObject GameObject;
            public RightViewBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.UI.AspectRatioFitter _aspectRatioFitter;
            public UnityEngine.UI.AspectRatioFitter AspectRatioFitter => _aspectRatioFitter ??= GameObject.GetComponent<UnityEngine.UI.AspectRatioFitter>();
            private Tools.SuperEllipse.SuperEllipseImageModifier _superEllipseImageModifier;
            public Tools.SuperEllipse.SuperEllipseImageModifier SuperEllipseImageModifier => _superEllipseImageModifier ??= GameObject.GetComponent<Tools.SuperEllipse.SuperEllipseImageModifier>();
            private Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder _superEllipseImageStyleHolder;
            public Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder SuperEllipseImageStyleHolder => _superEllipseImageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder>();
        }
        private RightViewBinding _rightView;
        public RightViewBinding RightView => _rightView ??= new RightViewBinding(GameObject.transform.Find("Scroll View/Viewport/Content/RightView").gameObject);
        public class BaseTitleBarBinding
        {
            public readonly GameObject GameObject;
            public BaseTitleBarBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private BaseTitleBarBinding _baseTitleBar;
        public BaseTitleBarBinding BaseTitleBar => _baseTitleBar ??= new BaseTitleBarBinding(GameObject.transform.Find("BaseTitleBar").gameObject);
        public class ShadowBinding
        {
            public readonly GameObject GameObject;
            public ShadowBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private Tools.GradientImage _gradientImage;
            public Tools.GradientImage GradientImage => _gradientImage ??= GameObject.GetComponent<Tools.GradientImage>();
        }
        private ShadowBinding _shadow;
        public ShadowBinding Shadow => _shadow ??= new ShadowBinding(GameObject.transform.Find("BaseTitleBar/Shadow").gameObject);
        public class HeaderBinding
        {
            public readonly GameObject GameObject;
            public HeaderBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
            private Tools.StyleSystem.Wrappers.TMP_StyleHolder _tMP_StyleHolder;
            public Tools.StyleSystem.Wrappers.TMP_StyleHolder TMP_StyleHolder => _tMP_StyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.TMP_StyleHolder>();
        }
        private HeaderBinding _header;
        public HeaderBinding Header => _header ??= new HeaderBinding(GameObject.transform.Find("BaseTitleBar/Header").gameObject);
        public class BackIconBinding
        {
            public readonly GameObject GameObject;
            public BackIconBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
            private UnityEngine.UI.Button _button;
            public UnityEngine.UI.Button Button => _button ??= GameObject.GetComponent<UnityEngine.UI.Button>();
            private Tools.TouchScaler _touchScaler;
            public Tools.TouchScaler TouchScaler => _touchScaler ??= GameObject.GetComponent<Tools.TouchScaler>();
        }
        private BackIconBinding _backIcon;
        public BackIconBinding BackIcon => _backIcon ??= new BackIconBinding(GameObject.transform.Find("BaseTitleBar/BackIcon").gameObject);
    }
}
