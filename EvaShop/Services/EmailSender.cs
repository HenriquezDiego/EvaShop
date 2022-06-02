using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using System.Text;
using EvaShop.Models.Utils;

namespace EvaShop.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailConfigure _configuration;
        public EmailSender(IOptions<EmailConfigure> options)
        {
            _configuration = options.Value;
        }

        public EmailSender(string user, string password)
        {
            _configuration = new EmailConfigure
            {
                User = user,
                Password = password
            };
        }

        public bool Notify(string message,string to,string subject="")
        {
            var user = _configuration.User;
            var password = _configuration.Password;

            var eMailMessage = new MailMessage
            {
                From = new MailAddress(user, "Notificacion Eva Shop", Encoding.UTF8),
                Subject = string.IsNullOrEmpty(subject) ? "Compra" : subject,
                Body = message,
                IsBodyHtml = true,
                Priority = MailPriority.Normal
            };

            eMailMessage.To.Add(to);

            var smtp = new SmtpClient
            {
                UseDefaultCredentials = false,
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential(user, password)
            };

            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(eMailMessage);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public string GetEmail()
        {
            return _configuration.User;
        }
    }
}
