using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Shop.Sender
{
    public class MessageSender : IEmailSender
    {
        public void SendEmail(string to, string subject, string body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("bordbarabbas21@gmail.com", "Digikala Info");
            mail.To.Add(to);
            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = body;



            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("bordbarabbas21@gmail.com", "010203bord");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
