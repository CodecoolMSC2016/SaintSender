using MailKit;
using MimeKit;
using SaintSender.Model;
using System.Collections.Generic;

namespace SaintSender.Control
{
    internal interface IClient
    {
        IReceiver Receiver { get; }
        int MailCount { get; }
        ConnectionInfo ImapInfo { get; set; }
        ConnectionInfo SmtpInfo { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        MimeMessage[] DownloadMails();
        void SendMail(MimeMessage message);
        void BackupMails();
        void RestoreMails();
        bool Login();
    }
}