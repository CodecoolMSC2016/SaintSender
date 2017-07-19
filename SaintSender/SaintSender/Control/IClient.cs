using MimeKit;
using SaintSender.Model;
using System.Collections.Generic;

namespace SaintSender.Control
{
    internal interface IClient
    {
        // returns all messages
        MimeMessage[] DownloadMails();
        void SendMail(MimeMessage message);
        void BackupMails();
        void RestoreMails();
    }
}