using System.Collections.Generic;
using Pools.Core.Models;

namespace Pools.Core.Services
{
    public interface IPoolService
    {
        IEnumerable<Pool> GetAll();
    }
}
