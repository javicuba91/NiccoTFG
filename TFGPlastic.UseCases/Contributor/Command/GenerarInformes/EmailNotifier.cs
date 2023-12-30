using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TFGPlastic.UseCases.Contributor.Command.GenerarInformes
{
    internal class EmailNotifier
    {
        public void SendEmailNotification(string toEmail, string subject, string body, string attachmentPath)
        {
            SmtpClient client = new SmtpClient("smtp.example.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("tuemail@example.com", "tupassword"),
                EnableSsl = true,          
            };

            MailMessage message = new MailMessage
            {
                From = new MailAddress("tuemail@example.com"),
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };

            message.To.Add(toEmail);
            message.Attachments.Add(new Attachment(attachmentPath));

            client.Send(message);
        }
    }
}
