using System;
using Tools;
using UnityEngine;

public class StatusBarRect : MonoBehaviour
{
    private RectTransform _rectTransform;
    

    public void SetStatusBarHeight(Int32 height)
    {
        (_rectTransform ??= GetComponent<RectTransform>())
            .SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height / PlatformDisplayMetrics.DpDensity);
    }
}
