using System;
using System.Collections.Generic;
using UnityEngine;

namespace Tools.AnimationUtility
{
    public static class MonoBehaviourAnimations
    {
        public class MonoBehaviourStub : MonoBehaviour
        {
            
        }

        private static Dictionary<(MonoBehaviour monoBehaviour, String animationTag), ValueAnimator> _animations = new Dictionary<(MonoBehaviour monoBehaviour, String animationTag), ValueAnimator>();

        public class Animation
        {
            private MonoBehaviour _monoBehaviour;

            private RectTransform _rectTransform;

            public Animation(MonoBehaviour monoBehaviour) => _monoBehaviour = monoBehaviour;

            public const String PosAnimTag = "POS_ANIM_TAG";
            public const String AnchorPosAnimTag = "ANCHOR_POS_ANIM_TAG";
            public const String ScaleAnimTag = "SCALE_ANIM_TAG";
            public const String AnchorMinTag = "ANCHOR_MIN_ANIM_TAG";
            public const String AnchorMaxTag = "ANCHOR_MAX_ANIM_TAG";

            private ValueAnimator Universal(String keyTag, Action<ValueAnimator> listener)
            {
                var key = (_monoBehaviour, keyTag);
                
                if (_animations.ContainsKey(key))
                {
                    _animations[key].Cancel();
                }
                
                var animation = new ValueAnimator(it => listener?.Invoke(it));

                animation.SetStartListener(_ =>
                {
                    _animations.Add(key, animation);
                });
                
                animation.SetEndListener(_ =>
                {
                    _animations.Remove(key);
                });
                
                return animation;
            }
            
            public ValueAnimator Position(Vector3 from, Vector3 to)
            {
                return Universal(PosAnimTag, it => _monoBehaviour.transform.position = Vector3.LerpUnclamped(from, to, it.InterpolationValue));
            }
            
            public ValueAnimator AnchoredPosition(Vector2 from, Vector2 to)
            {
                if (_rectTransform == null)
                {
                    _rectTransform = _monoBehaviour.GetComponent<RectTransform>();
                }

                return Universal(AnchorPosAnimTag, it => _rectTransform.anchoredPosition = Vector2.LerpUnclamped(from, to, it.InterpolationValue));
            }
            
            public ValueAnimator Scale(Vector3 from, Vector3 to)
            {
                return Universal(ScaleAnimTag, it => _monoBehaviour.transform.localScale = Vector3.LerpUnclamped(from, to, it.InterpolationValue));
            }

            public ValueAnimator AnchorMin(Vector2 from, Vector2 to)
            {
                if (_rectTransform == null)
                {
                    _rectTransform = _monoBehaviour.GetComponent<RectTransform>();
                }

                return Universal(AnchorMinTag, it => _rectTransform.anchorMin = Vector2.LerpUnclamped(from, to, it.InterpolationValue));
            }
            
            public ValueAnimator AnchorMax(Vector2 from, Vector2 to)
            {
                if (_rectTransform == null)
                {
                    _rectTransform = _monoBehaviour.GetComponent<RectTransform>();
                }

                return Universal(AnchorMaxTag, it => _rectTransform.anchorMax = Vector2.LerpUnclamped(from, to, it.InterpolationValue));
            }
            
            public ValueAnimator Position(Vector3 to) => Position(_monoBehaviour.transform.position, to);
            
            public ValueAnimator AnchoredPosition(Vector2 to) => AnchoredPosition((_rectTransform ??= _monoBehaviour.GetComponent<RectTransform>()).anchoredPosition, to);
            
            public ValueAnimator Scale(Vector2 to) => Scale(_monoBehaviour.transform.localScale, to);
            
            public ValueAnimator AnchorMin(Vector2 to) => AnchorMin((_rectTransform ??= _monoBehaviour.GetComponent<RectTransform>()).anchorMin, to); 
         
            public ValueAnimator AnchorMax(Vector2 to) => AnchorMax((_rectTransform ??= _monoBehaviour.GetComponent<RectTransform>()).anchorMax, to); 
        }

        public static Animation Animate(this MonoBehaviour monoBehaviour)
        {
            return new Animation(monoBehaviour);
        }
    }
}