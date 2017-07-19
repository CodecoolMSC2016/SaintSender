using MimeKit;
using SaintSender.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SaintSender.Control
{
    /// <summary>
    /// Converts between [Serializable] Mail and MimeMessage
    /// </summary>
    internal class MessageConverter
    {
        public Mail ToMail(MimeMessage message)
        {
            string[] from = message.From.Select(f => f.Name).ToArray();
            string[] to = message.To.Select(t => t.Name).ToArray();
            DateTime date = message.Date.Date;
            string subject = message.Subject;
            string body = message.TextBody;
            string[] cc = message.Cc.Select(c => c.Name).ToArray();
            string[] bcc = message.Bcc.Select(b => b.Name).ToArray();
            Mail mail = new Mail(from, to, date, subject, body, cc, bcc);
            return mail;
        }

        public MimeMessage ToMimeMessage(Mail mail)
        {
            // TODO: implement Mail to MimeMessage
            MimeMessage message = new MimeMessage();

            IEnumerable<InternetAddress> from = mail.From.Select(f => InternetAddress.Parse(f));
            message.From.AddRange(from);

            IEnumerable<InternetAddress> to = mail.To.Select(t => InternetAddress.Parse(t));
            message.To.AddRange(to);

            message.Date = new DateTimeOffset(mail.Date);

            message.Subject = mail.Subject;

            message.Body = new TextPart("plain") { Text = mail.Body };

            IEnumerable<InternetAddress> cc = mail.Cc.Select(c => InternetAddress.Parse(c));
            message.Cc.AddRange(cc);

            IEnumerable<InternetAddress> bcc = mail.Bcc.Select(b => InternetAddress.Parse(b));
            message.Bcc.AddRange(bcc);

            return message;
        }
    }
}