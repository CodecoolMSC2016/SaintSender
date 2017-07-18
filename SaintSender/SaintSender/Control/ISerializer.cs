using SaintSender.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender.Control
{
    interface ISerializer
    {
        void Save(Mail[] mails, string folderName);
        Mail[] Restore(string folderName);
    }
}
