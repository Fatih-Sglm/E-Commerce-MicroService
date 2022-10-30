using E_Commerce.IdentityService.Application.Features.Auths.Dtos;
using E_Commerce.IdentityService.Domain.Entities;

namespace E_Commerce.IdentityService.Application.Abstractions.Services.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user);

        RefreshToken CreateRefreshToken(User user, string ipAddress, int refresftokenDay);
    }
}
