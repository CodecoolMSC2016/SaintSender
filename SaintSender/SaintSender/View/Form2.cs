﻿using MaterialSkin;
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
        private IClient client;
        ControlManager cm;

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
            client = new SaintClient(imapInfo, smtpInfo, "imaptest420@gmail.com", "024tsetpami");
            new Task(() =>
            {
                ShowEmails();
            }).Start();
            txtMailFrom.Text = "imaptest420@gmail.com";
            Text = "Imap Test (" + "imaptest420@gmail.com)";

            cm = new ControlManager(tabHolder);
            //TODO: Remove...
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close(); // TODO : open login window?
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            string[] from = txtMailFrom.Text.Trim().Split(',');
            string[] to = txtMailTo.Text.Trim().Split(',');
            string[] cc = txtMailCc.Text.Split(',');
            string[] bcc = txtMailCc.Text.Split(',');

            string subject = richMailSubject.Text;
            string body = richMailBody.Text;

            MessageConverter convert = new MessageConverter();
            Mail mail = new Mail(from, to, DateTime.Now, subject, body, cc, bcc);
            MimeMessage message = convert.ToMimeMessage(mail);
            client.SendMail(message);
        }

        private void emailListView_DoubleClick(object sender, EventArgs e)
        {
            if (emailListView.SelectedItems[0] != null)
            {
                cm.AddNewTab(emailListView.SelectedItems[0].Text, ControlManager.TabTypes.MailView);
            }
        }

        private void btnReplyMail_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("asdasdasdasdasd");
            viewEmailSplitContainer.SplitterDistance = 400;

            RichTextBox richReplyMail = new RichTextBox();
            richReplyMail.Parent = viewEmailSplitContainer.Panel2;
            richReplyMail.Show();
            richReplyMail.Dock = DockStyle.Fill;
            richReplyMail.BackColor = SystemColors.ControlLight;
            richReplyMail.BorderStyle = BorderStyle.None;

            MaterialFlatButton mfb = new MaterialFlatButton();
            mfb.Parent = viewEmailButtonHolder;
            mfb.Left = 5;
            mfb.Top = btnReplyMail.Top;
            mfb.Text = "Close";
            mfb.Click += (s, ea) =>
            {
                viewEmailSplitContainer.SplitterDistance = 570;
                mfb.Dispose();
                richReplyMail.Dispose();
            };
        }
        private void EmtpySendMailFields()
        {
            txtMailTo.Text = String.Empty;
            txtMailTo.Text = String.Empty;
            txtMailCc.Text = String.Empty;
            txtMailBcc.Text = String.Empty;

            richMailBody.Text = String.Empty;
            richMailSubject.Text = String.Empty;

        }
        
    }
}
