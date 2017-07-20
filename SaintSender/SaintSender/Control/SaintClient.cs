using MimeKit;
using SaintSender.Model;
using System;
using System.Windows.Forms;

namespace SaintSender.Control
{
    internal class SaintClient : IClient
    {
        public IReceiver Receiver { get; private set; }
        private ISender sender;
        private ISerializer serializer;
        public ConnectionInfo ImapInfo { get; set; }
        public ConnectionInfo SmtpInfo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int MailCount { get; private set; }

        public static IClient INSTANCE { get; } = new SaintClient();

        private SaintClient()
        {
            serializer = new Serializer();
        }

        public MimeMessage[] DownloadMails()
        {
            using (var connection = new MessageConnection(ImapInfo, SmtpInfo))
            {
                connection.Login(UserName,Password);
                Receiver = new MessageReceiver(connection.ReceiverClient);
                MimeMessage[] mails = Receiver.DownloadMails();
                MailCount = mails.Length;
                return mails;
            }
        }

        public void SendMail(MimeMessage message)
        {
            using (var connection = new MessageConnection(ImapInfo, SmtpInfo))
            {
                connection.Login(UserName, Password);
                sender = new MessageSender(connection.SenderClient);
                sender.SendMail(message);
            }
        }

        public void BackupMails()
        {
            serializer.Save(Receiver.Mails, Properties.Settings.Default.BackupFolder);
        }

        public void RestoreMails()
        {
            serializer.Restore(Properties.Settings.Default.BackupFolder);
        }
    }
}