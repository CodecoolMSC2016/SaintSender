using System;
using System.Runtime.Serialization;

namespace SaintSender.Model
{
    // [Serializable]
    internal class Mail : ISerializable
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

        
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("From", From);
            info.AddValue("To", To);
            info.AddValue("Date", Date);
            info.AddValue("Subject", Subject);
            info.AddValue("Body", Body);
            info.AddValue("Cc", Cc);
            info.AddValue("Bcc", Bcc);
        }

        protected Mail(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            From = (string)info.GetValue("From", typeof(string));
            To = (string)info.GetValue("To", typeof(string));
            Date = (DateTime)info.GetValue("Date", typeof(DateTime));
            Subject = (string)info.GetValue("Subject", typeof(string));
            Body = (string)info.GetValue("Body", typeof(string));
            Cc = (string)info.GetValue("Cc", typeof(string));
            Bcc = (string)info.GetValue("Bcc", typeof(string));
        }
    }
}