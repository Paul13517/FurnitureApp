using System;
using UnityEngine;
namespace Generated
{
    public class AuthWindowBinding
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
        private AuthorizeController _authorizeController;
        public AuthorizeController AuthorizeController => _authorizeController ??= GameObject.GetComponent<AuthorizeController>();
        public AuthWindowBinding(GameObject gameObject) => GameObject = gameObject;
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
        public class Image0Binding
        {
            public readonly GameObject GameObject;
            public Image0Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Button _button;
            public UnityEngine.UI.Button Button => _button ??= GameObject.GetComponent<UnityEngine.UI.Button>();
            private Tools.TouchHighlightedImage _touchHighlightedImage;
            public Tools.TouchHighlightedImage TouchHighlightedImage => _touchHighlightedImage ??= GameObject.GetComponent<Tools.TouchHighlightedImage>();
        }
        private Image0Binding _image0;
        public Image0Binding Image0 => _image0 ??= new Image0Binding(GameObject.transform.Find("Image0").gameObject);
        public class TextTMP10Binding
        {
            public readonly GameObject GameObject;
            public TextTMP10Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
        }
        private TextTMP10Binding _textTMP10;
        public TextTMP10Binding TextTMP10 => _textTMP10 ??= new TextTMP10Binding(GameObject.transform.Find("Image0/Text (TMP)10").gameObject);
        public class ErrorBarBinding
        {
            public readonly GameObject GameObject;
            public ErrorBarBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
        }
        private ErrorBarBinding _errorBar;
        public ErrorBarBinding ErrorBar => _errorBar ??= new ErrorBarBinding(GameObject.transform.Find("ErrorBar").gameObject);
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
        }
        private TextTMPBinding _textTMP;
        public TextTMPBinding TextTMP => _textTMP ??= new TextTMPBinding(GameObject.transform.Find("ErrorBar/Text (TMP)").gameObject);
        public class GameObjectBinding
        {
            public readonly GameObject GameObject;
            public GameObjectBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
        }
        private GameObjectBinding _gameObject_;
        public GameObjectBinding GameObject_ => _gameObject_ ??= new GameObjectBinding(GameObject.transform.Find("GameObject").gameObject);
        public class TextTMP0Binding
        {
            public readonly GameObject GameObject;
            public TextTMP0Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
        }
        private TextTMP0Binding _textTMP0;
        public TextTMP0Binding TextTMP0 => _textTMP0 ??= new TextTMP0Binding(GameObject.transform.Find("GameObject/Text (TMP)0").gameObject);
        public class InputFieldTMPBinding
        {
            public readonly GameObject GameObject;
            public InputFieldTMPBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private TMPro.TMP_InputField _tMP_InputField;
            public TMPro.TMP_InputField TMP_InputField => _tMP_InputField ??= GameObject.GetComponent<TMPro.TMP_InputField>();
        }
        private InputFieldTMPBinding _inputFieldTMP;
        public InputFieldTMPBinding InputFieldTMP => _inputFieldTMP ??= new InputFieldTMPBinding(GameObject.transform.Find("GameObject/InputField (TMP)").gameObject);
        public class TextAreaBinding
        {
            public readonly GameObject GameObject;
            public TextAreaBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.UI.RectMask2D _rectMask2D;
            public UnityEngine.UI.RectMask2D RectMask2D => _rectMask2D ??= GameObject.GetComponent<UnityEngine.UI.RectMask2D>();
        }
        private TextAreaBinding _textArea;
        public TextAreaBinding TextArea => _textArea ??= new TextAreaBinding(GameObject.transform.Find("GameObject/InputField (TMP)/Text Area").gameObject);
        public class PlaceholderBinding
        {
            public readonly GameObject GameObject;
            public PlaceholderBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
            private UnityEngine.UI.LayoutElement _layoutElement;
            public UnityEngine.UI.LayoutElement LayoutElement => _layoutElement ??= GameObject.GetComponent<UnityEngine.UI.LayoutElement>();
        }
        private PlaceholderBinding _placeholder;
        public PlaceholderBinding Placeholder => _placeholder ??= new PlaceholderBinding(GameObject.transform.Find("GameObject/InputField (TMP)/Text Area/Placeholder").gameObject);
        public class TextBinding
        {
            public readonly GameObject GameObject;
            public TextBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
        }
        private TextBinding _text;
        public TextBinding Text => _text ??= new TextBinding(GameObject.transform.Find("GameObject/InputField (TMP)/Text Area/Text").gameObject);
        public class TextTMP12Binding
        {
            public readonly GameObject GameObject;
            public TextTMP12Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
        }
        private TextTMP12Binding _textTMP12;
        public TextTMP12Binding TextTMP12 => _textTMP12 ??= new TextTMP12Binding(GameObject.transform.Find("GameObject/Text (TMP) (1)2").gameObject);
        public class InputFieldTMP1Binding
        {
            public readonly GameObject GameObject;
            public InputFieldTMP1Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private TMPro.TMP_InputField _tMP_InputField;
            public TMPro.TMP_InputField TMP_InputField => _tMP_InputField ??= GameObject.GetComponent<TMPro.TMP_InputField>();
        }
        private InputFieldTMP1Binding _inputFieldTMP1;
        public InputFieldTMP1Binding InputFieldTMP1 => _inputFieldTMP1 ??= new InputFieldTMP1Binding(GameObject.transform.Find("GameObject/InputField (TMP) (1)").gameObject);
        public class TextArea1Binding
        {
            public readonly GameObject GameObject;
            public TextArea1Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.UI.RectMask2D _rectMask2D;
            public UnityEngine.UI.RectMask2D RectMask2D => _rectMask2D ??= GameObject.GetComponent<UnityEngine.UI.RectMask2D>();
        }
        private TextArea1Binding _textArea1;
        public TextArea1Binding TextArea1 => _textArea1 ??= new TextArea1Binding(GameObject.transform.Find("GameObject/InputField (TMP) (1)/Text Area1").gameObject);
        public class Placeholder1Binding
        {
            public readonly GameObject GameObject;
            public Placeholder1Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
            private UnityEngine.UI.LayoutElement _layoutElement;
            public UnityEngine.UI.LayoutElement LayoutElement => _layoutElement ??= GameObject.GetComponent<UnityEngine.UI.LayoutElement>();
        }
        private Placeholder1Binding _placeholder1;
        public Placeholder1Binding Placeholder1 => _placeholder1 ??= new Placeholder1Binding(GameObject.transform.Find("GameObject/InputField (TMP) (1)/Text Area1/Placeholder1").gameObject);
        public class Text1Binding
        {
            public readonly GameObject GameObject;
            public Text1Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
        }
        private Text1Binding _text1;
        public Text1Binding Text1 => _text1 ??= new Text1Binding(GameObject.transform.Find("GameObject/InputField (TMP) (1)/Text Area1/Text1").gameObject);
        public class ToggleBinding
        {
            public readonly GameObject GameObject;
            public ToggleBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.UI.Toggle _toggle;
            public UnityEngine.UI.Toggle Toggle => _toggle ??= GameObject.GetComponent<UnityEngine.UI.Toggle>();
        }
        private ToggleBinding _toggle;
        public ToggleBinding Toggle => _toggle ??= new ToggleBinding(GameObject.transform.Find("GameObject/Toggle").gameObject);
        public class BackgroundBinding
        {
            public readonly GameObject GameObject;
            public BackgroundBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
        }
        private BackgroundBinding _background;
        public BackgroundBinding Background => _background ??= new BackgroundBinding(GameObject.transform.Find("GameObject/Toggle/Background").gameObject);
        public class CheckmarkBinding
        {
            public readonly GameObject GameObject;
            public CheckmarkBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
        }
        private CheckmarkBinding _checkmark;
        public CheckmarkBinding Checkmark => _checkmark ??= new CheckmarkBinding(GameObject.transform.Find("GameObject/Toggle/Background/Checkmark").gameObject);
        public class LabelBinding
        {
            public readonly GameObject GameObject;
            public LabelBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private TMPro.TextMeshProUGUI _textMeshProUGUI;
            public TMPro.TextMeshProUGUI TextMeshProUGUI => _textMeshProUGUI ??= GameObject.GetComponent<TMPro.TextMeshProUGUI>();
        }
        private LabelBinding _label;
        public LabelBinding Label => _label ??= new LabelBinding(GameObject.transform.Find("GameObject/Toggle/Label").gameObject);
        public class LoadingBarBinding
        {
            public readonly GameObject GameObject;
            public LoadingBarBinding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
        }
        private LoadingBarBinding _loadingBar;
        public LoadingBarBinding LoadingBar => _loadingBar ??= new LoadingBarBinding(GameObject.transform.Find("LoadingBar").gameObject);
        public class Spinner11Binding
        {
            public readonly GameObject GameObject;
            public Spinner11Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.Animation _animation;
            public UnityEngine.Animation Animation => _animation ??= GameObject.GetComponent<UnityEngine.Animation>();
            private UnityEngine.CanvasGroup _canvasGroup;
            public UnityEngine.CanvasGroup CanvasGroup => _canvasGroup ??= GameObject.GetComponent<UnityEngine.CanvasGroup>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private Spinner11Binding _spinner11;
        public Spinner11Binding Spinner11 => _spinner11 ??= new Spinner11Binding(GameObject.transform.Find("LoadingBar/spinner_1_1").gameObject);
        public class Spinner12Binding
        {
            public readonly GameObject GameObject;
            public Spinner12Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.Animation _animation;
            public UnityEngine.Animation Animation => _animation ??= GameObject.GetComponent<UnityEngine.Animation>();
            private UnityEngine.CanvasGroup _canvasGroup;
            public UnityEngine.CanvasGroup CanvasGroup => _canvasGroup ??= GameObject.GetComponent<UnityEngine.CanvasGroup>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private Spinner12Binding _spinner12;
        public Spinner12Binding Spinner12 => _spinner12 ??= new Spinner12Binding(GameObject.transform.Find("LoadingBar/spinner_1_2").gameObject);
        public class Spinner13Binding
        {
            public readonly GameObject GameObject;
            public Spinner13Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.Animation _animation;
            public UnityEngine.Animation Animation => _animation ??= GameObject.GetComponent<UnityEngine.Animation>();
            private UnityEngine.CanvasGroup _canvasGroup;
            public UnityEngine.CanvasGroup CanvasGroup => _canvasGroup ??= GameObject.GetComponent<UnityEngine.CanvasGroup>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private Spinner13Binding _spinner13;
        public Spinner13Binding Spinner13 => _spinner13 ??= new Spinner13Binding(GameObject.transform.Find("LoadingBar/spinner_1_3").gameObject);
        public class Spinner14Binding
        {
            public readonly GameObject GameObject;
            public Spinner14Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.Animation _animation;
            public UnityEngine.Animation Animation => _animation ??= GameObject.GetComponent<UnityEngine.Animation>();
            private UnityEngine.CanvasGroup _canvasGroup;
            public UnityEngine.CanvasGroup CanvasGroup => _canvasGroup ??= GameObject.GetComponent<UnityEngine.CanvasGroup>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private Spinner14Binding _spinner14;
        public Spinner14Binding Spinner14 => _spinner14 ??= new Spinner14Binding(GameObject.transform.Find("LoadingBar/spinner_1_4").gameObject);
        public class Spinner15Binding
        {
            public readonly GameObject GameObject;
            public Spinner15Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.Animation _animation;
            public UnityEngine.Animation Animation => _animation ??= GameObject.GetComponent<UnityEngine.Animation>();
            private UnityEngine.CanvasGroup _canvasGroup;
            public UnityEngine.CanvasGroup CanvasGroup => _canvasGroup ??= GameObject.GetComponent<UnityEngine.CanvasGroup>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private Spinner15Binding _spinner15;
        public Spinner15Binding Spinner15 => _spinner15 ??= new Spinner15Binding(GameObject.transform.Find("LoadingBar/spinner_1_5").gameObject);
        public class Spinner16Binding
        {
            public readonly GameObject GameObject;
            public Spinner16Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.Animation _animation;
            public UnityEngine.Animation Animation => _animation ??= GameObject.GetComponent<UnityEngine.Animation>();
            private UnityEngine.CanvasGroup _canvasGroup;
            public UnityEngine.CanvasGroup CanvasGroup => _canvasGroup ??= GameObject.GetComponent<UnityEngine.CanvasGroup>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private Spinner16Binding _spinner16;
        public Spinner16Binding Spinner16 => _spinner16 ??= new Spinner16Binding(GameObject.transform.Find("LoadingBar/spinner_1_6").gameObject);
        public class Spinner17Binding
        {
            public readonly GameObject GameObject;
            public Spinner17Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.Animation _animation;
            public UnityEngine.Animation Animation => _animation ??= GameObject.GetComponent<UnityEngine.Animation>();
            private UnityEngine.CanvasGroup _canvasGroup;
            public UnityEngine.CanvasGroup CanvasGroup => _canvasGroup ??= GameObject.GetComponent<UnityEngine.CanvasGroup>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private Spinner17Binding _spinner17;
        public Spinner17Binding Spinner17 => _spinner17 ??= new Spinner17Binding(GameObject.transform.Find("LoadingBar/spinner_1_7").gameObject);
        public class Spinner18Binding
        {
            public readonly GameObject GameObject;
            public Spinner18Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.Animation _animation;
            public UnityEngine.Animation Animation => _animation ??= GameObject.GetComponent<UnityEngine.Animation>();
            private UnityEngine.CanvasGroup _canvasGroup;
            public UnityEngine.CanvasGroup CanvasGroup => _canvasGroup ??= GameObject.GetComponent<UnityEngine.CanvasGroup>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private Spinner18Binding _spinner18;
        public Spinner18Binding Spinner18 => _spinner18 ??= new Spinner18Binding(GameObject.transform.Find("LoadingBar/spinner_1_8").gameObject);
        public class Spinner19Binding
        {
            public readonly GameObject GameObject;
            public Spinner19Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.Animation _animation;
            public UnityEngine.Animation Animation => _animation ??= GameObject.GetComponent<UnityEngine.Animation>();
            private UnityEngine.CanvasGroup _canvasGroup;
            public UnityEngine.CanvasGroup CanvasGroup => _canvasGroup ??= GameObject.GetComponent<UnityEngine.CanvasGroup>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private Spinner19Binding _spinner19;
        public Spinner19Binding Spinner19 => _spinner19 ??= new Spinner19Binding(GameObject.transform.Find("LoadingBar/spinner_1_9").gameObject);
        public class Spinner110Binding
        {
            public readonly GameObject GameObject;
            public Spinner110Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.Animation _animation;
            public UnityEngine.Animation Animation => _animation ??= GameObject.GetComponent<UnityEngine.Animation>();
            private UnityEngine.CanvasGroup _canvasGroup;
            public UnityEngine.CanvasGroup CanvasGroup => _canvasGroup ??= GameObject.GetComponent<UnityEngine.CanvasGroup>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private Spinner110Binding _spinner110;
        public Spinner110Binding Spinner110 => _spinner110 ??= new Spinner110Binding(GameObject.transform.Find("LoadingBar/spinner_1_10").gameObject);
        public class Spinner111Binding
        {
            public readonly GameObject GameObject;
            public Spinner111Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.Animation _animation;
            public UnityEngine.Animation Animation => _animation ??= GameObject.GetComponent<UnityEngine.Animation>();
            private UnityEngine.CanvasGroup _canvasGroup;
            public UnityEngine.CanvasGroup CanvasGroup => _canvasGroup ??= GameObject.GetComponent<UnityEngine.CanvasGroup>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private Spinner111Binding _spinner111;
        public Spinner111Binding Spinner111 => _spinner111 ??= new Spinner111Binding(GameObject.transform.Find("LoadingBar/spinner_1_11").gameObject);
        public class Spinner112Binding
        {
            public readonly GameObject GameObject;
            public Spinner112Binding(GameObject gameObject) => GameObject = gameObject;
            private UnityEngine.RectTransform _rectTransform;
            public UnityEngine.RectTransform RectTransform => _rectTransform ??= GameObject.GetComponent<UnityEngine.RectTransform>();
            private UnityEngine.CanvasRenderer _canvasRenderer;
            public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer ??= GameObject.GetComponent<UnityEngine.CanvasRenderer>();
            private UnityEngine.UI.Image _image;
            public UnityEngine.UI.Image Image => _image ??= GameObject.GetComponent<UnityEngine.UI.Image>();
            private UnityEngine.Animation _animation;
            public UnityEngine.Animation Animation => _animation ??= GameObject.GetComponent<UnityEngine.Animation>();
            private UnityEngine.CanvasGroup _canvasGroup;
            public UnityEngine.CanvasGroup CanvasGroup => _canvasGroup ??= GameObject.GetComponent<UnityEngine.CanvasGroup>();
            private Tools.StyleSystem.Wrappers.ImageStyleHolder _imageStyleHolder;
            public Tools.StyleSystem.Wrappers.ImageStyleHolder ImageStyleHolder => _imageStyleHolder ??= GameObject.GetComponent<Tools.StyleSystem.Wrappers.ImageStyleHolder>();
        }
        private Spinner112Binding _spinner112;
        public Spinner112Binding Spinner112 => _spinner112 ??= new Spinner112Binding(GameObject.transform.Find("LoadingBar/spinner_1_12").gameObject);
    }
}
