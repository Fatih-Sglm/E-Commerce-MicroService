﻿using E_Commerce.IdentityService.Application.Abstractions.Services.AuthService;
using E_Commerce.IdentityService.Application.Features.Auths.Dtos;
using E_Commerce.IdentityService.Application.Models;
using MediatR;

namespace E_Commerce.IdentityService.Application.Features.Auths.Command.Login.User
{
    public class LoginUserCommand : IRequest<ResponseDto<LoginResponseDto>>
    {
        public required string UserNameOrEmail { get; set; }
        public required string Password { get; set; }
        public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, ResponseDto<LoginResponseDto>>
        {
            private readonly IAuthService _authService;

            public LoginUserCommandHandler(IAuthService authService)
            {
                _authService = authService;
            }

            public async Task<ResponseDto<LoginResponseDto>> Handle(LoginUserCommand request, CancellationToken cancellationToken)
            {
                var reponse = await _authService.LoginAsync(request);
                return ResponseDto<LoginResponseDto>.SuccesWithData(reponse);
            }
        }
    }
}
