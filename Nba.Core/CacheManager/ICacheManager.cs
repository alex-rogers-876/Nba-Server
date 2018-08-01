using System;
using System.Collections.Generic;
using System.Text;

namespace Nba.Core.CacheManager
{
    public interface ICacheManager
    {
          TItem  <TItem>( object key, MemoryCache);
    }
}
