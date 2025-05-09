using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace TP_Promo_Web.clases
{
    public class EmailService
    {
        private MailMessage email;
        private SmtpClient serverSMTP;

        public EmailService()
        {

            serverSMTP = new SmtpClient("smtp.mailersend.net", 587);
            serverSMTP.UseDefaultCredentials = false;
            serverSMTP.Credentials = new NetworkCredential("", "");
            serverSMTP.DeliveryMethod = SmtpDeliveryMethod.Network;
            serverSMTP.EnableSsl = true;
        }

        public void sendMail(string sendTo, string subject, string body)
        {
            email = new MailMessage();
            email.From = new MailAddress("");
            email.To.Add(sendTo);
            email.Subject = subject;
            email.IsBodyHtml = true;
            email.Body = body;
            try
            {
                serverSMTP.Send(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}