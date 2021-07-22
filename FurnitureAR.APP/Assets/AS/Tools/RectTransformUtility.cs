using UnityEngine;

namespace Tools
{
    public static class RectTransformUtility
    {
        public static Rect GetScreenRect(this RectTransform rectTransform, Camera camera)
        {
            if (rectTransform is null || camera is null)
            {
                return new Rect();
            }
            
            var size = Vector2.Scale(rectTransform.rect.size, rectTransform.lossyScale);
            var position = rectTransform.position;
            var pivot = rectTransform.pivot;
            
            var rect = new Rect(position.x, position.y, size.x, size.y);
            
            rect.x -= pivot.x * size.x;
            rect.y -= pivot.y * size.y;
            return rect;
            

        }
    }
}