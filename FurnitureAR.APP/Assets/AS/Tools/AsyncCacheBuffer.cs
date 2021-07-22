using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AS.Tools
{
    public class AsyncCacheBuffer<TKey, TValue>
    {
        public IReadOnlyDictionary<TKey, TValue> Items => _cache;
        
        private readonly ConcurrentDictionary<TKey, SemaphoreSlim> _keyLocks = new ConcurrentDictionary<TKey, SemaphoreSlim>();
       
        private readonly ConcurrentDictionary<TKey, TValue> _cache = new ConcurrentDictionary<TKey, TValue>();

        public async Task<TValue> Get(TKey key, Task<TValue> getTask)
        {   
            TValue value;
            // get the semaphore specific to this username
            var keyLock = _keyLocks.GetOrAdd(key, x => new SemaphoreSlim(1));
            await keyLock.WaitAsync().ConfigureAwait(false);
            try
            {
                // try to get Store from cache
                if (!_cache.TryGetValue(key, out value))
                {
                    // if value isn't cached, get it from the DB asynchronously
                    value = await getTask;

                    // cache value
                    _cache.TryAdd(key, value);
                }
            }
            finally
            {
                keyLock.Release();
            }
            return value;
        }
    }
}