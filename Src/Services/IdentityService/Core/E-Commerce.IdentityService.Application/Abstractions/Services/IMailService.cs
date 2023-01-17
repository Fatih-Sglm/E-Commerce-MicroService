using E_Commerce.IdentityService.Application.Models.MailModels;

namespace E_Commerce.IdentityService.Application.Abstractions.Services
{
    public interface IMailService : IQueueService<Mail>
    {
        //Task<bool> SendMailAsync(Mail mail);
    }
}
