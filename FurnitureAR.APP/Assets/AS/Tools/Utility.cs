using System;
using System.Collections;

namespace Tools
{
    
    public static class Utility
    {
        public static IEnumerator DoOnNextFrameCoroutine(Action action)
        {
            yield return null;
            action?.Invoke();
        }
    }
}
