using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.D_dip
{
    // Yomon dizayn: EmailService qattiq bog'langan SMTPClient'ga bog'liq
    public class EmailService
    {
        private SmtpClient _smtpClient;

        public EmailService()
        {
            _smtpClient = new SmtpClient();
        }

        public void SendEmail(string to, string subject, string body)
        {
            // Email yuborish jarayoni
        }
    }

    // Yaxshi dizayn: EmailService umumiy interfeysga bog'liq, konkret implementatsiyaga emas
    public interface IEmailClient
    {
        void SendEmail(string to, string subject, string body);
    }

    public class SmtpClient : IEmailClient
    {
        public void SendEmail(string to, string subject, string body)
        {
            // SMTP orqali email yuborish
        }
    }

    public class EmailService
    {
        private readonly IEmailClient _emailClient;

        public EmailService(IEmailClient emailClient)
        {
            _emailClient = emailClient;
        }

        public void SendEmail(string to, string subject, string body)
        {
            _emailClient.SendEmail(to, subject, body);
        }
    }

}
