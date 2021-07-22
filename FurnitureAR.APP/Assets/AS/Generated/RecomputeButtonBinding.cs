using UnityEngine;
namespace Generated
{
    public class RecomputeButtonBinding
    {
        public readonly GameObject GameObject;
        public RecomputeButtonBinding(GameObject gameObject) => GameObject = gameObject;
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
        public RecomputeTextBinding RecomputeText => _recomputeText ??= new RecomputeTextBinding(GameObject.transform.Find("RecomputeText").gameObject);
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
        public RecomputeButtonShadowBinding RecomputeButtonShadow => _recomputeButtonShadow ??= new RecomputeButtonShadowBinding(GameObject.transform.Find("RecomputeButtonShadow").gameObject);
    }
}
