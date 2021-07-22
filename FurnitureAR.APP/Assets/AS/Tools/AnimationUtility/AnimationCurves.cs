using System;
using UnityEngine;

namespace Tools.AnimationUtility
{
    public static class AnimationCurves
    {
        public static Single EaseInOutCubic(Single x) => x < 0.5 ? 4 * x * x * x : 1 - Mathf.Pow(-2 * x + 2, 3) / 2;
        
        public static Single EaseOutBack(Single x) {
            var c1 = 1.70158f;
            var c3 = c1 + 1;

            return 1 + c3 * Mathf.Pow(x - 1, 3) + c1 * Mathf.Pow(x - 1, 2);
        }
        
        public static Single EaseInOutBack(Single x) {
            var c1 = 1.70158f;
            var c2 = c1 * 1.525f;

            return x < 0.5
                ? (Mathf.Pow(2 * x, 2) * ((c2 + 1) * 2 * x - c2)) / 2
                : (Mathf.Pow(2 * x - 2, 2) * ((c2 + 1) * (x * 2 - 2) + c2) + 2) / 2;
        }
    }
}