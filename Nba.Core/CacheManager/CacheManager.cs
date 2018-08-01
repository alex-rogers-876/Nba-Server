using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Caching.Memory;
namespace Nba.Core.CacheManager
{
    class CacheManager
    {
        private readonly IMemoryCache _dbContext;

        public CacheManager(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
