namespace SaintSender
{
    internal interface ISerializer
    {
        void Save(Mail[] mails, string folderName);

        Mail[] Restore(string folderName);
    }
}