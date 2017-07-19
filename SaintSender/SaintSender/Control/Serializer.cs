using MimeKit;
using SaintSender.Model;
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