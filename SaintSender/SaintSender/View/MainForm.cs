using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SaintSender.View
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private ControlManager cm;

        public MainForm()
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            //materialSkinManager.
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cm = new ControlManager(tabHolder);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            lw.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
           
            TabPage writeEMail = cm.AddNewTab("WRITE EMAIL", ControlManager.TabTypes.SendMail);
        }
        
        private void btnInbox_Click(object sender, EventArgs e)
        {
            TabPage inbox = cm.AddNewTab("INBOX", ControlManager.TabTypes.MailList);
        }
    }
}