using E_Commerce.IdentityService.Application.Exceptions;
using E_Commerce.IdentityService.Application.Features.Auths.Constant;
using E_Commerce.IdentityService.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace E_Commerce.IdentityService.Application.Features.Auths.Rules
{
    public static class AuthBusinnesRules
    {
        public static Task CheckUserIsNull(this AppUser appUser)
        {
            return appUser is null ? throw new NotFoundException(AuthConstantMessage.ErrorMessage) : Task.CompletedTask;
        }

        public static async Task CheckUserPassword(this SignInManager<AppUser> signInManager, AppUser appUser, string password)
        {
            var result = await signInManager.CheckPasswordSignInAsync(appUser, password, true);
            if (!result.Succeeded)
            {
                throw new IdentityException(AuthConstantMessage.ErrorMessage);
            }
        }

        public static async Task CheckEmailConfimed(this UserManager<AppUser> userManager, AppUser appUser)
        {
            if (!await userManager.IsEmailConfirmedAsync(appUser))
            {
                throw new IdentityException(AuthConstantMessage.ErrorMessage);
            }
        }




    }
}
