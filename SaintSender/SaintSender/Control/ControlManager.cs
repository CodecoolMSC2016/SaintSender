using MaterialSkin.Controls;
using SaintSender.Control;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SaintSender.View
{
    public class ControlManager
    {
        public enum TabTypes : int { MailList, SendMail, MailView, Settings };

        private ControlCollection cc = new ControlCollection();
        private List<MaterialTabControl> tabs = new List<MaterialTabControl>();
        private MaterialTabControl tabControl;

        public ControlManager(MaterialTabControl tabControl)
        {
            this.tabControl = tabControl;
        }

        public TabPage AddNewTab(string title, TabTypes type)
        {
            TabPage tabPage = null;
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
            return tabPage;
        }

        private TabPage AddNewMailViewTab(string title)
        {
            TabPage tabViewMail = cc.GetTabMail(title);
            tabControl.TabPages.Add(tabViewMail);

            return tabViewMail;
        }

        private TabPage AddNewMailListTab(string title)
        {
            TabPage tabMailList = cc.getTabInbox(title);
            tabControl.TabPages.Add(tabMailList);

            return tabMailList;
        }

        private TabPage AddNewSendMailTab(string title)
        {
            TabPage tabWriteEmail = cc.GetTabWriteEmail(title);
            tabControl.TabPages.Add(tabWriteEmail);

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
    }
}