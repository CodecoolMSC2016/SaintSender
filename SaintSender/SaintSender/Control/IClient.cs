using MimeKit;
using SaintSender.Model;
using System.Collections.Generic;

namespace SaintSender.Control
{
    internal interface IClient
    {
        // returns all messages
        MimeMessage[] DownloadMails();
        void Connect(ConnectionInfo smtpInfo, ConnectionInfo imapInfo);
        void SendMail(MimeMessage message);
        void BackupMails();
        void RestoreMails();
        void Login(string username, string password);
    }
}