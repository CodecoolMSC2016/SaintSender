using MimeKit;
using SaintSender.Model;
using System;
using System.Windows.Forms;

namespace SaintSender.Control
{
    internal class SaintClient : IClient
    {
        private IReceiver reciever;
        private ISender sender;
        private ISerializer serializer;
        private ConnectionInfo imapInfo;
        private ConnectionInfo smtpInfo;
        private string userName;
        private string password;

        public SaintClient(
            ConnectionInfo imapInfo,
            ConnectionInfo smtpInfo,
            string userName,
            string password)
        {
            this.userName = userName;
            this.password = password;
            this.imapInfo = imapInfo;
            this.smtpInfo = smtpInfo;
            serializer = new Serializer();
        }

        public MimeMessage[] DownloadMails()
        {
            using (var connection = new MessageConnection(imapInfo, smtpInfo))
            {
                connection.Login(userName,password);
                reciever = new MessageReceiver(connection.ReceiverClient);
                return reciever.DownloadMails();
            }
        }

        public void SendMail(MimeMessage message)
        {
            using (var connection = new MessageConnection(imapInfo, smtpInfo))
            {
                connection.Login(userName, password);
                sender = new MessageSender(connection.SenderClient);
                sender.SendMail(message);
            }
        }

        public void BackupMails()
        {
            serializer.Save(reciever.Mails, Properties.Settings.Default.BackupFolder);
        }

        public void RestoreMails()
        {
            serializer.Restore(Properties.Settings.Default.BackupFolder);
        }
    }
}