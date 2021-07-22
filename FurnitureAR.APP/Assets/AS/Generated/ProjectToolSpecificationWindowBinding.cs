using System;
using UnityEngine;
namespace Generated
{
    public class ProjectToolSpecificationWindowBinding
    {
        public readonly GameObject GameObject;
        private UnityEngine.RectTransform _rectTransform;
        public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
        private UnityEngine.CanvasRenderer _canvasRenderer;
        public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
        private UnityEngine.UI.Image _image;
        public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
        private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
        public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        public ProjectToolSpecificationWindowBinding(GameObject gameObject) => GameObject = gameObject;
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
            private UnityEngine.UI.VerticalLayoutGroup _verticalLayoutGroup;
            public UnityEngine.UI.VerticalLayoutGroup VerticalLayoutGroup => _verticalLayoutGroup ??= GameObject.GetComponent<UnityEngine.UI.VerticalLayoutGroup>();
            private UnityEngine.UI.ContentSizeFitter _contentSizeFitter;
            public UnityEngine.UI.ContentSizeFitter ContentSizeFitter => _contentSizeFitter ??= GameObject.GetComponent<UnityEngine.UI.ContentSizeFitter>();
        }
        private ContentBinding _content;
        public ContentBinding Content => _content ??= new ContentBinding(GameObject.transform.Find("Scroll View/Viewport/Content").gameObject);
        public class RecomputeButtonBinding
        {
            public readonly GameObject GameObject;
            public RecomputeButtonBinding(GameObject gameObject) => GameObject = gameObject;
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
        }
        private RecomputeButtonBinding _recomputeButton;
        public RecomputeButtonBinding RecomputeButton => _recomputeButton ??= new RecomputeButtonBinding(GameObject.transform.Find("RecomputeButton").gameObject);
        public class RecomputeTextBinding
        {
            public readonly GameObject GameObject;
            public RecomputeTextBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
            private Tools.StyleSystem.Wrappers.TMP_StyleHolder _tMP_StyleHolder;
            public Tools.StyleSystem.Wrappers.TMP_StyleHolder TMP_StyleHolder => _tMP_StyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.TMP_StyleHolder>();
        }
        private RecomputeTextBinding _recomputeText;
        public RecomputeTextBinding RecomputeText => _recomputeText ??= new RecomputeTextBinding(GameObject.transform.Find("RecomputeButton/RecomputeText").gameObject);
        public class RecomputeButtonShadowBinding
        {
            public readonly GameObject GameObject;
            public RecomputeButtonShadowBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private Tools.GradientImage _gradientImage;
            public Tools.GradientImage GradientImage => _gradientImage ??= GameObject.GetComponent<Tools.GradientImage>();
        }
        private RecomputeButtonShadowBinding _recomputeButtonShadow;
        public RecomputeButtonShadowBinding RecomputeButtonShadow => _recomputeButtonShadow ??= new RecomputeButtonShadowBinding(GameObject.transform.Find("RecomputeButton/RecomputeButtonShadow").gameObject);
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
        public class LoadErrorBarBinding
        {
            public readonly GameObject GameObject;
            public LoadErrorBarBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
            private UserInterface.LoadStatusBarController _loadStatusBarController;
            public UserInterface.LoadStatusBarController LoadStatusBarController => _loadStatusBarController ??= GameObject.GetComponent<UserInterface.LoadStatusBarController>();
        }
        private LoadErrorBarBinding _loadErrorBar;
        public LoadErrorBarBinding LoadErrorBar => _loadErrorBar ??= new LoadErrorBarBinding(GameObject.transform.Find("LoadErrorBar").gameObject);
        public class ErrorTextBinding
        {
            public readonly GameObject GameObject;
            public ErrorTextBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
            private Tools.StyleSystem.Wrappers.TMP_StyleHolder _tMP_StyleHolder;
            public Tools.StyleSystem.Wrappers.TMP_StyleHolder TMP_StyleHolder => _tMP_StyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.TMP_StyleHolder>();
        }
        private ErrorTextBinding _errorText;
        public ErrorTextBinding ErrorText => _errorText ??= new ErrorTextBinding(GameObject.transform.Find("LoadErrorBar/ErrorText").gameObject);
        public class ToolSpecsBarBinding
        {
            public readonly GameObject GameObject;
            public ToolSpecsBarBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private ToolSpecsBarBinding _toolSpecsBar;
        public ToolSpecsBarBinding ToolSpecsBar => _toolSpecsBar ??= new ToolSpecsBarBinding(GameObject.transform.Find("ToolSpecsBar").gameObject);
        public class TextTMPBinding
        {
            public readonly GameObject GameObject;
            public TextTMPBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
            private Tools.StyleSystem.Wrappers.TMP_StyleHolder _tMP_StyleHolder;
            public Tools.StyleSystem.Wrappers.TMP_StyleHolder TMP_StyleHolder => _tMP_StyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.TMP_StyleHolder>();
        }
        private TextTMPBinding _textTMP;
        public TextTMPBinding TextTMP => _textTMP ??= new TextTMPBinding(GameObject.transform.Find("ToolSpecsBar/Text (TMP)").gameObject);
    }
}
