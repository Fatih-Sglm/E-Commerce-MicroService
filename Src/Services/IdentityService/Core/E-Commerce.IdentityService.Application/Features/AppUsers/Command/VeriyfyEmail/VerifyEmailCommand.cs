using E_Commerce.IdentityService.Application.Abstractions.Services;
using E_Commerce.IdentityService.Application.Features.AppUsers.Constant;
using E_Commerce.IdentityService.Application.Features.Common;
using MediatR;

namespace E_Commerce.IdentityService.Application.Features.AppUsers.Command.VeriyfyEmail
{
    public class VerifyEmailCommand : IRequest<ResponseDto<NoContent>>
    {
        public string Token { get; set; }
        public string UserId { get; set; }
        public class VerifyEmailCommandHandler : IRequestHandler<VerifyEmailCommand, ResponseDto<NoContent>>
        {
            private readonly IVeriyService _veriyService;

            public VerifyEmailCommandHandler(IVeriyService veriyService)
            {
                _veriyService = veriyService;
            }

            public async Task<ResponseDto<NoContent>> Handle(VerifyEmailCommand request, CancellationToken cancellationToken)
            {
                await _veriyService.VerifyEmalAdress(request);
                return ResponseDto<NoContent>.SuccesWithOutData(AppUserConstant.EmailConfirmSuccesfully);
            }
        }

    }
}