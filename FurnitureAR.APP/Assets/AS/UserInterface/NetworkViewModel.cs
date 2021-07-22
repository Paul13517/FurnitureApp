using System;
using System.Threading;
using System.Threading.Tasks;
using UniRx;

namespace UserInterface
{
    public enum LoadStatus
    {
        Loading,
        Success,
        Error,
        Cancel
    }

    public class ViewModelForNetwork : ViewModel, IDisposable
    {
        public IReactiveProperty<LoadStatus> LoadStatus => _loadStatus;

        protected CancellationToken CancellationToken;

        private readonly ReactivePropertyNoInit<LoadStatus> _loadStatus = new ReactivePropertyNoInit<LoadStatus>();
        
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        private TaskCompletionSource<Boolean> _isInitComplete = new TaskCompletionSource<Boolean>(false);

        private Boolean _isDisposed;
        
        public ViewModelForNetwork()
        {
            CancellationToken = _cancellationTokenSource.Token;
            CancellationToken.Register(() => _isInitComplete.TrySetCanceled());
        }

        public void CancelLoading() => Dispose();

        protected async Task WaitForInit() => await _isInitComplete.Task;

        protected void SetLoadStatus(LoadStatus loadStatus) => _loadStatus.SetValueAndForceNotify(loadStatus);
        
        protected void SetInitComplete() => _isInitComplete.SetResult(true);

        public void Dispose()
        {
            if (_isDisposed)
                return;
            
            OnDispose();
            
            _isDisposed = true;
            
            _cancellationTokenSource.Cancel();
        }

        protected virtual void OnDispose()
        {
            
        }

        ~ViewModelForNetwork()
        {
            Dispose();
        }
    }
}