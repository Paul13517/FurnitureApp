using System;
using UnityEngine;
namespace Generated
{
    public class DirectoryTreeWindowLayoutBinding
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
        public DirectoryTreeWindowLayoutBinding(GameObject gameObject) => GameObject = gameObject;
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
        public class MainTitleBarBinding
        {
            public readonly GameObject GameObject;
            public MainTitleBarBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
            private UserInterface.TitleBar.MainTitleBarController _mainTitleBarController;
            public UserInterface.TitleBar.MainTitleBarController MainTitleBarController => _mainTitleBarController ??= GameObject.GetComponent<UserInterface.TitleBar.MainTitleBarController>();
        }
        private MainTitleBarBinding _mainTitleBar;
        public MainTitleBarBinding MainTitleBar => _mainTitleBar ??= new MainTitleBarBinding(GameObject.transform.Find("MainTitleBar").gameObject);
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
        public ShadowBinding Shadow => _shadow ??= new ShadowBinding(GameObject.transform.Find("MainTitleBar/Shadow").gameObject);
        public class BigHeaderContainerBinding
        {
            public readonly GameObject GameObject;
            public BigHeaderContainerBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.UI.ContentSizeFitter _contentSizeFitter;
            public UnityEngine.UI.ContentSizeFitter ContentSizeFitter => _contentSizeFitter ??= GameObject.GetComponent<UnityEngine.UI.ContentSizeFitter>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
            private UnityEngine.UI.HorizontalLayoutGroup _horizontalLayoutGroup;
            public UnityEngine.UI.HorizontalLayoutGroup HorizontalLayoutGroup => _horizontalLayoutGroup ??= GameObject.GetComponent<UnityEngine.UI.HorizontalLayoutGroup>();
        }
        private BigHeaderContainerBinding _bigHeaderContainer;
        public BigHeaderContainerBinding BigHeaderContainer => _bigHeaderContainer ??= new BigHeaderContainerBinding(GameObject.transform.Find("MainTitleBar/BigHeaderContainer").gameObject);
        public class BigHeaderBinding
        {
            public readonly GameObject GameObject;
            public BigHeaderBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
            private Tools.StyleSystem.Wrappers.TMP_StyleHolder _tMP_StyleHolder;
            public Tools.StyleSystem.Wrappers.TMP_StyleHolder TMP_StyleHolder => _tMP_StyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.TMP_StyleHolder>();
            private UnityEngine.CanvasGroup _canvasGroup;
            public UnityEngine.CanvasGroup CanvasGroup => _canvasGroup ??= GameObject.GetComponent<UnityEngine.CanvasGroup>();
        }
        private BigHeaderBinding _bigHeader;
        public BigHeaderBinding BigHeader => _bigHeader ??= new BigHeaderBinding(GameObject.transform.Find("MainTitleBar/BigHeaderContainer/BigHeader").gameObject);
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
            private UnityEngine.CanvasGroup _canvasGroup;
            public UnityEngine.CanvasGroup CanvasGroup => _canvasGroup ??= GameObject.GetComponent<UnityEngine.CanvasGroup>();
        }
        private HeaderBinding _header;
        public HeaderBinding Header => _header ??= new HeaderBinding(GameObject.transform.Find("MainTitleBar/Header").gameObject);
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
            private Tools.TouchScaler _touchScaler;
            public Tools.TouchScaler TouchScaler => _touchScaler ??= GameObject.GetComponent<Tools.TouchScaler>();
            private UnityEngine.UI.Button _button;
            public UnityEngine.UI.Button Button => _button ??= GameObject.GetComponent<UnityEngine.UI.Button>();
        }
        private BackIconBinding _backIcon;
        public BackIconBinding BackIcon => _backIcon ??= new BackIconBinding(GameObject.transform.Find("MainTitleBar/BackIcon").gameObject);
        public class RefreshIconBinding
        {
            public readonly GameObject GameObject;
            public RefreshIconBinding(GameObject gameObject) => GameObject = gameObject;
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
        private RefreshIconBinding _refreshIcon;
        public RefreshIconBinding RefreshIcon => _refreshIcon ??= new RefreshIconBinding(GameObject.transform.Find("MainTitleBar/RefreshIcon").gameObject);
        public class InternetIconBinding
        {
            public readonly GameObject GameObject;
            public InternetIconBinding(GameObject gameObject) => GameObject = gameObject;
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
        private InternetIconBinding _internetIcon;
        public InternetIconBinding InternetIcon => _internetIcon ??= new InternetIconBinding(GameObject.transform.Find("MainTitleBar/InternetIcon").gameObject);
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
    }
}
