using AutoMapper;
using E_Commerce.IdentityService.Application.Abstractions.Services;
using E_Commerce.IdentityService.Application.Exceptions;
using E_Commerce.IdentityService.Application.Features.AppUsers.Command.CreateUser;
using E_Commerce.IdentityService.Application.Features.AppUsers.Command.ResetPassword;
using E_Commerce.IdentityService.Application.Features.AppUsers.Command.UpdateUserPassword;
using E_Commerce.IdentityService.Application.Features.Auths.Rules;
using E_Commerce.IdentityService.Application.Helper;
using E_Commerce.IdentityService.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Text.Json;

namespace E_Commerce.IdentityService.Persistence.Concretes.Services
{
    public class AppUserService : IAppUserService
    {
        private readonly IMailService _mailService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IVeriyService _veriyService;

        public AppUserService(IMailService mailService, UserManager<AppUser> userManager, IConfiguration configuration, IMapper mapper, IVeriyService veriyService)
        {
            _mailService = mailService;
            _userManager = userManager;
            _configuration = configuration;
            _mapper = mapper;
            _veriyService = veriyService;
        }


        public async Task CreateUser(CreateUserCommand request)
        {
            AppUser appUser = _mapper.Map<AppUser>(request);
            IdentityResult result = await _userManager.CreateAsync(appUser, request.Password);
            if (!result.Succeeded) { throw new IdentityException(JsonSerializer.Serialize(result.Errors)); }
            await CreateConfirmUserEmailMessageAsync(appUser);
        }

        public async Task<bool> ResetPassword(ResetPasswordCommand command)
        {
            AppUser? appUser = await _userManager.FindByEmailAsync(command.Email);
            appUser.CheckUserIsNull();

            string resetToken = await _userManager.GeneratePasswordResetTokenAsync(appUser);

            string message = SystemMailMessages.ResetPasswordMailMessageAsync
                  (_configuration, "reset-password", appUser.FullName, appUser.Id.ToString(), resetToken.UrlEncode());

            return await _mailService.SendMailAsync(new()
            {
                IsHtml = true,
                Subject = "Reset Password",
                TextBody = message,
                ToEmail = appUser.Email,
                ToFullName = appUser.FullName,
            });
        }

        public async Task UpdadePassword(UpdateUserPassworResetCommand command)
        {
            if (!command.Password.Equals(command.ConfirmPassword))
                throw new IdentityException("");

            AppUser? appUser = await _userManager.FindByIdAsync(command.UserId);
            appUser?.CheckUserIsNull();
            var result = await _veriyService.VerifyResetPassword(new() { Token = command.ResetToken, UserId = command.UserId });

            IdentityResult identityResult = await _userManager.ResetPasswordAsync(appUser, result, command.Password);
            if (!identityResult.Succeeded)
                throw new IdentityException("");
            await _userManager.UpdateSecurityStampAsync(appUser);
        }



        private async Task CreateConfirmUserEmailMessageAsync(AppUser appUser)
        {
            await appUser!.CheckUserIsNull();
            string resetToken = await _userManager.GenerateEmailConfirmationTokenAsync(appUser);

            byte[] tokenBytes = Encoding.UTF8.GetBytes(resetToken);
            resetToken = WebEncoders.Base64UrlEncode(tokenBytes);
            string message = SystemMailMessages.ConfirmMailMessageAsync(_configuration, "/Confirm-Email", $"{appUser.FirstName} + {appUser.LastName}",
                appUser.Id.ToString(), resetToken);

            await _mailService.SendMailAsync(new()
            {
                IsHtml = true,
                Subject = "Confirm Email",
                TextBody = message,
                ToEmail = appUser.Email,
                ToFullName = appUser.FullName,
            });
        }

    }
}
