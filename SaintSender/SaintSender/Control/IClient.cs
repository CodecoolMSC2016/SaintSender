using MimeKit;
using System.Collections.Generic;

namespace SaintSender.Control
{
    internal interface IClient
    {
        // connect, login, first download messages
        void Initialize();
        // returns all messages
        MimeMessage[] DownloadMails();
        void Connect(string url, uint port);
        void AutoRefresh();
        void SendMail();
        void BackupMails();
        void RestoreMails();
        void Login();
    }
}