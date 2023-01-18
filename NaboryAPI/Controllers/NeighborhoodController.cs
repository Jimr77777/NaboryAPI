using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace NaboryAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NeighborhoodController : ControllerBase
    {
        private readonly Neighborhood[] neighborhood;
        private readonly ILogger<NeighborhoodController> _logger;

        public NeighborhoodController(ILogger<NeighborhoodController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Neighborhood> Get()
        {

            return neighborhood;
        }

    }
}
