using MimeKit;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SaintSender.Control
{
    internal class Searcher
    {
        //private string emailPattern = @"^(?("")("".+?(?<!\\)""@) |
        //(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
        //                 @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\]) |
        //(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
        // validate the Email
        //if (Regex.IsMatch(txtEmail.Text, emailPattern, RegexOptions.IgnoreCase))

        public void SearchByMailboxAddress(string pattern)
        {
            List<InternetAddress> result = new List<InternetAddress>();

            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches("....");

            // needed the Form property of MimeMessage
            //foreach (MailboxAddress mailbox in message.From.Mailboxes)
            //{
            //    if (Regex.IsMatch(mailbox.Address, pattern))
            //    {
            //        result.Add(mailbox);
            //    }
            //}
        }

        public List<InternetAddress> SearchByName(string pattern)
        {
            List<InternetAddress> result = new List<InternetAddress>();

            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches("....");

            // needed the Form property of MimeMessage
            //foreach (MailboxAddress mailbox in message.From.Mailboxes)
            //{
            //    if (Regex.IsMatch(mailbox.Name, pattern))
            //    {
            //        result.Add(mailbox);
            //    }
            //}
            return result;
        }
    }
}