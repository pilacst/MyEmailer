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
        /// <summary>
        /// Sends the email with the given configurations and optins.
        /// </summary>
        /// <param name="options">MailMessageOptions</param>
        /// <param name="configurations">SmtpClientConfigurations</param>
        public virtual void Send(MailMessageOptions options, SmtpClientConfigurations configurations)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(options.From);
                    mail.Subject = options.Subject;
                    mail.Body = options.Body;
                    mail.IsBodyHtml = options.IsBodyHtml;
                    foreach (var toEmail in options.To)
                    {
                        mail.To.Add(toEmail);
                    }

                    using (SmtpClient smtp = new SmtpClient(configurations.SmtpAddress, configurations.PortNumber))
                    {
                        smtp.UseDefaultCredentials = configurations.UseDefaultCredentials;
                        smtp.DeliveryMethod = configurations.DeliveryMethod;
                        smtp.Credentials = new NetworkCredential(options.From, options.Password);
                        smtp.EnableSsl = configurations.EnableSsl;

                        try
                        {
                            smtp.Send(mail);
                        }
                        catch (Exception ex)
                        {
                            throw;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
