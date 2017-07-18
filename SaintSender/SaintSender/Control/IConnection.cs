using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using System;

namespace SaintSender.Control
{
    /// <summary>
    /// Establish and authenticate connections, and provides the connection objects.
    /// </summary>
    internal interface IConnection : IDisposable
    {
        // constructor(ConnectionInfo imapInfo, ConnectionInfo smtpInfo)
        void Connect();

        void Login(string username, string password);

        void Disconnect();

        ImapClient ReceiverClient { get; set; }
        SmtpClient SenderClient { get; set; }
    }
}