using E_Commerce.BasketService.Application.Abstractions.Services;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace E_Commerce.BasketService.Infrastructure.Concrete.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IdentityService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public Task<string> GetUserName()
        {
            return Task.FromResult(_httpContextAccessor.HttpContext.User.FindFirst(x => x.Type == ClaimTypes.GivenName)!.Value);
        }
    }
}
