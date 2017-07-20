using MimeKit;
using SaintSender.Model;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SaintSender.Control
{
    internal class Serializer : ISerializer
    {
        public MimeMessage[] Restore(string folderName)
        {
            string fileName = Path.GetDirectoryName(folderName);

            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(fileName, FileMode.Open);
            List<Mail> mails = (List<Mail>)bf.Deserialize(stream);
            stream.Close();

            MimeMessage[] messages = new MimeMessage[mails.Count];
            MessageConverter converter = new MessageConverter();
            for (int i = 0; i < mails.Count; i++)
            {
                messages[i] = converter.ToMimeMessage(mails[i]);
            }
            return messages;
        }

        public void Save(MimeMessage[] messages, string folderName)
        {
            BinaryFormatter bf = new BinaryFormatter();
            Folder folder = new Folder(messages);

            string fileName = Path.GetDirectoryName(folderName) + "mails.dat";
            FileStream stream = new FileStream(fileName, FileMode.Create);
            bf.Serialize(stream, folder);
            stream.Close();
        }
    }
}