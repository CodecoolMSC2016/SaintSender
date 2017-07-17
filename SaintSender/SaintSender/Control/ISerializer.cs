using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    interface ISerializer
    {
        void Save(Mail[] mails, string folderName);
        Mail[] Restore(string folderName);
    }
}
