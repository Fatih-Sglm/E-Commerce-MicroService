using E_Commerce.IdentityService.Application.Features.Auths.Constant;
using E_Commerce.IdentityService.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace E_Commerce.IdentityService.Application.Features.Auths.Rules
{
    public static class AuthBusinnesRules
    {
        public static Task CheckUserIsNull(this AppUser appUser)
        {
            return appUser is null ? throw new ArgumentNullException(AuthConstantMessage.ErrorMessage) : Task.CompletedTask;
        }

        public static async Task CheckUserPassword(this UserManager<AppUser> userManager, AppUser appUser, string password)
        {
            if (!await userManager.CheckPasswordAsync(appUser, password))
            {
                throw new Exception(AuthConstantMessage.ErrorMessage);
            }
        }

        public static async Task CheckEmailConfimed(this UserManager<AppUser> userManager, AppUser appUser)
        {
            if (!await userManager.IsEmailConfirmedAsync(appUser))
            {
                throw new Exception(AuthConstantMessage.ErrorMessage);
            }
        }


    }
}
