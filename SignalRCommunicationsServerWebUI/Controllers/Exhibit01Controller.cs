using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRCommunicationsServerWebUI.Models
{
    [ApiController]
    [Route("[controller]")]
    public class Exhibit01Controller : ControllerBase
    {
        private readonly ILogger<Exhibit01Controller> _logger;

        public Exhibit01Controller(ILogger<Exhibit01Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Exhibit01> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 1).Select(index => new Exhibit01
                {
                    Message = "hi",
                    Number = rng.Next(1,100)
                })
                .ToArray();
        }
    }
}
