using E_Commerce.IdentityService.Application.Abstractions.Services;
using E_Commerce.IdentityService.Application.Abstractions.Services.AuthService;
using E_Commerce.IdentityService.Application.Abstractions.Services.Jwt;
using E_Commerce.IdentityService.Application.Features.Auths.Command.Login.User;
using E_Commerce.IdentityService.Application.Features.Auths.Command.Register;
using E_Commerce.IdentityService.Application.Features.Auths.Constant;
using E_Commerce.IdentityService.Application.Features.Auths.Dtos;
using E_Commerce.IdentityService.Application.Features.Auths.Rules;
using E_Commerce.IdentityService.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace E_Commerce.IdentityService.Persistence.Concretes.Services
{
    public class AuthService : IAuthService
    {

        private readonly ITokenHelper _tokenHandler;
        private readonly UserManager<AppUser> _userManager;
        private readonly IRefreshTokenService _refreshTokenService;
        private readonly IAppUserService _appUserService;
        //private readonly AuthBusinnesRules _authBusinnesRules;

        public AuthService(ITokenHelper tokenHandler,
            UserManager<AppUser> userManager,
            IRefreshTokenService refreshTokenService)
        {
            _tokenHandler = tokenHandler;
            _userManager = userManager;
            _refreshTokenService = refreshTokenService;
        }
        public async Task<LoginResponseDto> LoginAsync(LoginUserCommand command)
        {
            AppUser? user = await _userManager.FindByEmailAsync(command.UserNameOrEmail);
            user ??= await _userManager.FindByNameAsync(command.UserNameOrEmail);
            // Created extension method for those functions
            await user.CheckUserIsNull();
            await _userManager.CheckUserPassword(user, command.Password);
            await _userManager.CheckEmailConfimed(user);
            //await AuthBusinnesRules.CheckUserIsNull(user!);
            //await AuthBusinnesRules.CheckEmailConfimed(_userManager, user);
            //await AuthBusinnesRules.CheckUserPassword(_userManager, user, loginUserDto.Password);
            return await GenerateAccesToken(user);
        }

        private async Task<LoginResponseDto> GenerateAccesToken(AppUser user)
        {
            AccessToken accessToken = _tokenHandler.CreateToken(user!, await _userManager.GetRolesAsync(user));
            string refreshtoken = _tokenHandler.CreateRefreshToken();
            await _refreshTokenService.InsertRefreshToken(user, refreshtoken, accessToken.Expiration.AddDays(1));

            return new()
            {
                Token = accessToken.Token,
                RefreshToken = refreshtoken,
                Expiration = accessToken.Expiration,
            };
        }

        public async Task<LoginResponseDto> RefreshTokenLoginAsync(string refreshToken)
        {
            var userRefreshToken = await _refreshTokenService.GetRefreshTokenByToken(refreshToken);
            if (userRefreshToken is null)
                return null;

            return await GenerateAccesToken(userRefreshToken.User);
        }

        public Task<LoginResponseDto> FacebookLoginAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponseDto> GoogleLoginAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> Register(RegisterUserCommand command)
        {
            await _appUserService.CreateUser(new()
            {
                Email = command.Email,
                FirstName = command.FirstName,
                LastName = command.LastName,
                Password = command.Password,
                UserName = command.UserName,
            });

            return AuthConstantMessage.WelcomeMessage;
        }
    }
}
