using E_Commerce.IdentityService.Application.Models.MailModels;

namespace E_Commerce.IdentityService.Application.Abstractions.Services
{
    public interface IMailService
    {
        Task<bool> SendMailAsync(Mail mail);
    }
}
