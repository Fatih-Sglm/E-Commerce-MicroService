using AutoMapper;
using E_Commerce.IdentityService.Application.Abstractions.Services.AuthService;
using E_Commerce.IdentityService.Application.Abstractions.Services.Jwt;
using E_Commerce.IdentityService.Application.Exceptions;
using E_Commerce.IdentityService.Application.Features.Auths.Constant;
using E_Commerce.IdentityService.Application.Features.Auths.Dtos;
using E_Commerce.IdentityService.Application.Features.Auths.Rules;
using E_Commerce.IdentityService.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;

namespace E_Commerce.IdentityService.Persistence.Concretes.Services
{
    public class AuthService : IAuthService
    {
        private readonly ITokenHelper _tokenHandler;
        private readonly UserManager<AppUser> _userManager;
        //private readonly AuthBusinnesRules _authBusinnesRules;
        private readonly IMapper _mapper;
        public AuthService(ITokenHelper tokenHandler, UserManager<AppUser> userManager, /*AuthBusinnesRules authBusinnesRules,*/ IMapper mapper)
        {
            _tokenHandler = tokenHandler;
            _userManager = userManager;
            //_authBusinnesRules = authBusinnesRules;
            _mapper = mapper;
        }

        public async Task<AccessToken> Login(LoginUserDto loginUserDto)
        {
            AppUser? user = await _userManager.FindByEmailAsync(loginUserDto.UserNameOrEmail);
            user ??= await _userManager.FindByNameAsync(loginUserDto.UserNameOrEmail);

            // Created extension method for those functions
            await user.CheckUserIsNull();
            await _userManager.CheckUserPassword(user, loginUserDto.Password);
            await _userManager.CheckEmailConfimed(user);
            //await AuthBusinnesRules.CheckUserIsNull(user!);
            //await AuthBusinnesRules.CheckEmailConfimed(_userManager, user);
            //await AuthBusinnesRules.CheckUserPassword(_userManager, user, loginUserDto.Password);
            return _tokenHandler.CreateToken(user!, await _userManager.GetRolesAsync(user));

        }

        public async Task<string> Register(RegisterDto registerDto)
        {
            AppUser appUser = _mapper.Map<AppUser>(registerDto);
            return await CreateUser(appUser, registerDto.Password);

        }

        public async Task<bool> RegisterAdmin(RegisterDto registerDto)
        {
            AppUser appUser = _mapper.Map<AppUser>(registerDto);
            await _userManager.AddToRoleAsync(appUser, "Admin");
            await CreateUser(appUser, registerDto.Password);
            return true;
        }

        private async Task<string> CreateUser(AppUser appUser, string password)
        {
            IdentityResult result = await _userManager.CreateAsync(appUser, password);
            if (!result.Succeeded) { throw new IdentityException(JsonSerializer.Serialize(result.Errors)); }
            return AuthConstantMessage.WelcomeMessage;
        }
    }
}
