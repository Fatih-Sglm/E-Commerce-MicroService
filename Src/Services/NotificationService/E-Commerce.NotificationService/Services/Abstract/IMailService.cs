using E_Commerce.NotificationService.MailModels;

namespace E_Commerce.NotificationService.Services.Abstract
{
    public interface IMailService
    {
        Task<bool> SendMailAsync(Mail mail);
    }
}
