using MaterialSkin.Controls;
using SaintSender.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            tabControl.TabPages.Add(cc.GetTabMail(title));
           
        }
    }
}
