using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using SaintSender.Model;
using System.Threading;
using MailKit;
using System.Windows.Forms;

namespace SaintSender.Control
{
    class SaintClient : IClient
    {
        public static IClient INSTANCE { get; } = new SaintClient();
        private IConnection connection;
        private IReceiver reciever;
        private ISender sender;
        private ISerializer serializer;


        private SaintClient()
        {
            serializer = new Serializer();
        }

        public MimeMessage[] DownloadMails()
        {
            return reciever.DownloadMails();
        }

        public void Connect(ConnectionInfo imapInfo, ConnectionInfo smtpInfo)
        {
            connection = new MessageConnection(imapInfo, smtpInfo);
            reciever = new MessageReceiver(connection.ReceiverClient);
            sender = new MessageSender(connection.SenderClient);
            try
            {
                connection.Connect();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public void SendMail(MimeMessage message)
        {
            sender.SendMail(message);
        }

        public void BackupMails()
        {
            serializer.Save(reciever.Mails, Properties.Settings.Default.BackupFolder);
        }

        public void RestoreMails()
        {
            serializer.Restore(Properties.Settings.Default.BackupFolder);
        }

        public void Login(string userName, string password)
        {
            try
            {
                connection.Login(userName, password);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }
    }
}
