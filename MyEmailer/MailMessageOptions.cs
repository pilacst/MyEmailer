using System.Collections.Generic;
using System.Net.Mail;

namespace MyEmailer
{

    /// <summary>
    /// Email options.
    /// </summary>
    public class MailMessageOptions
    {
        /// <summary>
        /// Gets or set the From email.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Gets or sets the password of the from email.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the Subject of the email.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the body of the email(Message content).
        /// You can formate the content and pass it to the property.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets all the recipients of the email.
        /// </summary>
        public IList<string> To { get; set; }
    }
}
