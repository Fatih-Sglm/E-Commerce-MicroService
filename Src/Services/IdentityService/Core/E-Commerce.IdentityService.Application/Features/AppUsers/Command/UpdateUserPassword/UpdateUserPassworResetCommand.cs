using E_Commerce.IdentityService.Application.Abstractions.Services;
using E_Commerce.IdentityService.Application.Models;
using MediatR;

namespace E_Commerce.IdentityService.Application.Features.AppUsers.Command.UpdateUserPassword
{
    public class UpdateUserPassworResetCommand : IRequest<ResponseDto<NoContent>>
    {
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string ResetToken { get; set; }
        public string UserId { get; set; }
        public class UpdateUserPassworResetCommandHadnler : IRequestHandler<UpdateUserPassworResetCommand, ResponseDto<NoContent>>
        {
            private readonly IAppUserService _appUserService;

            public UpdateUserPassworResetCommandHadnler(IAppUserService appUserService)
            {
                _appUserService = appUserService;
            }

            public async Task<ResponseDto<NoContent>> Handle(UpdateUserPassworResetCommand request, CancellationToken cancellationToken)
            {
                await _appUserService.UpdadePassword(request);
                return ResponseDto<NoContent>.SuccesWithOutData("Şifreniz Başarılı bir şekilde Güncellendi");
            }
        }
    }
}
