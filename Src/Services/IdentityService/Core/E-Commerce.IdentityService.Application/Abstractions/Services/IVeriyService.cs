using E_Commerce.IdentityService.Application.Features.AppUsers.Command.VerifyResetPassword;
using E_Commerce.IdentityService.Application.Features.AppUsers.Command.VeriyfyEmail;

namespace E_Commerce.IdentityService.Application.Abstractions.Services
{
    public interface IVeriyService
    {
        Task VerifyEmalAdress(VerifyEmailCommand command);
        Task<string> VerifyResetPassword(VerifyResetPasswordCommand command);
    }
}
