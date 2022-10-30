using E_Commerce.IdentityService.Application.Abstractions.Repositories.Common;
using E_Commerce.IdentityService.Domain.Entities;

namespace E_Commerce.IdentityService.Application.Abstractions.Repositories
{
    public interface IRefreshTokenRepository : IGenericRepository<RefreshToken>
    {
    }
}
