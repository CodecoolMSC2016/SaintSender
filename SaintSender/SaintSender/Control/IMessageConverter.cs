﻿using MimeKit;
using SaintSender.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender.Control
{
    /// <summary>
    /// Converts between [Serializable] Mail and MimeMessage
    /// </summary>
    interface IMessageConverter
    {
        Mail ToMail(MimeMessage message);
        MimeMessage ToMimeMessage(Mail message);
    }
}
