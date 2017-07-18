using MimeKit;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SaintSender.Control
{
    internal class Serializer : ISerializer
    {
        public MimeMessage[] Restore(string folderName)
        {
            //// folderName should be a full path
            //string[] filePaths = Directory.GetFiles(Path.GetDirectoryName(folderName));

            //MimeMessage[] mails = new MimeMessage[filePaths.Length];
            //BinaryFormatter bf = new BinaryFormatter();

            //for (int i = 0; i < mails.Length; i++)
            //{
            //    string fileName = filePaths[i];
            //    FileStream stream = new FileStream(fileName, FileMode.Open);
            //    mails[i] = (MimeMessage)bf.Deserialize(stream);
            //    stream.Close();
            //}
            return null;
        }

        public void Save(MimeMessage[] mails, string folderName)
        {
            BinaryFormatter bf = new BinaryFormatter();

            MessageConverter m = new MessageConverter();

            for (int i = 0; i < mails.Length; i++)
            {
                // TODO: check whether MessageId is exist or not
                string fileName = Path.GetDirectoryName(folderName) + @"\" + mails[i].MessageId + ".dat";
                FileStream stream = new FileStream(fileName, FileMode.Create);
                bf.Serialize(stream, m.ToMail(mails[i]));
                stream.Close();
            }
        }
    }
}