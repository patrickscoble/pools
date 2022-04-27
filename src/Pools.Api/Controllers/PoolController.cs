using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pools.Core.Models;
using Pools.Core.Services;

namespace Pools.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PoolController : ControllerBase
    {
        private readonly IPoolService _poolService;

        public PoolController(IPoolService poolService)
        {
            _poolService = poolService;
        }

        [HttpGet("")]
        public IEnumerable<Pool> GetAll()
        {
            return _poolService.GetAll();
        }
    }
}
