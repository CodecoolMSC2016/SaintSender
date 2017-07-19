using MailKit;
using MailKit.Net.Imap;
using MimeKit;

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

            for (int i = 0; i < inbox.Count; i++)
            {
                Mails[i] = inbox.GetMessage(i);
            }

            return Mails;
        }
    }
}