using MimeKit;

namespace SaintSender.Control
{
    internal interface IMessageConverter
    {
        Mail ToMail(MimeMessage message);

        MimeMessage ToMimeMessage(Mail message);
    }
}