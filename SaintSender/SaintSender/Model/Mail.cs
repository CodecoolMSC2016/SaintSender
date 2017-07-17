using System;

namespace SaintSender
{
    [Serializable]
    internal class Mail
    {
        public Mail()
        {
            
        }
        [NonSerialized]
        private bool Seen;

        public Mail(
            string from,
            string to,
            DateTime date,
            string subject,
            string body,
            string cc = null,
            string bcc = null,
            bool seen = false)
        {
            Subject = subject;
            From = from;
            To = to;
            Cc = cc;
            Bcc = bcc;
            Date = date;
            Body = body;
            Seen = seen;
        }

        public string Bcc { get; set; }
        public string Body { get; set; }
        public string Cc { get; set; }
        public DateTime Date { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string To { get; set; }
    }
}