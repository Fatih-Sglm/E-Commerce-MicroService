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
        public async Task<string> GetUserName()
        {
            return _httpContextAccessor.HttpContext.User.FindFirst(x => x.Type == ClaimTypes.GivenName)!.Value ?? "Fatih";
        }

        public async Task<(string FullName, string Email)> GetUserInfos()
        {
            string Fullname = _httpContextAccessor.HttpContext.User.FindFirst(x => x.Type == ClaimTypes.Name)!.Value;
            string Email = _httpContextAccessor.HttpContext.User.FindFirst(x => x.Type == ClaimTypes.Email)!.Value;
            return (Fullname, Email);
        }
    }
}
