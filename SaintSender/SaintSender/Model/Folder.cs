using MimeKit;
using SaintSender.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender.Model
{
    class Folder
    {
        List<Mail> mails = new List<Mail>();
        MessageConverter m = new MessageConverter();
        public Folder(MimeMessage[] messages)
        {
            for (int i = 0; i < messages.Length; i++)
            {
                mails.Add(m.ToMail(messages[i]));
            }
        }
        
}
}
