using MimeKit;
using SaintSender.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender.Control
{
    /// <summary>
    /// Converts between [Serializable] Mail and MimeMessage
    /// </summary>
    class MessageConverter
    {
        Mail ToMail(MimeMessage message)
        {
            string from = message.From.ToString();
            string to = message.To.ToString();
            DateTime date = message.Date.Date;
            string subject = message.Subject;
            string body = message.TextBody;
            string cc = message.Cc.ToString();
            string bcc = message.Bcc.ToString();
            Mail mail = new Mail(from, to, date, subject, body, cc, bcc);
            return mail;
        }
        MimeMessage ToMimeMessage(Mail mail)
        {
            // TODO: implement Mail to MimeMessage
            MimeMessage message = new MimeMessage();
            message
            return null;
        }
    }
}
