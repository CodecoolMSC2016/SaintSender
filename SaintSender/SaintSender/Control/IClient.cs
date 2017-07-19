using MimeKit;
using SaintSender.Model;
using System.Collections.Generic;

namespace SaintSender.Control
{
    internal interface IClient
    {
        // connect, login, first download messages
        void Initialize();
        // returns all messages
        MimeMessage[] DownloadMails();
        void Connect(ConnectionInfo smtpInfo, ConnectionInfo imapInfo);
        void AutoRefresh();
        void SendMail(MimeMessage message);
        void BackupMails();
        void RestoreMails();
        void Login(string username, string password);
    }
}