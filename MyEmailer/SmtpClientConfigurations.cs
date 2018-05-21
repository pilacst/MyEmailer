using System.Net.Mail;

namespace MyEmailer
{
    /// <summary>
    /// Configuration model.
    /// </summary>
    public class SmtpClientConfigurations
    {
        /// <summary>
        /// Gets or sets the SMTP server addres.
        /// </summary>
        public string SmtpAddress { get; set; }

        /// <summary>
        /// Gets or sets the SMTP server port.
        /// </summary>
        public int PortNumber { get; set; }

        /// <summary>
        /// Gets or sets the email template path.
        /// </summary>
        public string TemplateFolder { get; set; }

        /// <summary>
        /// Gets or sets UseDefaultCredentials option.
        /// </summary>
        public bool UseDefaultCredentials { get; set; }

        /// <summary>
        /// Gets or sets DeliveryMethod option.
        /// </summary>
        public SmtpDeliveryMethod DeliveryMethod { get; set; }

        /// <summary>
        /// Gets or sets Credentials option.
        /// </summary>
        public SmtpDeliveryMethod Credentials { get; set; }

        /// <summary>
        /// Gets or sets EnableSsl option.
        /// </summary>
        public SmtpDeliveryMethod EnableSsl { get; set; }

        /// <summary>
        /// Gets or sets if the message body is HTML.
        /// </summary>
        public bool IsBodyHtml { get; set; }
    }
}
