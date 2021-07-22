using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Tools
{
    public class TouchScaler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
    {
        public Single TargetScale = 1.15f;

        public Single BaseScale = 1.0f;

        public Single TransitionSpeed = 1.0f;
        
        private Boolean _isDown;

        public void OnPointerDown(PointerEventData data)
        {
            _isDown = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _isDown = false;
        }
        
        public void OnPointerExit(PointerEventData eventData)
        {
            _isDown = false;
        }

        private void Update()
        {
            transform.localScale = Vector3.Lerp(transform.localScale, 
                Vector3.one * (_isDown? TargetScale : BaseScale), 
                TransitionSpeed * Time.deltaTime);
        }
        
    }
}
