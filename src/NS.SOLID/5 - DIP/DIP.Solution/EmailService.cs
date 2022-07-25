﻿using NS.SOLID.DIP.Solution.Interfaces;
using System.Net.Mail;

namespace NS.SOLID.DIP.Solution
{
    public class EmailService : IEmailService
    {
        public bool IsValid(string email)
        {
            return email.Contains("@");
        }

        public void Send(string from, string to, string subject, string body)
        {
            var mail = new MailMessage(from, to);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com",
            };

            mail.Subject = subject;
            mail.Body = body;
            client.Send(mail);
        }
    }
}
