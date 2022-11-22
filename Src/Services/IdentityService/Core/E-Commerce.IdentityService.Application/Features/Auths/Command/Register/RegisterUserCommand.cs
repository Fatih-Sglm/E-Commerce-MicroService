using E_Commerce.IdentityService.Application.Abstractions.Services.AuthService;
using E_Commerce.IdentityService.Application.Features.Auths.Dtos;
using MediatR;

namespace E_Commerce.IdentityService.Application.Features.Auths.Command.Register
{
    public class RegisterUserCommand : IRequest<string>
    {
        public RegisterDto RegisterDto { get; set; }

        public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, string>
        {
            private readonly IAuthService _authService;

            public RegisterUserCommandHandler(IAuthService authService)
            {
                _authService = authService;
            }

            public async Task<string> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
            {
                return await _authService.Register(request.RegisterDto);
            }
        }
    }
}
