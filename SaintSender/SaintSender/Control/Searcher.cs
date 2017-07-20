using MimeKit;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SaintSender.Control
{
    internal class Searcher
    {
        public void SearchByMailboxAddress(string pattern)
        {
            List<InternetAddress> result = new List<InternetAddress>();

            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches("....");

            // needed the Form property of MimeMessage
            foreach (MailboxAddress mailbox in message.From.Mailboxes)
            {
                if (Regex.IsMatch(mailbox.Address, pattern))
                {
                    result.Add(mailbox);
                }
            }
        }

        public List<InternetAddress> SearchByName(string pattern)
        {
            List<InternetAddress> result = new List<InternetAddress>();

            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches("....");

            // needed the Form property of MimeMessage
            foreach (MailboxAddress mailbox in message.From.Mailboxes)
            {
                if (Regex.IsMatch(mailbox.Name, pattern))
                {
                    result.Add(mailbox);
                }
            }
            return result;
        }
    }
}