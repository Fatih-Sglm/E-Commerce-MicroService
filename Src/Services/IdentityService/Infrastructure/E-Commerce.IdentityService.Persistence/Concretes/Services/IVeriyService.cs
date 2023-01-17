using E_Commerce.IdentityService.Application.Abstractions.Services;
using E_Commerce.IdentityService.Application.Exceptions;
using E_Commerce.IdentityService.Application.Features.AppUsers.Command.VerifyResetPassword;
using E_Commerce.IdentityService.Application.Features.AppUsers.Command.VeriyfyEmail;
using E_Commerce.IdentityService.Application.Features.Auths.Rules;
using E_Commerce.IdentityService.Application.Helper;
using E_Commerce.IdentityService.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace E_Commerce.IdentityService.Persistence.Concretes.Services
{
    public class VeriyService : IVeriyService
    {
        private readonly UserManager<AppUser> _userManager;

        public VeriyService(UserManager<AppUser> usermanager)
        {
            _userManager = usermanager;
        }

        public async Task VerifyEmalAdress(VerifyEmailCommand command)
        {
            AppUser? appUser = await _userManager.FindByIdAsync(command.UserId);
            appUser?.CheckUserIsNull();

            var result = await _userManager.VerifyIdentityToken(appUser, command.Token, VerifyTokenOption.EmailConfirmed);
            if (!result.Item1)
                throw new IdentityException("Lütfen Geçerli bir Url Kullanınız");
            appUser.EmailConfirmed = true;
            await _userManager.UpdateAsync(appUser);
            await _userManager.UpdateSecurityStampAsync(appUser);

        }

        public async Task<string> VerifyResetPassword(VerifyResetPasswordCommand command)
        {
            AppUser? appUser = await _userManager.FindByIdAsync(command.UserId);
            appUser?.CheckUserIsNull();
            var result = await _userManager.VerifyIdentityToken(appUser, command.Token, VerifyTokenOption.ResetPassword);
            if (!result.Item1)
                throw new IdentityException("Lütfen Geçerli bir Url Kullanınız");

            return result.Item2;
        }
    }
}
