using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarwarsStuff.Api.Database;
using StarwarsStuff.Api.Models;

namespace StarwarsStuff.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PlanetsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<PlanetsController> _logger;
        private readonly StarwarsStuffDbContext _dbContext;

        public PlanetsController(ILogger<PlanetsController> logger, StarwarsStuffDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext; 
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Planets.ToList());
        }
    }
}
