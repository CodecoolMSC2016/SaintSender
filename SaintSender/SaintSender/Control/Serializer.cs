using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SaintSender.Control
{
    internal class Serializer : ISerializer
    {
        public Mail[] Restore(string folderName)
        {
            throw new NotImplementedException();
        }

        public void Save(Mail[] mails, string folderName)
        {
            string fileName = folderName + @"\mails.dat";
            FileStream stream = new FileStream(fileName, FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            for (int i = 0; i < mails.Length; i++)
            {
                bf.Serialize(stream, mails[i]);
            }
            stream.Close();
        }
    }
}