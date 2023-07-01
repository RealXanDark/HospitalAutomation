using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace desing
{
    public static class SendMail
    {
        public static void Microsoft(string recipientEmail)
        {
            int verificationCode = new Random().Next(100000, 999999);
            Global.verificationCode = verificationCode.ToString();
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("hanhastaneleri@hotmail.com", "hanhasthan123");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("hanhastaneleri@hotmail.com", "HAN HASTANELERİ");
            mail.To.Add(recipientEmail);
            mail.Subject = "ŞİFRE SIFIRLAMA";
            mail.IsBodyHtml = true;
            mail.Body = "DOĞRULAMA KODUNUZ: " + verificationCode.ToString();
            sc.Timeout = 10000;
            sc.Send(mail);
        }
    }
}
