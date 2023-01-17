using E_Commerce.IdentityService.Application.Features.Auths.Command.Register;

namespace E_Commerce.IdentityService.Application.Abstractions.Services.AuthService
{
    public interface IAuthService : IExternalAuthentication, IInternalAuthentication
    {
        Task<string> Register(RegisterUserCommand command);
    }
}
