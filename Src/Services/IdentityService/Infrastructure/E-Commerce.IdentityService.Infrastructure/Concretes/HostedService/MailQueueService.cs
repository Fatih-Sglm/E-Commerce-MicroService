using E_Commerce.IdentityService.Application.Abstractions.Services;
using E_Commerce.IdentityService.Application.Models.MailModels;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using MimeKit;

namespace E_Commerce.IdentityService.Infrastructure.Concretes.HostedService
{
    public class MailQueueService : BackgroundService
    {
        private readonly IMailService _mailService;
        private readonly MailOptions _mailOptions;
        public MailQueueService(IMailService mailService, IConfiguration configuration)
        {
            _mailService = mailService;
            _mailOptions = configuration.GetSection("MailOptions").Get<MailOptions>();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Mail mail = await _mailService.DeQueue(stoppingToken);
                try
                {
                    MimeMessage email = new();

                    email.From.Add(new MailboxAddress(_mailOptions.SenderFullName, _mailOptions.SenderEmail));

                    email.To.Add(new MailboxAddress(mail.ToFullName, mail.ToEmail));

                    email.Subject = mail.Subject;
                    BodyBuilder bodyBuilder = new();

                    if (mail.IsHtml)
                        bodyBuilder.HtmlBody = mail.TextBody;
                    else
                        bodyBuilder.TextBody = mail.TextBody;

                    if (mail.Attachments != null)
                        foreach (MimeEntity? attachment in mail.Attachments)
                            bodyBuilder.Attachments.Add(attachment);

                    email.Body = bodyBuilder.ToMessageBody();

                    using SmtpClient smtp = new();
                    await smtp.ConnectAsync(_mailOptions.Server, _mailOptions.Port, cancellationToken: stoppingToken);
                    await smtp.AuthenticateAsync(_mailOptions.SenderEmail, _mailOptions.Password, stoppingToken);
                    await smtp.SendAsync(email);
                    await smtp.DisconnectAsync(true, stoppingToken);
                }
                catch (Exception)
                {
                    throw new Exception("");
                }
            }

        }
    }
}
