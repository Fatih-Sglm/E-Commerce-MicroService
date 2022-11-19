using E_Commerce.IdentityService.Application.Features.Auths.Dtos;
using MediatR;

namespace E_Commerce.IdentityService.Application.Features.Admin.Command.CreateAdmin
{
    public class CreateAdminCommand : IRequest<bool>
    {
        public RegisterDto RegisterDto { get; set; }

        public class CreateAdminCommandHandler : IRequestHandler<CreateAdminCommand, bool>
        {
            public Task<bool> Handle(CreateAdminCommand request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
