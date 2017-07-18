using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using SaintSender.Model;

namespace SaintSender.Control
{
    class SaintSender : IClient
    {
        public IClient INSTANCE { get; }

        private SaintSender()
        {

        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public MimeMessage[] DownloadMails()
        {
            throw new NotImplementedException();
        }

        public void Connect(ConnectionInfo imapInfo, ConnectionInfo smtpInfo)
        {
            // IConnection conn = new IConnectionImpl(imapInfo, smtpInfo);
            // conn.Connect();
        }

        public void AutoRefresh()
        {
            throw new NotImplementedException();
        }

        public void SendMail()
        {
            throw new NotImplementedException();
        }

        public void BackupMails()
        {
            throw new NotImplementedException();
        }

        public void RestoreMails()
        {
            throw new NotImplementedException();
        }

        public void Login()
        {
            throw new NotImplementedException();
        }
    }
}
