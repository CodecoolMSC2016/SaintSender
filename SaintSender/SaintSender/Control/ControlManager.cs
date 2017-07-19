using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender.View
{
    class ControlManager
    {
        public enum TabTypes : int { MailList, SendMail, MailView, Settings };
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
                    break;
                case TabTypes.SendMail:
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
            tabControl.TabPages.Add(title);
            TabPage newMailPage = new TabPage();
        }
    }
}
