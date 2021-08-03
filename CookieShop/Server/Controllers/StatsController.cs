using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookieShop.Server.Services.StatsService;
using Microsoft.AspNetCore.Mvc;


namespace CookieShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly IStatsService _statsService;

        public StatsController(IStatsService statsService)
        {
            _statsService = statsService;
        }

        [HttpGet]
        public async Task<ActionResult<int>> GetVisits()
        {
            return await _statsService.GetVisits();
        }

        [HttpPost]
        public async Task IncrementVisits()
        {
            await _statsService.IncrementVisits();
        }
    }
}
