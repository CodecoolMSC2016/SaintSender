using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender.Control
{
    interface IMessageConverter
    {
        Mail ToMail(MimeMessage message);
        MimeMessage ToMimeMessage(Mail message);
    }
}
