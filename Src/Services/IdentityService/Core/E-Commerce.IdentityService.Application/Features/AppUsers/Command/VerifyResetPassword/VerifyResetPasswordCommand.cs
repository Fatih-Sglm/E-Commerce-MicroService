using E_Commerce.IdentityService.Application.Abstractions.Services;
using E_Commerce.IdentityService.Application.Features.Common;
using MediatR;

namespace E_Commerce.IdentityService.Application.Features.AppUsers.Command.VerifyResetPassword
{
    public class VerifyResetPasswordCommand : IRequest<ResponseDto<NoContent>>
    {
        public string Token { get; set; }
        public string UserId { get; set; }

        public class VerifyResetPasswordCommandHandler : IRequestHandler<VerifyResetPasswordCommand, ResponseDto<NoContent>>
        {
            private readonly IVeriyService _veriyService;

            public VerifyResetPasswordCommandHandler(IVeriyService veriyService)
            {
                _veriyService = veriyService;
            }

            public async Task<ResponseDto<NoContent>> Handle(VerifyResetPasswordCommand request, CancellationToken cancellationToken)
            {
                await _veriyService.VerifyResetPassword(request);
                return ResponseDto<NoContent>.SuccesWithOutData("True");
            }

        }
    }
}
