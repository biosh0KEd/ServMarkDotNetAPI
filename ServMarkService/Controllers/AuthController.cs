using Microsoft.AspNetCore.Mvc;
using ServMarkService.Models;
using ServMarkService.Services;

namespace ServMarkService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _service;
        public AuthController(IUserService service)
        {
            _service = service;
        }
        
        [HttpPost("login")]
        public async Task<IActionResult> Post([FromBody] UserDto userDto)
        {
            var user = await _service.GetByEmail(userDto.Email);
            if (user == null)
                return NotFound();
            if (user.Password != userDto.Password)
                return Unauthorized();
            
            return Ok(new Token{AccessToken = Guid.NewGuid().ToString()});
        }
        
        [HttpGet("profile")]
        public IActionResult Get()
        {
            var user = _service.Get().Take(1);
            return Ok(user.First());
        }
    }
}
