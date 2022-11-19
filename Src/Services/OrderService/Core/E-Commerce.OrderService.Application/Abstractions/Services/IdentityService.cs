namespace E_Commerce.OrderService.Application.Abstractions.Services
{
    public interface IIdentityService
    {
        Task<(string FullName, string Email)> GetUserInfos(string userName);
    }
}
