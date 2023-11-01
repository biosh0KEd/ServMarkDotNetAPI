using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServMarkService.Services;

namespace ServMarkService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _service;
        
        public UserController(IUserService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.Get());
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.User user)
        {
            await _service.Add(user);
            return Ok(user);
        }
    }
}
