using E_Commerce.IdentityService.Application.Features.Admin.Command.CreateAdmin;
using E_Commerce.IdentityService.Application.Features.Auths.Command.Login.User;
using E_Commerce.IdentityService.Application.Features.Auths.Command.Register;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.IdentityService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginUserCommand login)
        {
            return Ok(await _mediator.Send(login));
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterUserCommand register)
        {
            return Ok(await _mediator.Send(register));
        }

        [HttpPost("AdminRegister")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> AdminRegister(CreateAdminCommand register)
        {
            return Ok(await _mediator.Send(register));
        }
    }
}
