using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender.Control
{
    /// <summary>
    /// Sends emails via Smtp connection.
    /// </summary>
    interface ISender
    {
        // constructor(SmtpClient senderClient)
        void SendMail(MimeMessage message);
    }
}
