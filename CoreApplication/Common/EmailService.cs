﻿using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace RealEstate
{
    public class EmailService : IEmailService
    {
        private IConfiguration Configuration { get; }
        public EmailService(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public bool SendEmail(IdentityMessage message)
        {
            DeliverAsync(message.Destination, message.Subject, message.Body);
            return true;
        }

        private void DeliverAsync(string destination, string subject, string body, bool htmlFormat = true)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient(Configuration.GetSection("EmailSettings").GetSection("Host").Value);

            mail.From = new MailAddress(Configuration.GetSection("EmailSettings").GetSection("Address").Value);
            mail.To.Add(destination);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = htmlFormat;

            smtpServer.Port = 587;
            smtpServer.EnableSsl = true;
            smtpServer.Credentials = new NetworkCredential(Configuration.GetSection("EmailSettings").GetSection("Username").Value, Configuration.GetSection("EmailSettings").GetSection("Password").Value);
            smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtpServer.Send(mail);
            Task.FromResult(0);
        }
    }
}