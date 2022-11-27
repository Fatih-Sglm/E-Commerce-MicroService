using E_Commerce.IdentityService.Application.Abstractions.Services;
using E_Commerce.IdentityService.Application.Models.MailModels;

namespace E_Commerce.IdentityService.Infrastructure.Concretes.Services
{
    public class MailService : QueueService<Mail>, IMailService
    {

    }
}
