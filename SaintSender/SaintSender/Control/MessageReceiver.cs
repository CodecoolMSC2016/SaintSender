using MailKit;
using MailKit.Net.Imap;
using MimeKit;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender.Control
{
    internal class MessageReceiver : IReceiver
    {
        private ImapClient client;
        public MimeMessage[] Mails { get; private set; }

        public MessageReceiver(ImapClient client)
        {
            this.client = client;
        }

        public MimeMessage[] DownloadMails()
        {
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            Mails = new MimeMessage[inbox.Count];
            Parallel.For(0, inbox.Count, 
                (i) => Mails[i] = inbox.GetMessageAsync(i).Result);
            return Mails;
        }



    }
}