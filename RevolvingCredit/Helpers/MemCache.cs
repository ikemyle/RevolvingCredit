using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace RevolvingCredit.Helpers
{
    public class MemCache
    {
        private readonly IMemoryCache _memoryCache;
        public MemCache(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public object Get(string key)
        {
            if (_memoryCache.TryGetValue(key, out var value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }
        public void Set(string key, object value)
        {
            var cacheOptions = new MemoryCacheEntryOptions()
                  .SetSlidingExpiration(TimeSpan.FromSeconds(300))
                  .SetAbsoluteExpiration(TimeSpan.FromSeconds(600));
            _memoryCache.Set(key, value, cacheOptions);
        }
    }
}
