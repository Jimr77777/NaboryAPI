using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace NaboryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IApplicationDbContext _dbContext;

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, IApplicationDbContext userRepository)
        {
            _dbContext = userRepository;
            _logger = logger;
        }

        [HttpGet("{Id}", Name = "UserById")]
        public async Task<IActionResult> Get(int Id)
        {
            try
            {
                var user = await _dbContext.Users.FindAsync(Id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
          
        }

        [HttpPost]
        public async Task<IActionResult> Post(User _user)
        {
            //await _dbContext.Users.AddAsync();
            return Ok(_user);
        }

    }
}
