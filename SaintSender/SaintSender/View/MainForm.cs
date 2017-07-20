using MaterialSkin;
using MaterialSkin.Controls;
using SaintSender.Control;
using SaintSender.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using static SaintSender.View.ControlManager;

namespace SaintSender.View
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private IClient client = SaintClient.INSTANCE;
        private ControlManager cm = ControlManager.INSTANCE;

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
            ConnectionInfo imapInfo = new ConnectionInfo("imap.gmail.com", 993);
            ConnectionInfo smtpInfo = new ConnectionInfo("smtp.gmail.com", 465);
            client.ImapInfo = imapInfo;
            client.SmtpInfo = smtpInfo;
            client.UserName = "imaptest420@gmail.com";
            client.Password = "024tsetpami";

            cm.FormWidth = Width;
            cm.TabControl = tabHolder;

            TabPage inbox = cm.AddNewTab(" INBOX ", TabTypes.MailList);
            cm.GetMailListView(inbox);
            tabHolder.TabPages.Remove(tabHolder.TabPages[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            lw.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            TabPage writeEMail = cm.AddNewTab( "WRITE ", ControlManager.TabTypes.SendMail);
            var tab = tabHolder.SelectedTab;
            int selectedIndex = tabHolder.TabCount - 1;
            SelectLastTab(selectedIndex);
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            tabHolder.SelectTab(0);
            //TabPage inbox = cm.AddNewTab(" INBOX ", ControlManager.TabTypes.MailList);
            //SelectLastTab();
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            if (tabHolder.TabCount > 1)
            {
                var tab = tabHolder.SelectedTab;
                int selectedIndex = tabHolder.SelectedIndex;
                int maxIndex = tabHolder.TabCount - 1;
                if (selectedIndex > 0)
                {
                    //int selectedIndex = (tabHolder.SelectedIndex > 0) ? tabHolder.SelectedIndex - 1 : 0;
                    selectedIndex = (selectedIndex == maxIndex) ? selectedIndex - 1 : selectedIndex;
                    tabHolder.TabPages.Remove(tab);
                    SelectLastTab(selectedIndex);
                }
            }
        }

        private void SelectLastTab(int index)
        {
           tabHolder.SelectTab(index);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            cm.FormWidth = Width;
        }
    }
}