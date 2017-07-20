using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit;

namespace SaintSender.Control
{
    class MessageSender : ISender
    {
        private SmtpClient client;

        public MessageSender(SmtpClient client)
        {
            this.client = client;
        }

        public void SendMail(MimeMessage message)
        {
            client.Send(message);
        }       
    }
}
