using MailKit;
using MailKit.Net.Imap;
using MimeKit;

namespace SaintSender.Control
{
    internal class MessageReceiver : IReceiver
    {
        private ImapClient client;

        public MessageReceiver(ImapClient client)
        {
            this.client = client;
        }

        public MimeMessage[] DownloadMails()
        {
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            MimeMessage[] mails = new MimeMessage[inbox.Count];

            for (int i = 0; i < inbox.Count; i++)
            {
                mails[i] = inbox.GetMessage(i);
            }

            return mails;
        }
    }
}