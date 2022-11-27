using E_Commerce.IdentityService.Application.Abstractions.Services.AuthService;
using E_Commerce.IdentityService.Application.Features.Auths.Dtos;
using E_Commerce.IdentityService.Application.Features.Common;
using MediatR;

namespace E_Commerce.IdentityService.Application.Features.Auths.Command.Login.RefreshTokenLogin
{
    public class RefreshTokenLoginCommand : IRequest<ResponseDto<LoginResponseDto>>
    {
        public string RefreshToken { get; set; }

        public class RefreshTokenLoginCommandHadnler : IRequestHandler<RefreshTokenLoginCommand, ResponseDto<LoginResponseDto>>
        {
            private readonly IAuthService _authService;

            public RefreshTokenLoginCommandHadnler(IAuthService authService)
            {
                _authService = authService;
            }

            public async Task<ResponseDto<LoginResponseDto>> Handle(RefreshTokenLoginCommand request, CancellationToken cancellationToken)
            {
                var value = await _authService.RefreshTokenLoginAsync(request.RefreshToken);
                return ResponseDto<LoginResponseDto>.SuccesWithData(value);
            }
        }
    }
}
