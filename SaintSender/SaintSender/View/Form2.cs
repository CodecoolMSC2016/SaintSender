using MaterialSkin;
using MaterialSkin.Controls;
using MimeKit;
using SaintSender.Control;
using SaintSender.Model;
using SaintSender.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender.View
{
    public partial class Form2 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private IClient client = SaintClient.INSTANCE;

        public Form2()
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
            new Task(() =>
            {
                client.Connect(imapInfo, smtpInfo);
                client.Login("imaptest420@gmail.com", "024tsetpami");
                ShowEmails();
            }).Start();

            emailWebBrowser.Navigate("https://dcrazed.com/html/kreative-demo/");
        }
        private delegate void AddToView(ListViewItem item);

        private void Add(ListViewItem item)
        {
            emailListView.Items.Add(item);
        }

        private void ShowEmails()
        {
            MimeMessage[] mails = client.DownloadMails();

            foreach (MimeMessage mail in mails)
            {
                var item = new ListViewItem(new string[] { mail.Subject, mail.From.ToString(), mail.Date.ToString() });
                if (emailListView.InvokeRequired)
                {
                    emailListView.Invoke(new AddToView(Add), item);
                }
                else
                {
                    emailListView.Items.Add(item);
                }
            }
        }
    }
}
