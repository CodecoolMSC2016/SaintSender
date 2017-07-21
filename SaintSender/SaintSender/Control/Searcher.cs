using MailKit.Net.Imap;
using MimeKit;
using SaintSender.Model;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SaintSender.Control
{
    internal class Searcher
    {
        
        private MessageReceiver receiver;
        private SaintClient client;
        //private SaintClient client = SaintClient.INSTANCE;

        public MimeMessage[] SearchMessage(string pattern)
        {
            HashSet<MimeMessage> searchResultSet = new HashSet<MimeMessage>();

            // MimeMessage[] messages = receiver.Mails;


            ConnectionInfo imapInfo = new ConnectionInfo("imap.gmail.com", 993);
            ConnectionInfo smtpInfo = new ConnectionInfo("smtp.gmail.com", 465);
            client = new SaintClient(imapInfo, smtpInfo, "imaptest420@gmail.com", "024tsetpami");

            MimeMessage[] messages = client.DownloadMails();
            for (int i = 0; i < messages.Length; i++)
            {
                if (Regex.IsMatch(messages[i].Subject, pattern, RegexOptions.IgnoreCase))
                {
                    searchResultSet.Add(messages[i]);
                }

                foreach (InternetAddress email in messages[i].From)
                {
                    if (Regex.IsMatch(email.ToString(), pattern, RegexOptions.IgnoreCase))
                    {
                        searchResultSet.Add(messages[i]);
                    }
                }
            }
            MimeMessage[] searchResultArray = new MimeMessage[searchResultSet.Count];
            searchResultSet.CopyTo(searchResultArray);

            return searchResultArray;

          
        }
    }
}