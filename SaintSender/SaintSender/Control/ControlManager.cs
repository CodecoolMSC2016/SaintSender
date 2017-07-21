using MaterialSkin.Controls;
using MimeKit;
using SaintSender.Control;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender.View
{
    public class ControlManager
    {
        public enum TabTypes : int { MailList, SendMail, MailView, Settings };

        private ControlCollection cc = new ControlCollection();
        private List<MaterialTabControl> tabs = new List<MaterialTabControl>();
        public MaterialTabControl TabControl { get; set; }
        public int FormWidth { get; set; }
        private IClient client = SaintClient.INSTANCE;

        public static ControlManager INSTANCE { get; } = new ControlManager();

        private ControlManager(){
        }

        public TabPage AddNewTab(string title, TabTypes type)
        {
            TabPage tabPage = null;
            if (TabControl.TabCount < (FormWidth / 100)) 
            {
                switch (type)
                {
                    case TabTypes.MailList:
                        tabPage = AddNewMailListTab(title);
                        break;

                    case TabTypes.SendMail:
                        tabPage = AddNewSendMailTab(title);
                        break;

                    case TabTypes.MailView:
                        tabPage = AddNewMailViewTab(title);
                        break;

                    case TabTypes.Settings:
                        break;

                    default:
                        break;
                }
            }
            return tabPage;
        }

        private TabPage AddNewMailViewTab(string title)
        {
            TabPage tabViewMail = cc.GetTabMail(title);
            TabControl.TabPages.Add(tabViewMail);

            return tabViewMail;
        }

        private TabPage AddNewMailListTab(string title)
        {
            TabPage tabMailList = cc.getTabInbox(title);
            TabControl.TabPages.Add(tabMailList);
            //TabControl.Invoke(new Action(() => TabControl.TabPages.Add(tabMailList)));
            //new Task(() =>
            //{
            //    tabMailList.Invoke(new Action(() => ShowEmails(tabMailList)));
            //}).Start();

            return tabMailList;
        }

        private TabPage AddNewSendMailTab(string title)
        {
            TabPage tabWriteEmail = cc.GetTabWriteEmail(title);
            TabControl.TabPages.Add(tabWriteEmail);

            return tabWriteEmail;
        }

        public MaterialListView GetMailListView(TabPage tabPage)
        {
            System.Windows.Forms.Control[] matches = tabPage.Controls.Find("emailListView", true);
            return (MaterialListView)matches[0];
        }

        public WebBrowser GetMailWebBrowser(TabPage tabPage)
        {
            System.Windows.Forms.Control[] matches = tabPage.Controls.Find("emailWebBrowser", true);
            return (WebBrowser)matches[0];
        }

        private delegate void AddToView(ListViewItem item, MaterialListView emailListView);

        private void Add(ListViewItem item, MaterialListView emailListView)
        {
            emailListView.Items.Add(item);
        }

        public void ShowEmails(TabPage page, MimeMessage[] mails = null)
        {
            var emailListView = GetMailListView(page);
            mails = (mails == null) ? client.DownloadMails() : mails;
            emailListView.Invoke(new Action(() => emailListView.Items.Clear()));

            foreach (MimeMessage mail in mails)
            {
                var item = new ListViewItem(new string[] { mail.Subject, mail.From.ToString(), mail.Date.ToString() });
                if (emailListView.InvokeRequired)
                {
                    emailListView.Invoke(new AddToView(Add), new object[] { item, emailListView });
                }
                else
                {
                    emailListView.Items.Add(item);
                }
            }
        }
    }
}