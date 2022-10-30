using E_Commerce.IdentityService.Application.Abstractions.Repositories;
using E_Commerce.IdentityService.Application.Abstractions.Services.AuthService;
using E_Commerce.IdentityService.Application.Abstractions.Services.Jwt;
using E_Commerce.IdentityService.Application.Abstractions.Services.Jwt.Hashing;
using E_Commerce.IdentityService.Application.Features.Auths.Dtos;
using E_Commerce.IdentityService.Domain.Entities;

namespace E_Commerce.IdentityService.Persistence.Concretes.Services
{
    public class AuthService : IAuthService
    {
        private readonly ITokenHelper _tokenHandler;
        private readonly IUserRepository _userRepository;

        public AuthService(ITokenHelper tokenHandler, IUserRepository userRepository)
        {
            _tokenHandler = tokenHandler;
            _userRepository = userRepository;
        }

        public async Task<AccessToken> Login(LoginUserDto loginUserDto)
        {
            User? user = await _userRepository.GetAsync(x => x.Email == loginUserDto.UserNameOrEmail);
            if (user is not null)
            {
                HashingHelper.VerifyPasswordHash(loginUserDto.Password, user.PasswordHash, user.PasswordSalt);
                return _tokenHandler.CreateToken(user!);
            }
            throw new Exception("User Not Found");
        }

        public async Task Register(RegisterDto registerDto)
        {
            HashingHelper.CreatePasswordHash(registerDto.Password, out byte[] passwordHash, out byte[] passwordSalt);
            User user = new()
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Email = registerDto.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                IsMailConfirmed = false
            };
            await _userRepository.AddAsync(user);
        }
    }
}
