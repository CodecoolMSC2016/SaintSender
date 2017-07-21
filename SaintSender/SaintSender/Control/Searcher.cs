using MimeKit;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SaintSender.Control
{
    internal class Searcher
    {
        // private MessageReceiver receiver;

        private IClient client = SaintClient.INSTANCE;

        public MimeMessage[] SearchMessage(string pattern)
        {
            HashSet<MimeMessage> searchResultSet = new HashSet<MimeMessage>();

            pattern = Regex.Escape(pattern);

            MimeMessage[] messages = client.Mails;
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