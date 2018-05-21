using System;
using System.Net;
using System.Net.Mail;

namespace MyEmailer
{
    /// <summary>
    /// Respoinsibel for sending emails.
    /// </summary>
    public class SendEmail
    {
        public virtual void Send(MailMessageOptions options, SmtpClientConfigurations configurations)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(options.From);
                    mail.Subject = options.Subject;
                    mail.Body = options.Body;
                    mail.IsBodyHtml = configurations.IsBodyHtml;
                    foreach (var toEmail in options.To)
                    {
                        mail.To.Add(toEmail);
                    }

                    using (SmtpClient smtp = new SmtpClient(configurations.SmtpAddress, configurations.PortNumber))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(options.From, options.Password);
                        smtp.EnableSsl = true;

                        try
                        {
                            smtp.Send(mail);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
