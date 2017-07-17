using MailKit.Net.Imap;
using SaintSender.Properties;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (Settings.Default.BackupFolder == string.Empty)
            {
                Settings.Default.BackupFolder = @"%appdata%\NoneMail";
                Settings.Default.Save();
            }
            
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            ImapClient ic = new ImapClient();
            ic.Connect()
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}