﻿using E_Commerce.IdentityService.Application.Abstractions.Services;
using E_Commerce.IdentityService.Application.Models.MailModels;
using E_Commerce.IdentityService.Infrastructure.Concretes.Services;

namespace E_Commerce.IdentityService.Infrastructure.Services
{
    public class MailService : QueueService<Mail>, IMailService
    {
        //private readonly MailOptions _mailOptions;

        //public MailService(IConfiguration configuration)
        //{
        //    _mailOptions = configuration.GetSection("MailOptions").Get<MailOptions>();
        //}
        //public async Task<bool> SendMailAsync(Mail mail)
        //{
        //    try
        //    {
        //        MimeMessage email = new();

        //        email.From.Add(new MailboxAddress(_mailOptions.SenderFullName, _mailOptions.SenderEmail));

        //        email.To.Add(new MailboxAddress(mail.ToFullName, mail.ToEmail));

        //        email.Subject = mail.Subject;
        //        BodyBuilder bodyBuilder = new();

        //        if (mail.IsHtml)
        //            bodyBuilder.HtmlBody = mail.TextBody;
        //        else
        //            bodyBuilder.TextBody = mail.TextBody;

        //        if (mail.Attachments != null)
        //            foreach (MimeEntity? attachment in mail.Attachments)
        //                bodyBuilder.Attachments.Add(attachment);

        //        email.Body = bodyBuilder.ToMessageBody();

        //        using SmtpClient smtp = new();
        //        await smtp.ConnectAsync(_mailOptions.Server, _mailOptions.Port);
        //        await smtp.AuthenticateAsync(_mailOptions.SenderEmail, _mailOptions.Password);
        //        await smtp.SendAsync(email);
        //        await smtp.DisconnectAsync(true);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
    }
}