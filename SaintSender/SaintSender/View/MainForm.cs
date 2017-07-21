using MaterialSkin;
using MaterialSkin.Controls;
using MimeKit;
using SaintSender.Control;
using SaintSender.Model;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SaintSender.View.ControlManager;

namespace SaintSender.View
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private IClient client = SaintClient.INSTANCE;
        private ControlManager cm = ControlManager.INSTANCE;
        private MaterialForm loginWindow;

        public MainForm()
        {
            InitializeComponent();


            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            //materialSkinManager.
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loginWindow = new LoginWindow();
            loginWindow.Owner = this;
            loginWindow.Show();
            EnabledChanged += (s, eArg) =>
            {
                ResetForm();
                cm.FormWidth = Width;
                cm.TabControl = tabHolder;
                TabPage inbox = cm.AddNewTab(" INBOX ", TabTypes.MailList);
                Task loadMails = new Task(() => cm.ShowEmails(inbox));
                loadMails.Start();
                tabHolder.TabPages.Remove(tabHolder.TabPages[0]);
                loadMails.ContinueWith((task) => AutoRefresh(), TaskContinuationOptions.OnlyOnRanToCompletion);
            };
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
                    selectedIndex = (selectedIndex == maxIndex) ? selectedIndex - 1 : selectedIndex;
                    tabHolder.TabPages.Remove(tab);
                    SelectLastTab(selectedIndex);
                }
            }
        }

        private void AutoRefresh()
        {
            Task.Run(() =>
            {
                MimeMessage[] mails;
                int newMailCount = 0;
                TabPage inboxPage;
                while (Enabled)
                {

                    newMailCount = client.QueryMailCount();
                    inboxPage = tabHolder.TabPages[0];
                    int currentMailCount = cm.GetMailListView(inboxPage).Items.Count;

                    if (newMailCount > currentMailCount)
                    {
                        //TabPage inbox = cm.AddNewTab(" INBOX ", TabTypes.MailList);
                        
                        cm.ShowEmails(tabHolder.TabPages[0], client.DownloadMails());
                        ShowNotification(newMailCount - currentMailCount);
                        //tabHolder.TabPages.Remove(tabHolder.TabPages[0]);
                        //loadMails.ContinueWith((task) => AutoRefresh(), TaskContinuationOptions.OnlyOnRanToCompletion);
                        //OnEnabledChanged(new EventArgs());
                    }
                    Thread.Sleep(1000);
                }
            });
        }

        private void ShowNotification(int newMessageCount)
        {
            NotifyIcon icon = new NotifyIcon()
            {
                Icon = SystemIcons.Information,
                Visible = true,
                BalloonTipTitle = "New message!",
                BalloonTipText = "You have " + newMessageCount + " new message(s)."
            };
            icon.ShowBalloonTip(50000);

        }

        private void SelectLastTab(int index)
        {
           tabHolder.SelectTab(index);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            cm.FormWidth = Width;
        }

        public void ResetForm()
        {
            TabPage page;
            TabPage inboxPage = tabHolder.TabPages[0];
            tabHolder.SelectedIndex = 0;
            int tabCount = tabHolder.TabCount;
            if (tabCount > 1)
            {
                for (int i = 0; i < tabCount - 1; i++)
                {
                    page = tabHolder.TabPages[1];
                    tabHolder.TabPages.Remove(page);
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Owner = this;
            login.Show();
        }

        private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {
            Searcher search = new Searcher();
            if (materialSingleLineTextField1.Text == null)
            {
                cm.ShowEmails(tabHolder.TabPages[0], client.Mails);
            }
            else
            {
                cm.ShowEmails(tabHolder.TabPages[0], search.SearchMessage(materialSingleLineTextField1.Text));
            }

        }
    }
}