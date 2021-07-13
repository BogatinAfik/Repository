using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace KallkarProject
{
    class SendEmail
    {
        public void sendEmail(string head, string body, string eMail)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("KalKarFactory@gmail.com");
                mail.To.Add(eMail);
                mail.Subject = head;
                mail.Body = body;
                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("KalKarFactory", "kalkar123");
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);
                MessageBox.Show("The email was successfully sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
