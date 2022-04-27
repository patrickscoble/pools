using System.Collections.Generic;
using Pools.Core.Models;

namespace Pools.Core.Repositories
{
    public interface IPoolRepository
    {
        IEnumerable<Pool> GetAll();
    }
}
