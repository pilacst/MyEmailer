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
        public string PortNumber { get; set; }

        /// <summary>
        /// Gets or sets the email template path.
        /// </summary>
        public string TemplateFolder { get; set; }

        public bool UseDefaultCredentials { get; set; }

        public SmtpDeliveryMethod DeliveryMethod { get; set; }

        public SmtpDeliveryMethod Credentials { get; set; }

        public SmtpDeliveryMethod EnableSsl { get; set; }
}
}
