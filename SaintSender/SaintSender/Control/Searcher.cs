using MimeKit;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SaintSender.Control
{
    internal class Searcher
    {
        private IReceiver receiver;

        public MimeMessage[] SearchMessage(string pattern)
        {
            HashSet<MimeMessage> searchResultSet = new HashSet<MimeMessage>();

            MimeMessage[] messages = receiver.Mails;

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