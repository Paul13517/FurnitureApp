using System;
using System.Collections;
using UnityEngine;

namespace Tools.AnimationUtility
{
    public sealed class ValueAnimator
    {
        public Int32 CurrentPlayTime => (Int32)(_timer * 1000);
        
        public Int32 Duration { get; private set; }

        public event Action<ValueAnimator> OnUpdateListener;

        public event Action<ValueAnimator> OnAnimationEndListener;

        public event Action<ValueAnimator> OnAnimationStartListener;

        public Func<Single, Single> Interpolator { get; private set; }

        public Single InterpolationValue { get; private set; }

        public ValueAnimator(Action<ValueAnimator> updateListener = null) => (Interpolator, OnUpdateListener) = (t => t, updateListener);
        
        private Coroutine _coroutine;

        private MonoBehaviour _monoBehaviour;

        private Single _timer;
        
        public void Start(MonoBehaviour monoBehaviour)
        {
            _monoBehaviour = monoBehaviour;

            Cancel();

            _coroutine = monoBehaviour.StartCoroutine(AnimationCoroutine());
            
            _timer = 0.0f;
            InterpolationValue = 0.0f;
            OnUpdateListener?.Invoke(this);
            
            OnAnimationStartListener?.Invoke(this);
        }
        
        public void Cancel()
        {
            if (_coroutine != null)
            {
                _monoBehaviour.StopCoroutine(_coroutine);
                OnAnimationEndListener?.Invoke(this);
            }
        }

        public ValueAnimator SetUpdateListener(Action<ValueAnimator> listener)
        {
            OnUpdateListener += listener;
            return this;
        }
        
        public ValueAnimator SetStartListener(Action<ValueAnimator> listener)
        {
            OnAnimationStartListener += listener;
            return this;
        }
        
        public ValueAnimator SetEndListener(Action<ValueAnimator> listener)
        {
            OnAnimationEndListener += listener;
            return this;
        }

        public ValueAnimator SetDuration(Int32 durationMs)
        {
            Duration = durationMs;
            return this;
        }
        
        public ValueAnimator SetInterpolator(Func<Single, Single> interpolator)
        {
            Interpolator = interpolator;
            return this;
        }

        private IEnumerator AnimationCoroutine()
        {
            while (_timer < Duration)
            {
                if (_monoBehaviour != null)
                {
                    _timer = Mathf.Min(_timer + Time.deltaTime * 1000.0f, Duration);
                    InterpolationValue = Interpolator.Invoke(_timer / Duration);
                    OnUpdateListener?.Invoke(this);
                    yield return null;
                }
            }

            if (_monoBehaviour != null)
            {
                OnAnimationEndListener?.Invoke(this);
            }
        }
    }
}
