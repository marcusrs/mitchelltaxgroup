using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit;

namespace mitchelltaxgroup.Services
{
    public class Mailer : IMailer
    {
        public bool SendMail(string FromName, string email, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress( FromName, email));
            emailMessage.To.Add(new MailboxAddress("Marcus Shipman", "marcusshipman@yahoo.com"));
            emailMessage.Subject = "Email from ";
            emailMessage.Body = new TextPart("plain") { Text = "message" };

            using (var client = new SmtpClient())
            {
                client.LocalDomain = "some.domain.com";
                client.Connect("smtp.relay.uri", 25, SecureSocketOptions.None);
                client.Send(emailMessage);
                client.Disconnect(true);

                return true;
            }
        }
    }
}
