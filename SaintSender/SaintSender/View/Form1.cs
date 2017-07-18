using MailKit.Net.Imap;
using MimeKit;
using SaintSender.Control;
using SaintSender.Properties;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class Form1 : Form
    {
        IClient client;
        public Form1()
        {
            InitializeComponent();
            if (Settings.Default.BackupFolder == string.Empty)
            {
                Settings.Default.BackupFolder = @"%appdata%\NoneMail";
                Settings.Default.Save();
            }
            // TODO: get singleton client
            //client.Connect();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Load messages from client and calls display method.
        /// </summary>
        private void LoadMails()
        {
            MimeMessage[] messages = client.DownloadMails();
            ShowMails(messages);
        }

        /// <summary>
        /// Displays messages on form.
        /// </summary>
        /// <param name="messages">Messages to display</param>
        private void ShowMails(MimeMessage[] messages)
        {
            // TODO: show mails on form
        }
    }
}