using E_Commerce.IdentityService.Application.Features.Auths.Dtos;

namespace E_Commerce.IdentityService.Application.Abstractions.Services.AuthService
{
    public interface IAuthService
    {
        Task<AccessToken> Login(LoginUserDto loginUserDto);
        Task<string> Register(RegisterDto registerDto);
        Task<bool> RegisterAdmin(RegisterDto registerDto);
    }
}
