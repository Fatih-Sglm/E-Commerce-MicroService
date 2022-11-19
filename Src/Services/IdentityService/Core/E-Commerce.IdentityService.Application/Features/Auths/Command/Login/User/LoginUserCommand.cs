using E_Commerce.IdentityService.Application.Abstractions.Services.AuthService;
using E_Commerce.IdentityService.Application.Features.Auths.Dtos;
using MediatR;

namespace E_Commerce.IdentityService.Application.Features.Auths.Command.Login.User
{
    public class LoginUserCommand : IRequest<AccessToken>
    {
        public required string UserNameOrEmail { get; set; }
        public required string Password { get; set; }


        public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, AccessToken>
        {
            private readonly IAuthService _authService;

            public LoginUserCommandHandler(IAuthService authService)
            {
                _authService = authService;
            }

            public async Task<AccessToken> Handle(LoginUserCommand request, CancellationToken cancellationToken)
            {
                return await _authService.Login(new() { Password = request.Password, UserNameOrEmail = request.UserNameOrEmail });
            }
        }
    }
}
