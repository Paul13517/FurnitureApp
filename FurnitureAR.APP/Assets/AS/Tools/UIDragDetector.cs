using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Tools
{


    public class UIDragDetector : MonoBehaviour, IBeginDragHandler, IEndDragHandler
    {

        public UnityEvent OnDragStart;
        public UnityEvent OnDragEnd;
        
        public Boolean IsDrag { private set; get; }
        
        public void OnBeginDrag(PointerEventData eventData)
        {
            Debug.Log("beginDrag");
            OnDragStart?.Invoke();
            IsDrag = true;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            OnDragEnd?.Invoke();
            IsDrag = false;
        }
    }
}
