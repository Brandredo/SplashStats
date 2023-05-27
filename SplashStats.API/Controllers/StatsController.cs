using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SplashStats.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatsController : ControllerBase
    {
        [HttpGet("Player/{name}")]
        public async Task<ActionResult<string>> GetPlayerStats(string name)
        {
            return "test";
        }

    }
}

