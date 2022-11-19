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

        public string GetUserId()
        {
            return _httpContextAccessor.HttpContext.User.FindFirst(x => x.Type == ClaimTypes.NameIdentifier)!.Value;
        }

        public string GetUserName()
        {
            return _httpContextAccessor.HttpContext.User.FindFirst(x => x.Type == ClaimTypes.Name)!.Value;
        }
    }
}
