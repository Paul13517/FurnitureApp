using System;
using AS.UserInterface;
using UniRx;
using UnityEngine;

namespace Tools.WindowSystem
{
    public abstract class FullscreenWindow : Window, IDisposable
    {
        public FullscreenWindow()
        {
            GetWindowFrame(windowFrame =>
            {
                GetWindowsHolder(windowsHolder =>
                {
                    Observable.EveryUpdate().Subscribe(it =>
                    {
                        if (IsClickable && Input.GetKeyDown(KeyCode.Escape))
                            WindowAnimateTransitions.CloseWindow(windowsHolder, this);
                    }).AddTo(windowFrame);
                });
            });

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}