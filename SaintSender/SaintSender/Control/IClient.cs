using MimeKit;
using System.Collections.Generic;

namespace SaintSender.Control
{
    internal interface IClient
    {
        void DownloadMails();
        void Connect();
        void AutoRefresh();
        void SendMail();
        void BackupMails();
        void RestoreMails();
        void Login();
    }
}