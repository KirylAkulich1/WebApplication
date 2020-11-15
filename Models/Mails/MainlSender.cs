using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models.Mails
{
    public class MainlSender
    {
        private MimeMessage CreateMimeMessageFromEmailMessage(EmailMessage message)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(message.Sender);
            mimeMessage.To.Add(message.Reciever);
            mimeMessage.Subject = message.Subject;
            mimeMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text)
            { Text = message.Content };
            return mimeMessage;
        }
       /* public string Get()
        {
            EmailMessage message = new EmailMessage();
            message.Sender = new MailboxAddress("Self", _notificationMetadata.Sender);
            message.Reciever = new MailboxAddress("Self", _notificationMetadata.Reciever);
            message.Subject = "Welcome";
            message.Content = "Hello World!";
            var mimeMessage = CreateMimeMessageFromEmailMessage(message);
            using (SmtpClient smtpClient = new SmtpClient())
            {
                //                smtpClient.SslProtocols = SslProtocols.Ssl3 | SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12 | SslProtocols.Tls13;

                smtpClient.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                smtpClient.Authenticate(_notificationMetadata.UserName,
                _notificationMetadata.Password);
                smtpClient.Send(mimeMessage);
                smtpClient.Disconnect(true);
            }
            return "Email sent successfully";
        }*/
    }
}
