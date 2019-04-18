using System.Net.Mail;

namespace Todo02.Infrastructure.Services
{
    public class EmailService
    {
        public static void Send(string address, string message)
        {
            var smtp = new SmtpClient("smtp.libero.it")
            {
                Credentials = new System.Net.NetworkCredential("leesposi@libero.it", "7Settimane")
            };

            var mail = new MailMessage { From = new MailAddress("leesposi@libero.it", "TODO-02") };
            mail.To.Add(new MailAddress(address));
            mail.Subject = "TODO-02";
            mail.Body = message;

            smtp.Send(mail);
        }
    }
}