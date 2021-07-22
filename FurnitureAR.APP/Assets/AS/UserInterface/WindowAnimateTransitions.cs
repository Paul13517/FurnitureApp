using System;
using Tools.AnimationUtility;
using UnityEngine;
using Tools.WindowSystem;

namespace AS.UserInterface
{
    public static class WindowAnimateTransitions
    {
        public const Int32 AnimationDuration = 275;

        public static void OpenWindow(this Window thisWindow, Window.WindowsHolder windowHolder, Window window)
        {
            windowHolder.AttachWindow(window);
            window.IsClickable = false;
            thisWindow.IsVisible = false;
            thisWindow.IsClickable = false;

            window.OnDetach += (() =>
            {
                thisWindow.IsVisible = true;
                thisWindow.IsClickable = true;
                thisWindow.GetWindowFrame(windowFrame =>
                {
                    var thisStub = windowFrame.GetComponent<MonoBehaviourAnimations.MonoBehaviourStub>() ??
                        windowFrame.gameObject.AddComponent<MonoBehaviourAnimations.MonoBehaviourStub>();

                    thisStub.Animate().Scale(Vector3.one * 1.1f, Vector2.one * 1.0f).SetInterpolator(AnimationCurves.EaseInOutCubic).SetEndListener(it => window.IsClickable = true).SetDuration(AnimationDuration).Start(thisStub);
                });
            });

            window.GetWindowFrame(windowFrame =>
            {
                var stub = windowFrame.gameObject.AddComponent<MonoBehaviourAnimations.MonoBehaviourStub>();
                // stub.Animate().AnchorMin(Vector2.zero, new Vector2(0.0f, 0.0f))
                //     .SetInterpolator(AnimationCurves.EaseInOutCubic)
                //     .SetDuration(AnimationDuration).SetEndListener(it => window.IsClickable = true)
                //     .Start(stub);
                // stub.Animate().AnchorMax(new Vector2(1.0f, -1.0f), new Vector2(1.0f, 1.0f))
                //     .SetInterpolator(AnimationCurves.EaseInOutCubic)
                //     .SetDuration(AnimationDuration)
                //     .Start(stub);
                stub.Animate().Scale(Vector3.one * 1.1f, Vector2.one * 1.0f).SetInterpolator(AnimationCurves.EaseInOutCubic).SetEndListener(it => window.IsClickable = true).SetDuration(AnimationDuration).Start(stub);
            });
        }

        public static void CloseWindow(Window.WindowsHolder windowHolder, Window window)
        {
            window.IsClickable = false;
            window.IsVisible = false;
            windowHolder.DetachWindow(window);
        }
    }
}