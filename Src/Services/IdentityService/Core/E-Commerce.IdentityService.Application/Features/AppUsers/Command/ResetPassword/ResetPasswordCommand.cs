﻿using E_Commerce.IdentityService.Application.Abstractions.Services;
using E_Commerce.IdentityService.Application.Features.Auths.Constant;
using E_Commerce.IdentityService.Application.Features.Common;
using MediatR;

namespace E_Commerce.IdentityService.Application.Features.AppUsers.Command.ResetPassword
{
    public class ResetPasswordCommand : IRequest<ResponseDto<NoContent>>
    {
        public string Email { get; set; }
        public class ResetPasswordCommandHandler : IRequestHandler<ResetPasswordCommand, ResponseDto<NoContent>>
        {
            private readonly IAppUserService _appUserService;

            public ResetPasswordCommandHandler(IAppUserService appUserService)
            {
                _appUserService = appUserService;
            }

            public async Task<ResponseDto<NoContent>> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
            {

                string message = await _appUserService.ResetPassword(request) ? AuthConstantMessage.WelcomeMessage : AuthConstantMessage.ErrorMessage;
                return ResponseDto<NoContent>.SuccesWithOutData(message);
            }
        }
    }
}
