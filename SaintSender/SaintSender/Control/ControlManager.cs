using MaterialSkin.Controls;
using SaintSender.Control;
using System.Collections.Generic;

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

        public void AddNewTab(string title, TabTypes type)
        {
            switch (type)
            {
                case TabTypes.MailList:
                    AddNewMailListTab(title);
                    break;

                case TabTypes.SendMail:
                    AddNewSendMailTab(title);
                    break;

                case TabTypes.MailView:
                    AddNewMailViewTab(title);
                    break;

                case TabTypes.Settings:
                    break;

                default:
                    break;
            }
        }

        private void AddNewMailViewTab(string title)
        {
            tabControl.TabPages.Add(cc.GetTabMail(title));
        }

        private void AddNewMailListTab(string title)
        {
            tabControl.TabPages.Add(cc.getTabInbox(title));
        }

        private void AddNewSendMailTab(string title)
        {
            tabControl.TabPages.Add(cc.GetTabWriteEmail(title));
        }
    }
}