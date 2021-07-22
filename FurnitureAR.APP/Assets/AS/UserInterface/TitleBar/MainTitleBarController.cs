using System;
using Tools;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.TitleBar
{
    public class MainTitleBarController : MonoBehaviour
    {
        public Single AnimationSpeed = 10.0f;

        public ScrollRect ScrollRect;
        
        public TMPro.TextMeshProUGUI BigHeader;

        public TMPro.TextMeshProUGUI Header;

        public RectTransform Shadow;

        public Single TextOffset { private set; get; }
        
        private CanvasGroup _bigHeaderCanvasGroup;

        private CanvasGroup _headerCanvasGroup;

        private RectTransform _bigHeaderParent;

        private Vector3 _bigHeaderParentStartPosition;
        
        private Vector3 _shadowStartPosition;

        [SerializeField] private Single _additionMargin = 0;
        
        public void SetText(String text)
        {
            Header.text = text;
            BigHeader.text = text;
            MoveScrollViewByTitleBarExtraHeight(text);
        }
        
        private void MoveScrollViewByTitleBarExtraHeight(String text)
        {
            var crunchHeight = (Screen.width / PlatformDisplayMetrics.DpDensity - (BigHeader.margin.x + BigHeader.margin.z)) - _additionMargin;
            
            var addOffset = BigHeader.GetPreferredValues(text,crunchHeight, Mathf.Infinity);

            var scrollViewRectTransform = ScrollRect.GetComponent<RectTransform>();

            TextOffset = addOffset.y;

            scrollViewRectTransform.offsetMax -= TextOffset * Vector2.up;
        }

        private void Awake()
        {
            _shadowStartPosition = Shadow.anchoredPosition;
            _bigHeaderCanvasGroup = BigHeader.GetComponent<CanvasGroup>();
            _headerCanvasGroup = Header.GetComponent<CanvasGroup>();
            _bigHeaderParent = BigHeader.transform.parent.GetComponent<RectTransform>();
            _bigHeaderParentStartPosition = _bigHeaderParent.anchoredPosition;
        }
        
        private void LateUpdate()
        {
            if (BigHeader.text is null)
                return;
            
            if (BigHeader.text.Length == 0)
                return;

            if (_bigHeaderParent.sizeDelta.y == 0.0f)
                return;
            
            
            var t = Mathf.Clamp(ScrollRect.content.anchoredPosition.y / _bigHeaderParent.sizeDelta.y, 0.0f, 1.0f);

            BigHeader.rectTransform.localScale = Vector3.one * (1.0f - Mathf.Clamp(t * 2, 0.0f, 1.0f));

            if (t <= 0.2f)
            {
                _bigHeaderCanvasGroup.alpha = Mathf.Lerp(_bigHeaderCanvasGroup.alpha, 1.0f - t * 2, AnimationSpeed * Time.deltaTime);
                _headerCanvasGroup.alpha = Mathf.Lerp(_headerCanvasGroup.alpha, t, AnimationSpeed * Time.deltaTime);
            }
            else
            {
                _bigHeaderCanvasGroup.alpha = Mathf.Lerp(_bigHeaderCanvasGroup.alpha, 0.0f, AnimationSpeed * Time.deltaTime);
                _headerCanvasGroup.alpha = Mathf.Lerp(_headerCanvasGroup.alpha, 1.0f, AnimationSpeed * Time.deltaTime);
            }

            _bigHeaderParent.anchoredPosition = _bigHeaderParentStartPosition + Vector3.up * _bigHeaderParent.sizeDelta.y * t;
                
            Shadow.anchoredPosition = _shadowStartPosition + Vector3.up * (_bigHeaderParent.sizeDelta.y * t - TextOffset);
        }
    }
}
