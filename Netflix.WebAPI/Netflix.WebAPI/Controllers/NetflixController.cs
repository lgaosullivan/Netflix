using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Netflix.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NetflixController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<NetflixController> _logger;

        public NetflixController(ILogger<NetflixController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Models.Netflix> Get()
        {
            var rng = new Random();
            int count = 0;

            return Enumerable.Range(1, 100).Select(index => new Models.Netflix
            {

                Id = count++
                ,
                UserId = count++,
                Title = "sunt aut facere repellat provident...",
                Body = "quia et suscipit\nsuscipi..."
            })
            .ToArray();
        }
    }
}
