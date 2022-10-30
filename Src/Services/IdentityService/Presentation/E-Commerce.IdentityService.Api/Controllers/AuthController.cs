using E_Commerce.IdentityService.Application.Abstractions.Services.AuthService;
using E_Commerce.IdentityService.Application.Features.Auths.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.IdentityService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginUserDto loginUserDto)
        {
            return Ok(await _authService.Login(loginUserDto));
        }

        [HttpPost("Register")]
        public async Task<IActionResult> REgister(RegisterDto registerDto)
        {
            await _authService.Register(registerDto);
            return Ok();
        }
    }
}
