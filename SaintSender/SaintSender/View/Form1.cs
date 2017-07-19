using MailKit.Net.Imap;
using MaterialSkin;
using MaterialSkin.Controls;
using SaintSender.Properties;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class formMain : MaterialForm
    {
        public formMain()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage();
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            if (Settings.Default.BackupFolder == string.Empty)
            {
                Settings.Default.BackupFolder = @"%appdata%\NoneMail";
                Settings.Default.Save();
            }
            
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            ImapClient ic = new ImapClient();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}