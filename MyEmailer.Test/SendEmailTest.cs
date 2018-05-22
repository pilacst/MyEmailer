﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyEmailer.Test
{
    [TestClass]
    public class SendEmailTest
    {
        public MailMessageOptions Options { get; set; }

        public SmtpClientConfigurations Configurations { get; set; }

        [TestInitialize]
        public void InitializeSettings()
        {
            Options = new MailMessageOptions();
            Configurations = new SmtpClientConfigurations();
            Options.From = "nayanajith.pilapitiya@gmail.com";
            Options.Password = "3139808@pila";
            Options.Subject = "Test"; //subject;
            Options.Body = "Test";
            Options.IsBodyHtml = true;
            Options.To = new List<string>();
            Options.To.Add("pilapitiyanss@gmail.com");

            Configurations.UseDefaultCredentials = false;
            Configurations.DeliveryMethod = SmtpDeliveryMethod.Network;
            Configurations.SmtpAddress = "smtp.gmail.com";
            Configurations.EnableSsl = false;
            Configurations.PortNumber = 587;
            //configurations.Credentials = new NetworkCredential("nayanajith.pilapitiya@gmail.com", "3139808@pila");
            Configurations.EnableSsl = true;

            
        }

        [TestMethod]
        public void Send_Email_with_Valid_Data()
        {
            SendEmail obj = new SendEmail();
            obj.Send(Options, Configurations);
        }
    }
}
