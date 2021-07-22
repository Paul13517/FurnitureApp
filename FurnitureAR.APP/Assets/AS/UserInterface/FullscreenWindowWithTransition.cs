using System;
using Tools.AnimationUtility;
using UniRx;
using UnityEngine;

namespace UserInterface
{
    public abstract class FullscreenWindowWithTransition : global::Tools.WindowSystem.Window
    {
        public const Int32 TransitionDuration = 300;

        protected readonly FullscreenWindowWithTransition PreviousWindow;

        protected event Action OnShow;
        
        protected Boolean IsTopWindow;
        
        protected Boolean AnimateScale = true;

        protected Boolean CanClose = true;
        
        private MonoBehaviourAnimations.MonoBehaviourStub _windowFrameAnimationStub;
        
        private RectTransform _windowFrameRectTransform;
        
        public FullscreenWindowWithTransition(FullscreenWindowWithTransition previousWindow)
        {
            PreviousWindow = previousWindow;
            
            IsTopWindow = true;

            GetWindowFrame(windowFrame =>
            {
                _windowFrameRectTransform = windowFrame;
                _windowFrameAnimationStub = windowFrame.gameObject.AddComponent<MonoBehaviourAnimations.MonoBehaviourStub>();
            });

            if (previousWindow != null)
            {
            }

            GetWindowFrame(windowFrame =>
            {
                if (previousWindow != null)
                {
                    windowFrame.anchorMin = new Vector2(1.0f, 0.0f);
                    windowFrame.anchorMax = new Vector2(2.0f, 1.0f);
                    ShowAnimation();
                    ScaleAnimation();
                }

                Observable.EveryUpdate() 
                    .Where(_ => Input.GetKeyDown(KeyCode.Escape) && IsTopWindow)
                    .Subscribe (_ => {
                        if (previousWindow is null)
                        {
                            Application.Quit();
                        }
                        else
                        {
                            Close();
                        }
                    }).AddTo (windowFrame);
            });
            

            if (PreviousWindow != null)
            {
                PreviousWindow.IsTopWindow = false;
            }
        }
        
        public void Close()
        {
            if (CanClose)
            {
                CloseAnimation();
                OnClose();
            }   
        }

        protected virtual void OnClose()
        {
            
        }

        private void ScaleAnimation()
        {
            if(AnimateScale) {
                _windowFrameAnimationStub.Animate().
                    Scale(Vector2.one / 2.0f, Vector2.one).
                    SetInterpolator(AnimationCurves.EaseInOutCubic).
                    SetDuration(TransitionDuration).
                    Start(_windowFrameAnimationStub);
            }
        }
        
        private void ShowAnimation()
        {
            GetWindowFrame(_ =>
            {
                _windowFrameAnimationStub.Animate().AnchorMin(new Vector2(0.0f, 0.0f)).
                    SetInterpolator(AnimationCurves.EaseInOutCubic).
                    SetDuration(TransitionDuration)
                    .SetStartListener(animator =>
                    {
                        IsVisible = true;
                    } )
                    .SetEndListener(animator =>
                    {
                        OnShow?.Invoke();
                        IsClickable = true;
                    })
                    .Start(_windowFrameAnimationStub);
                
                _windowFrameAnimationStub.Animate().AnchorMax(new Vector2(1.0f, 1.0f)).
                    SetInterpolator(AnimationCurves.EaseInOutCubic).
                    SetDuration(TransitionDuration).Start(_windowFrameAnimationStub);
            });
        }

        private void HideAnimation()
        {
            GetWindowFrame(_ =>
            {
                _windowFrameAnimationStub.Animate().
                    AnchorMin(new Vector2(-1.0f, 0.0f)).
                    SetInterpolator(AnimationCurves.EaseInOutCubic).
                    SetDuration(TransitionDuration)
                    .SetStartListener(animator =>
                    {
                        IsClickable = false;
                    } )
                    .SetEndListener(animator =>
                    {
                        IsVisible = false;
                    })
                    .Start(_windowFrameAnimationStub);
                
                _windowFrameAnimationStub.Animate().AnchorMax(new Vector2(0.0f, 1.0f)).
                    SetInterpolator(AnimationCurves.EaseInOutCubic).
                    SetDuration(TransitionDuration).Start(_windowFrameAnimationStub);
            });
        }

        private void CloseAnimation()
        {
            if (PreviousWindow != null)
            {
                PreviousWindow.IsTopWindow = true;
            }

            GetWindowFrame(_ =>
            {
                _windowFrameAnimationStub.Animate().AnchoredPosition(Vector2.right * _windowFrameRectTransform.rect.width).
                    SetInterpolator(AnimationCurves.EaseInOutCubic).
                    SetDuration(TransitionDuration)
                    .SetStartListener(animator =>
                    {
                        IsClickable = false;
                    } )
                    .SetEndListener(animator =>
                    {
                        GetWindowsHolder(holder =>
                        {
                            holder.DetachWindow(this);
                        });
                    })
                    .Start(_windowFrameAnimationStub);
            });
        }
    }
}