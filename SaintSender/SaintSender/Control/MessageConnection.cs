using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using SaintSender.Model;
using System;

namespace SaintSender.Control
{
    internal class MessageConnection : IConnection
    {
        private ConnectionInfo imapInfo;
        private ConnectionInfo smtpInfo;

        public MessageConnection(ConnectionInfo imapInfo, ConnectionInfo smtpInfo)
        {
            receiverClient = new ImapClient();
            senderClient = new SmtpClient();
            this.imapInfo = imapInfo;
            this.smtpInfo = smtpInfo;
        }

        private ImapClient receiverClient;

        public ImapClient ReceiverClient
        {
            get { return receiverClient; }
            set { receiverClient = value; }
        }

        private SmtpClient senderClient;

        public SmtpClient SenderClient
        {
            get { return senderClient; }
            set { senderClient = value; }
        }

        public void Connect()
        {
            receiverClient.Connect(imapInfo.Hostname, Convert.ToInt16(imapInfo.Port), true);
            senderClient.Connect(smtpInfo.Hostname, Convert.ToInt16(smtpInfo.Port), true);
        }

        public void Disconnect()
        {
            receiverClient.Disconnect(true);
            senderClient.Disconnect(true);
        }

        public void Dispose()
        {
            this.Disconnect();
        }

        public void Login(string username, string password)
        {
            receiverClient.Authenticate(username, password);
            senderClient.Authenticate(username, password);
        }
    }
}