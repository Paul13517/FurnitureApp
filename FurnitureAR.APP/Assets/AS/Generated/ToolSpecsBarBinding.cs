using System;
using UnityEngine;
namespace Generated
{
    public class ToolSpecsBarBinding
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
        public ToolSpecsBarBinding(GameObject gameObject) => GameObject = gameObject;
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
        public TextTMPBinding TextTMP => _textTMP ??= new TextTMPBinding(GameObject.transform.Find("Text (TMP)").gameObject);
    }
}
