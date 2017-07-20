using MimeKit;

namespace SaintSender.Control
{
    /// <summary>
    /// Receives emails from server via Imap connection.
    /// </summary>
    internal interface IReceiver
    {
        MimeMessage[] Mails { get; }

        // constructor(ImapClient receiverClient)
        MimeMessage[] DownloadMails();
    }
}