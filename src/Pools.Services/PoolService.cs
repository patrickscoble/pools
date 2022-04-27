using System.Collections.Generic;
using Pools.Core.Models;
using Pools.Core.Repositories;
using Pools.Core.Services;

namespace Pools.Services
{
    public class PoolService : IPoolService
    {
        private IPoolRepository _poolRepository;

        public PoolService(IPoolRepository poolRepository)
        {
            _poolRepository = poolRepository;
        }

        public IEnumerable<Pool> GetAll()
        {
            return _poolRepository.GetAll();
        }
    }
}
