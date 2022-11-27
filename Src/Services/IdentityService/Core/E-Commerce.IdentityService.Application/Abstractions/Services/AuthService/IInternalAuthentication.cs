using E_Commerce.IdentityService.Application.Features.Auths.Command.Login.User;
using E_Commerce.IdentityService.Application.Features.Auths.Dtos;

namespace E_Commerce.IdentityService.Application.Abstractions.Services.AuthService
{
    public interface IInternalAuthentication
    {
        Task<LoginResponseDto> LoginAsync(LoginUserCommand command);
        Task<LoginResponseDto> RefreshTokenLoginAsync(string refreshToken);
    }
}
