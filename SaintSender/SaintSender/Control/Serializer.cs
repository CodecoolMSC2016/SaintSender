using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SaintSender.Control
{
    internal class Serializer : ISerializer
    {
        public Mail[] Restore(string folderName)
        {
            string[] filePaths = Directory.GetFiles(folderName);

            Mail[] mails = new Mail[filePaths.Length];
            BinaryFormatter bf = new BinaryFormatter();

            for (int i = 0; i < mails.Length; i++)
            {
                string fileName = filePaths[i];
                FileStream stream = new FileStream(fileName, FileMode.Open);
                mails[i] = (Mail)bf.Deserialize(stream);
                stream.Close();
            }
            return mails;
        }

        public void Save(Mail[] mails, string folderName)
        {
            BinaryFormatter bf = new BinaryFormatter();

            for (int i = 0; i < mails.Length; i++)
            {
                // TODO: name of the file to serialize
                string fileName = folderName + "BLABLA.dat";
                FileStream stream = new FileStream(fileName, FileMode.Create);
                bf.Serialize(stream, mails[i]);
                stream.Close();
            }
        }
    }
}