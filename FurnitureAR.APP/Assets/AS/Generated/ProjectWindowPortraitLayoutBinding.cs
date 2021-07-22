using System;
using UnityEngine;
namespace Generated
{
    public class ProjectWindowPortraitLayoutBinding
    {
        public readonly GameObject GameObject;
        private UnityEngine.RectTransform _rectTransform;
        public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
        private UnityEngine.CanvasRenderer _canvasRenderer;
        public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
        private AS.Tools.ViewPager _viewPager;
        public AS.Tools.ViewPager ViewPager => _viewPager ??= GameObject.GetComponent<AS.Tools.ViewPager>();
        public ProjectWindowPortraitLayoutBinding(GameObject gameObject) => GameObject = gameObject;
        public class BaseBinding
        {
            public readonly GameObject GameObject;
            public BaseBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
        }
        private BaseBinding _base;
        public BaseBinding Base => _base ??= new BaseBinding(GameObject.transform.Find("Base").gameObject);
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
        public ScrollViewBinding ScrollView => _scrollView ??= new ScrollViewBinding(GameObject.transform.Find("Base/Scroll View").gameObject);
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
        public ViewportBinding Viewport => _viewport ??= new ViewportBinding(GameObject.transform.Find("Base/Scroll View/Viewport").gameObject);
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
        public ContentBinding Content => _content ??= new ContentBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content").gameObject);
        public class GameObjectBinding
        {
            public readonly GameObject GameObject;
            public GameObjectBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.UI.AspectRatioFitter _aspectRatioFitter;
            public UnityEngine.UI.AspectRatioFitter AspectRatioFitter => _aspectRatioFitter ??= GameObject.GetComponent<UnityEngine.UI.AspectRatioFitter>();
        }
        private GameObjectBinding _gameObject_;
        public GameObjectBinding GameObject_ => _gameObject_ ??= new GameObjectBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/GameObject").gameObject);
        public class MainViewBinding
        {
            public readonly GameObject GameObject;
            public MainViewBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private Tools.SuperEllipse.SuperEllipseImageModifier _superEllipseImageModifier;
            public Tools.SuperEllipse.SuperEllipseImageModifier SuperEllipseImageModifier => _superEllipseImageModifier ??= GameObject.GetComponent<Tools.SuperEllipse.SuperEllipseImageModifier>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder _superEllipseImageStyleHolder;
            public Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder SuperEllipseImageStyleHolder => _superEllipseImageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.SuperEllipseImageStyleHolder>();
        }
        private MainViewBinding _mainView;
        public MainViewBinding MainView => _mainView ??= new MainViewBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/GameObject/MainView").gameObject);
        public class Enter2DButtonBinding
        {
            public readonly GameObject GameObject;
            public Enter2DButtonBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.UI.Button _button;
            public UnityEngine.UI.Button Button => _button ??= GameObject.GetComponent<UnityEngine.UI.Button>();
        }
        private Enter2DButtonBinding _enter2DButton;
        public Enter2DButtonBinding Enter2DButton => _enter2DButton ??= new Enter2DButtonBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/GameObject/MainView/Enter2DButton").gameObject);
        public class N2DTextBinding
        {
            public readonly GameObject GameObject;
            public N2DTextBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
        }
        private N2DTextBinding _n2DText;
        public N2DTextBinding N2DText => _n2DText ??= new N2DTextBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/GameObject/MainView/Enter2DButton/2DText").gameObject);
        public class N2DICONBinding
        {
            public readonly GameObject GameObject;
            public N2DICONBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private N2DICONBinding _n2DICON;
        public N2DICONBinding N2DICON => _n2DICON ??= new N2DICONBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/GameObject/MainView/Enter2DButton/2DICON").gameObject);
        public class EnterARButtonBinding
        {
            public readonly GameObject GameObject;
            public EnterARButtonBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.UI.Button _button;
            public UnityEngine.UI.Button Button => _button ??= GameObject.GetComponent<UnityEngine.UI.Button>();
        }
        private EnterARButtonBinding _enterARButton;
        public EnterARButtonBinding EnterARButton => _enterARButton ??= new EnterARButtonBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/GameObject/MainView/EnterARButton").gameObject);
        public class ARTextBinding
        {
            public readonly GameObject GameObject;
            public ARTextBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
        }
        private ARTextBinding _aRText;
        public ARTextBinding ARText => _aRText ??= new ARTextBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/GameObject/MainView/EnterARButton/ARText").gameObject);
        public class ARICONBinding
        {
            public readonly GameObject GameObject;
            public ARICONBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private ARICONBinding _aRICON;
        public ARICONBinding ARICON => _aRICON ??= new ARICONBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/GameObject/MainView/EnterARButton/AR_ICON").gameObject);
        public class Enter3DButtonBinding
        {
            public readonly GameObject GameObject;
            public Enter3DButtonBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.UI.Button _button;
            public UnityEngine.UI.Button Button => _button ??= GameObject.GetComponent<UnityEngine.UI.Button>();
        }
        private Enter3DButtonBinding _enter3DButton;
        public Enter3DButtonBinding Enter3DButton => _enter3DButton ??= new Enter3DButtonBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/GameObject/MainView/Enter3DButton").gameObject);
        public class N3DTextBinding
        {
            public readonly GameObject GameObject;
            public N3DTextBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
        }
        private N3DTextBinding _n3DText;
        public N3DTextBinding N3DText => _n3DText ??= new N3DTextBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/GameObject/MainView/Enter3DButton/3DText").gameObject);
        public class N3DICONBinding
        {
            public readonly GameObject GameObject;
            public N3DICONBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private N3DICONBinding _n3DICON;
        public N3DICONBinding N3DICON => _n3DICON ??= new N3DICONBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/GameObject/MainView/Enter3DButton/3DICON").gameObject);
        public class OutputsFieldsContainerBinding
        {
            public readonly GameObject GameObject;
            public OutputsFieldsContainerBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.UI.VerticalLayoutGroup _verticalLayoutGroup;
            public UnityEngine.UI.VerticalLayoutGroup VerticalLayoutGroup => _verticalLayoutGroup ??= GameObject.GetComponent<UnityEngine.UI.VerticalLayoutGroup>();
            private UnityEngine.UI.ContentSizeFitter _contentSizeFitter;
            public UnityEngine.UI.ContentSizeFitter ContentSizeFitter => _contentSizeFitter ??= GameObject.GetComponent<UnityEngine.UI.ContentSizeFitter>();
        }
        private OutputsFieldsContainerBinding _outputsFieldsContainer;
        public OutputsFieldsContainerBinding OutputsFieldsContainer => _outputsFieldsContainer ??= new OutputsFieldsContainerBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/OutputsFieldsContainer").gameObject);
        public class OwnerTextBinding
        {
            public readonly GameObject GameObject;
            public OwnerTextBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
        }
        private OwnerTextBinding _ownerText;
        public OwnerTextBinding OwnerText => _ownerText ??= new OwnerTextBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/OutputsFieldsContainer/OwnerText").gameObject);
        public class BaseFieldBinding
        {
            public readonly GameObject GameObject;
            public BaseFieldBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private Tools.TouchHighlightedImage _touchHighlightedImage;
            public Tools.TouchHighlightedImage TouchHighlightedImage => _touchHighlightedImage ??= GameObject.GetComponent<Tools.TouchHighlightedImage>();
            private UnityEngine.UI.Button _button;
            public UnityEngine.UI.Button Button => _button ??= GameObject.GetComponent<UnityEngine.UI.Button>();
            private Tools.StyleSystem.Wrappers.TouchHighlightedImageStyleHolder _touchHighlightedImageStyleHolder;
            public Tools.StyleSystem.Wrappers.TouchHighlightedImageStyleHolder TouchHighlightedImageStyleHolder => _touchHighlightedImageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.TouchHighlightedImageStyleHolder>();
        }
        private BaseFieldBinding _baseField;
        public BaseFieldBinding BaseField => _baseField ??= new BaseFieldBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/OutputsFieldsContainer/OwnerText/BaseField").gameObject);
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
        public LineSpacingTopBinding LineSpacingTop => _lineSpacingTop ??= new LineSpacingTopBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/OutputsFieldsContainer/OwnerText/BaseField/LineSpacingTop").gameObject);
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
        public LineSpacingBottomBinding LineSpacingBottom => _lineSpacingBottom ??= new LineSpacingBottomBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/OutputsFieldsContainer/OwnerText/BaseField/LineSpacingBottom").gameObject);
        public class OwnerNameBinding
        {
            public readonly GameObject GameObject;
            public OwnerNameBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
            private Tools.StyleSystem.Wrappers.TMP_StyleHolder _tMP_StyleHolder;
            public Tools.StyleSystem.Wrappers.TMP_StyleHolder TMP_StyleHolder => _tMP_StyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.TMP_StyleHolder>();
        }
        private OwnerNameBinding _ownerName;
        public OwnerNameBinding OwnerName => _ownerName ??= new OwnerNameBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/OutputsFieldsContainer/OwnerText/BaseField/OwnerName").gameObject);
        public class OwnerLinkBinding
        {
            public readonly GameObject GameObject;
            public OwnerLinkBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
            private Tools.StyleSystem.Wrappers.TMP_StyleHolder _tMP_StyleHolder;
            public Tools.StyleSystem.Wrappers.TMP_StyleHolder TMP_StyleHolder => _tMP_StyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.TMP_StyleHolder>();
        }
        private OwnerLinkBinding _ownerLink;
        public OwnerLinkBinding OwnerLink => _ownerLink ??= new OwnerLinkBinding(GameObject.transform.Find("Base/Scroll View/Viewport/Content/OutputsFieldsContainer/OwnerText/OwnerLink").gameObject);
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
        public MainTitleBarBinding MainTitleBar => _mainTitleBar ??= new MainTitleBarBinding(GameObject.transform.Find("Base/MainTitleBar").gameObject);
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
        public ShadowBinding Shadow => _shadow ??= new ShadowBinding(GameObject.transform.Find("Base/MainTitleBar/Shadow").gameObject);
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
        public BigHeaderContainerBinding BigHeaderContainer => _bigHeaderContainer ??= new BigHeaderContainerBinding(GameObject.transform.Find("Base/MainTitleBar/BigHeaderContainer").gameObject);
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
        public BigHeaderBinding BigHeader => _bigHeader ??= new BigHeaderBinding(GameObject.transform.Find("Base/MainTitleBar/BigHeaderContainer/BigHeader").gameObject);
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
        public HeaderBinding Header => _header ??= new HeaderBinding(GameObject.transform.Find("Base/MainTitleBar/Header").gameObject);
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
        public BackIconBinding BackIcon => _backIcon ??= new BackIconBinding(GameObject.transform.Find("Base/MainTitleBar/BackIcon").gameObject);
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
        public RefreshIconBinding RefreshIcon => _refreshIcon ??= new RefreshIconBinding(GameObject.transform.Find("Base/MainTitleBar/RefreshIcon").gameObject);
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
        public InternetIconBinding InternetIcon => _internetIcon ??= new InternetIconBinding(GameObject.transform.Find("Base/MainTitleBar/InternetIcon").gameObject);
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
        public LoadErrorBarBinding LoadErrorBar => _loadErrorBar ??= new LoadErrorBarBinding(GameObject.transform.Find("Base/LoadErrorBar").gameObject);
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
        public ErrorTextBinding ErrorText => _errorText ??= new ErrorTextBinding(GameObject.transform.Find("Base/LoadErrorBar/ErrorText").gameObject);
        public class ProjectToolSpecificationWindowBinding
        {
            public readonly GameObject GameObject;
            public ProjectToolSpecificationWindowBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private ProjectToolSpecificationWindowBinding _projectToolSpecificationWindow;
        public ProjectToolSpecificationWindowBinding ProjectToolSpecificationWindow => _projectToolSpecificationWindow ??= new ProjectToolSpecificationWindowBinding(GameObject.transform.Find("ProjectToolSpecificationWindow").gameObject);
        public class ScrollView1Binding
        {
            public readonly GameObject GameObject;
            public ScrollView1Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.ScrollRect _scrollRect;
            public UnityEngine.UI.ScrollRect ScrollRect => _scrollRect ??= GameObject.GetComponent<UnityEngine.UI.ScrollRect>();
        }
        private ScrollView1Binding _scrollView1;
        public ScrollView1Binding ScrollView1 => _scrollView1 ??= new ScrollView1Binding(GameObject.transform.Find("ProjectToolSpecificationWindow/Scroll View 1").gameObject);
        public class Viewport1Binding
        {
            public readonly GameObject GameObject;
            public Viewport1Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
        }
        private Viewport1Binding _viewport1;
        public Viewport1Binding Viewport1 => _viewport1 ??= new Viewport1Binding(GameObject.transform.Find("ProjectToolSpecificationWindow/Scroll View 1/Viewport 1").gameObject);
        public class Content1Binding
        {
            public readonly GameObject GameObject;
            public Content1Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.UI.VerticalLayoutGroup _verticalLayoutGroup;
            public UnityEngine.UI.VerticalLayoutGroup VerticalLayoutGroup => _verticalLayoutGroup ??= GameObject.GetComponent<UnityEngine.UI.VerticalLayoutGroup>();
            private UnityEngine.UI.ContentSizeFitter _contentSizeFitter;
            public UnityEngine.UI.ContentSizeFitter ContentSizeFitter => _contentSizeFitter ??= GameObject.GetComponent<UnityEngine.UI.ContentSizeFitter>();
        }
        private Content1Binding _content1;
        public Content1Binding Content1 => _content1 ??= new Content1Binding(GameObject.transform.Find("ProjectToolSpecificationWindow/Scroll View 1/Viewport 1/Content 1").gameObject);
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
        public RecomputeButtonBinding RecomputeButton => _recomputeButton ??= new RecomputeButtonBinding(GameObject.transform.Find("ProjectToolSpecificationWindow/RecomputeButton").gameObject);
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
        public RecomputeTextBinding RecomputeText => _recomputeText ??= new RecomputeTextBinding(GameObject.transform.Find("ProjectToolSpecificationWindow/RecomputeButton/RecomputeText").gameObject);
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
        public RecomputeButtonShadowBinding RecomputeButtonShadow => _recomputeButtonShadow ??= new RecomputeButtonShadowBinding(GameObject.transform.Find("ProjectToolSpecificationWindow/RecomputeButton/RecomputeButtonShadow").gameObject);
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
        public BaseTitleBarBinding BaseTitleBar => _baseTitleBar ??= new BaseTitleBarBinding(GameObject.transform.Find("ProjectToolSpecificationWindow/BaseTitleBar").gameObject);
        public class Shadow2Binding
        {
            public readonly GameObject GameObject;
            public Shadow2Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private Tools.GradientImage _gradientImage;
            public Tools.GradientImage GradientImage => _gradientImage ??= GameObject.GetComponent<Tools.GradientImage>();
        }
        private Shadow2Binding _shadow2;
        public Shadow2Binding Shadow2 => _shadow2 ??= new Shadow2Binding(GameObject.transform.Find("ProjectToolSpecificationWindow/BaseTitleBar/Shadow2").gameObject);
        public class Header2Binding
        {
            public readonly GameObject GameObject;
            public Header2Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
            private Tools.StyleSystem.Wrappers.TMP_StyleHolder _tMP_StyleHolder;
            public Tools.StyleSystem.Wrappers.TMP_StyleHolder TMP_StyleHolder => _tMP_StyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.TMP_StyleHolder>();
        }
        private Header2Binding _header2;
        public Header2Binding Header2 => _header2 ??= new Header2Binding(GameObject.transform.Find("ProjectToolSpecificationWindow/BaseTitleBar/Header2").gameObject);
        public class BackIcon2Binding
        {
            public readonly GameObject GameObject;
            public BackIcon2Binding(GameObject gameObject) => GameObject = gameObject;
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
        private BackIcon2Binding _backIcon2;
        public BackIcon2Binding BackIcon2 => _backIcon2 ??= new BackIcon2Binding(GameObject.transform.Find("ProjectToolSpecificationWindow/BaseTitleBar/BackIcon2").gameObject);
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
        public ToolSpecsBarBinding ToolSpecsBar => _toolSpecsBar ??= new ToolSpecsBarBinding(GameObject.transform.Find("ProjectToolSpecificationWindow/ToolSpecsBar").gameObject);
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
        public TextTMPBinding TextTMP => _textTMP ??= new TextTMPBinding(GameObject.transform.Find("ProjectToolSpecificationWindow/ToolSpecsBar/Text (TMP)").gameObject);
    }
}
