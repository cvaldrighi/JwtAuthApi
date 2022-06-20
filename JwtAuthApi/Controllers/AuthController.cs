using JwtAuthApi.Data;
using JwtAuthApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register(UserDto request)
        {
            var user = _authService.Register(request).Result.Value;

            return Ok(user);
        }

        [HttpPost("Login")]
        public IActionResult Login(UserDto request)
        {
            var login = _authService.Login(request).Result.Value;

            return Ok(login);
        }
    }
}
