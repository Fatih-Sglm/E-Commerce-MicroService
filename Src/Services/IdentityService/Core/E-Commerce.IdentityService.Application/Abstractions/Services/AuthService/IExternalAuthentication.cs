using E_Commerce.IdentityService.Application.Features.Auths.Dtos;

namespace E_Commerce.IdentityService.Application.Abstractions.Services.AuthService
{
    public interface IExternalAuthentication
    {

        Task<LoginResponseDto> GoogleLoginAsync();
        Task<LoginResponseDto> FacebookLoginAsync();
    }
}
