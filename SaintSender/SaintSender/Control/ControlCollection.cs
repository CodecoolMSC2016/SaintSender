using MaterialSkin.Controls;
using MimeKit;
using SaintSender.Model;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender.Control
{
    internal class ControlCollection
    {
        private IClient client = SaintClient.INSTANCE;

        public TabPage getTabInbox(string title = "Inbox")
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Subject";
            columnHeader1.Width = 400;
            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "From";
            columnHeader2.Width = 200;
            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader3.Text = "Date";
            columnHeader3.Width = 200;

            MaterialListView emailListView = new MaterialListView();
            emailListView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            emailListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            emailListView.CheckBoxes = true;
            emailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3});
            emailListView.Depth = 0;
            emailListView.Dock = System.Windows.Forms.DockStyle.Fill;
            emailListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            emailListView.FullRowSelect = true;
            emailListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            emailListView.Location = new System.Drawing.Point(3, 20);
            emailListView.MouseLocation = new System.Drawing.Point(-1, -1);
            emailListView.MouseState = MaterialSkin.MouseState.OUT;
            emailListView.Name = "emailListView";
            emailListView.OwnerDraw = true;
            emailListView.Size = new System.Drawing.Size(1067, 585);
            emailListView.TabIndex = 0;
            emailListView.UseCompatibleStateImageBehavior = false;
            emailListView.View = System.Windows.Forms.View.Details;
            emailListView.DoubleClick += (emailListViewSender, emailListViewEventArgs) =>
            {
                //TODO: EmailListView Double Click
            };

            TabPage tabInbox = new TabPage();
            tabInbox.Controls.Add(emailListView);
            tabInbox.Location = new System.Drawing.Point(4, 22);
            tabInbox.Name = "tabInbox";
            tabInbox.Padding = new System.Windows.Forms.Padding(3, 20, 3, 3);
            tabInbox.Size = new System.Drawing.Size(1073, 608);
            tabInbox.TabIndex = 0;
            tabInbox.Text = title;
            tabInbox.UseVisualStyleBackColor = true;

            return tabInbox;
        }

        public TabPage GetTabMail(string title)
        {
            SplitContainer viewEmailSplitContainer = new SplitContainer();
            viewEmailSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            viewEmailSplitContainer.Location = new System.Drawing.Point(3, 3);
            viewEmailSplitContainer.Name = "viewEmailSplitContainer";
            viewEmailSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;

            WebBrowser emailWebBrowser = new WebBrowser();
            emailWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            emailWebBrowser.Location = new System.Drawing.Point(0, 0);
            emailWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            emailWebBrowser.Name = "emailWebBrowser";
            emailWebBrowser.ScriptErrorsSuppressed = true;
            emailWebBrowser.Size = new System.Drawing.Size(1067, 544);
            emailWebBrowser.TabIndex = 17;

            Panel viewEmailButtonHolder = new Panel();
            viewEmailButtonHolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            viewEmailButtonHolder.Location = new System.Drawing.Point(0, 0);
            viewEmailButtonHolder.Name = "viewEmailButtonHolder";
            viewEmailButtonHolder.Size = new System.Drawing.Size(1067, 48);
            viewEmailButtonHolder.TabIndex = 19;

            MaterialFlatButton btnReplyMail = new MaterialFlatButton();
            btnReplyMail.AutoSize = true;
            btnReplyMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnReplyMail.BackColor = System.Drawing.Color.Silver;
            btnReplyMail.Depth = 0;
            btnReplyMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            btnReplyMail.Icon = null;
            btnReplyMail.Location = new System.Drawing.Point(944, 6);
            btnReplyMail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnReplyMail.MouseState = MaterialSkin.MouseState.HOVER;
            btnReplyMail.Name = "btnReplyMail";
            btnReplyMail.Primary = false;
            btnReplyMail.Size = new System.Drawing.Size(119, 36);
            btnReplyMail.TabIndex = 8;
            btnReplyMail.Text = "REPLY TO MAIL";
            btnReplyMail.UseVisualStyleBackColor = false;
            btnReplyMail.Click += (btnReplyMailSender, btnReplyMainEventArgs) =>
            {
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

                //TODO: Implement email send button event here...
            };

            viewEmailButtonHolder.Controls.Add(btnReplyMail);

            viewEmailSplitContainer.Panel1.Controls.Add(emailWebBrowser);

            viewEmailSplitContainer.Panel2.Controls.Add(viewEmailButtonHolder);
            viewEmailSplitContainer.Size = new System.Drawing.Size(1067, 602);
            viewEmailSplitContainer.SplitterDistance = 544;
            viewEmailSplitContainer.SplitterWidth = 10;
            viewEmailSplitContainer.TabIndex = 0;

            TabPage tabMail = new TabPage();
            tabMail.Controls.Add(viewEmailSplitContainer);
            tabMail.Location = new System.Drawing.Point(4, 22);
            tabMail.Name = "tabMail";
            tabMail.Padding = new System.Windows.Forms.Padding(3);
            tabMail.Size = new System.Drawing.Size(1073, 608);
            tabMail.TabIndex = 1;
            tabMail.Text = title;
            tabMail.UseVisualStyleBackColor = true;

            return tabMail;
        }

        public TabPage GetTabWriteEmail(string title = "NEW EMAIL")
        {
            MaterialSingleLineTextField txtMailBcc = new MaterialSingleLineTextField();
            txtMailBcc.Depth = 0;
            txtMailBcc.Hint = "";
            txtMailBcc.Location = new System.Drawing.Point(582, 80);
            txtMailBcc.MaxLength = 32767;
            txtMailBcc.MouseState = MaterialSkin.MouseState.HOVER;
            txtMailBcc.Name = "txtMailBcc";
            txtMailBcc.PasswordChar = '\0';
            txtMailBcc.SelectedText = "";
            txtMailBcc.SelectionLength = 0;
            txtMailBcc.SelectionStart = 0;
            txtMailBcc.Size = new System.Drawing.Size(467, 23);
            txtMailBcc.TabIndex = 7;
            txtMailBcc.TabStop = false;
            txtMailBcc.UseSystemPasswordChar = false;

            MaterialLabel materialLabel5 = new MaterialLabel();
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialLabel5.Location = new System.Drawing.Point(542, 80);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new System.Drawing.Size(34, 19);
            materialLabel5.TabIndex = 12;
            materialLabel5.Text = "Bcc";

            MaterialSingleLineTextField txtMailCc = new MaterialSingleLineTextField();
            txtMailCc.Depth = 0;
            txtMailCc.Hint = "";
            txtMailCc.Location = new System.Drawing.Point(586, 38);
            txtMailCc.MaxLength = 32767;
            txtMailCc.MouseState = MaterialSkin.MouseState.HOVER;
            txtMailCc.Name = "txtMailCc";
            txtMailCc.PasswordChar = '\0';
            txtMailCc.SelectedText = "";
            txtMailCc.SelectionLength = 0;
            txtMailCc.SelectionStart = 0;
            txtMailCc.Size = new System.Drawing.Size(463, 23);
            txtMailCc.TabIndex = 6;
            txtMailCc.TabStop = false;
            txtMailCc.UseSystemPasswordChar = false;

            MaterialLabel materialLabel4 = new MaterialLabel();
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialLabel4.Location = new System.Drawing.Point(553, 42);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new System.Drawing.Size(27, 19);
            materialLabel4.TabIndex = 11;
            materialLabel4.Text = "Cc";

            MaterialSingleLineTextField txtMailFrom = new MaterialSingleLineTextField();
            txtMailFrom.Depth = 0;
            txtMailFrom.Hint = "";
            txtMailFrom.Location = new System.Drawing.Point(53, 38);
            txtMailFrom.MaxLength = 32767;
            txtMailFrom.MouseState = MaterialSkin.MouseState.HOVER;
            txtMailFrom.Name = "txtMailFrom";
            txtMailFrom.PasswordChar = '\0';
            txtMailFrom.SelectedText = "";
            txtMailFrom.SelectionLength = 0;
            txtMailFrom.SelectionStart = 0;
            txtMailFrom.Size = new System.Drawing.Size(463, 23);
            txtMailFrom.TabIndex = 4;
            txtMailFrom.TabStop = false;
            txtMailFrom.UseSystemPasswordChar = false;

            MaterialLabel materialLabel1 = new MaterialLabel();
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialLabel1.Location = new System.Drawing.Point(3, 42);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(44, 19);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "From";

            MaterialLabel materialLabel2 = new MaterialLabel();
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialLabel2.Location = new System.Drawing.Point(20, 80);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new System.Drawing.Size(27, 19);
            materialLabel2.TabIndex = 6;
            materialLabel2.Text = "To";

            MaterialSingleLineTextField txtMailTo = new MaterialSingleLineTextField();

            txtMailTo.Depth = 0;
            txtMailTo.Hint = "";
            txtMailTo.Location = new System.Drawing.Point(53, 80);
            txtMailTo.MaxLength = 32767;
            txtMailTo.MouseState = MaterialSkin.MouseState.HOVER;
            txtMailTo.Name = "txtMailTo";
            txtMailTo.PasswordChar = '\0';
            txtMailTo.SelectedText = "";
            txtMailTo.SelectionLength = 0;
            txtMailTo.SelectionStart = 0;
            txtMailTo.Size = new System.Drawing.Size(463, 23);
            txtMailTo.TabIndex = 5;
            txtMailTo.TabStop = false;
            txtMailTo.UseSystemPasswordChar = false;

            Panel writeEmailFieldHolder = new Panel();
            writeEmailFieldHolder.Controls.Add(txtMailBcc);
            writeEmailFieldHolder.Controls.Add(materialLabel5);
            writeEmailFieldHolder.Controls.Add(txtMailCc);
            writeEmailFieldHolder.Controls.Add(materialLabel4);
            writeEmailFieldHolder.Controls.Add(txtMailFrom);
            writeEmailFieldHolder.Controls.Add(materialLabel1);
            writeEmailFieldHolder.Controls.Add(materialLabel2);
            writeEmailFieldHolder.Controls.Add(txtMailTo);
            writeEmailFieldHolder.Dock = System.Windows.Forms.DockStyle.Top;
            writeEmailFieldHolder.Location = new System.Drawing.Point(10, 0);
            writeEmailFieldHolder.Name = "writeEmailFieldHolder";
            writeEmailFieldHolder.Size = new System.Drawing.Size(1053, 122);
            writeEmailFieldHolder.TabIndex = 11;

            MaterialFlatButton btnSaveDraft = new MaterialFlatButton();
            btnSaveDraft.AutoSize = true;
            btnSaveDraft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnSaveDraft.BackColor = System.Drawing.Color.Silver;
            btnSaveDraft.Depth = 0;
            btnSaveDraft.Icon = null;
            btnSaveDraft.Location = new System.Drawing.Point(827, 6);
            btnSaveDraft.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnSaveDraft.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaveDraft.Name = "btnSaveDraft";
            btnSaveDraft.Primary = true;
            btnSaveDraft.Size = new System.Drawing.Size(122, 36);
            btnSaveDraft.TabIndex = 10;
            btnSaveDraft.Text = "SAVE AS DRAFT";
            btnSaveDraft.UseVisualStyleBackColor = false;

            MaterialFlatButton btnSendMail = new MaterialFlatButton();
            btnSendMail.AutoSize = true;
            btnSendMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnSendMail.BackColor = System.Drawing.Color.Silver;
            btnSendMail.Depth = 0;
            btnSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            btnSendMail.Icon = null;
            btnSendMail.Location = new System.Drawing.Point(957, 6);
            btnSendMail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnSendMail.MouseState = MaterialSkin.MouseState.HOVER;
            btnSendMail.Name = "btnSendMail";
            btnSendMail.Primary = false;
            btnSendMail.Size = new System.Drawing.Size(92, 36);
            btnSendMail.TabIndex = 8;
            btnSendMail.Text = "SEND MAIL";
            btnSendMail.UseVisualStyleBackColor = false;

            Panel writeEmailButtonHolder = new Panel();
            writeEmailButtonHolder.Controls.Add(btnSendMail);
            writeEmailButtonHolder.Controls.Add(btnSaveDraft);
            writeEmailButtonHolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            writeEmailButtonHolder.Location = new System.Drawing.Point(10, 560);
            writeEmailButtonHolder.Name = "writeEmailButtonHolder";
            writeEmailButtonHolder.Size = new System.Drawing.Size(1053, 48);
            writeEmailButtonHolder.TabIndex = 13;

            RichTextBox richMailSubject = new RichTextBox();
            richMailSubject.BackColor = System.Drawing.SystemColors.ControlLight;
            richMailSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richMailSubject.Dock = System.Windows.Forms.DockStyle.Top;
            richMailSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            richMailSubject.Location = new System.Drawing.Point(10, 122);
            richMailSubject.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            richMailSubject.Name = "richMailSubject";
            richMailSubject.Size = new System.Drawing.Size(1053, 23);
            richMailSubject.TabIndex = 14;
            richMailSubject.Text = "";

            Panel panel2 = new Panel();
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(10, 145);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1053, 5);
            panel2.TabIndex = 16;

            RichTextBox richMailBody = new RichTextBox();
            richMailBody.BackColor = System.Drawing.SystemColors.ControlLight;
            richMailBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richMailBody.Dock = System.Windows.Forms.DockStyle.Fill;
            richMailBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            richMailBody.Location = new System.Drawing.Point(10, 150);
            richMailBody.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            richMailBody.Name = "richMailBody";
            richMailBody.Size = new System.Drawing.Size(1053, 410);
            richMailBody.TabIndex = 15;
            richMailBody.Text = "";

            TabPage tabWriteEmail = new TabPage();
            tabWriteEmail.BackColor = System.Drawing.SystemColors.Control;
            tabWriteEmail.Controls.Add(richMailBody);
            tabWriteEmail.Controls.Add(panel2);
            tabWriteEmail.Controls.Add(richMailSubject);
            tabWriteEmail.Controls.Add(writeEmailButtonHolder);
            tabWriteEmail.Controls.Add(writeEmailFieldHolder);
            tabWriteEmail.Location = new System.Drawing.Point(4, 22);
            tabWriteEmail.Name = "tabWriteEmail";
            tabWriteEmail.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            tabWriteEmail.Size = new System.Drawing.Size(1073, 608);
            tabWriteEmail.TabIndex = 2;
            tabWriteEmail.Text = title;
            txtMailFrom.Text = "imaptest420@gmail.com";

            HandleEmailSendEvent(tabWriteEmail);

            return tabWriteEmail;
        }

        private void HandleEmailSendEvent(TabPage currenTab)
        {

            var btnSendMail = currenTab.Controls.Find("btnSendMail", true)[0];
            var txtMailFrom = currenTab.Controls.Find("txtMailFrom", true)[0];
            var txtMailTo = currenTab.Controls.Find("txtMailTo", true)[0];
            var richMailSubject = currenTab.Controls.Find("richMailSubject", true)[0];
            var richMailBody = currenTab.Controls.Find("richMailBody", true)[0];
            var txtMailCc = currenTab.Controls.Find("txtMailCc", true)[0];
            var txtMailBcc = currenTab.Controls.Find("txtMailBcc", true)[0];

            btnSendMail.Click += (s, e) =>
            {
                string[] from = txtMailFrom.Text.Trim().Split(',');
                string[] to = txtMailTo.Text.Trim().Split(',');
                string[] cc = txtMailCc.Text.Split(',');
                string[] bcc = txtMailCc.Text.Split(',');

                string subject = richMailSubject.Text;
                string body = richMailSubject.Text;

                Task sendMail = new Task(() =>
                {
                    MessageConverter convert = new MessageConverter();
                    Mail mail = new Mail(from, to, DateTime.Now, subject, body, cc, bcc);
                    MimeMessage message = convert.ToMimeMessage(mail);
                    client.SendMail(message);
                });
                sendMail.Start();

                sendMail.ContinueWith((task) =>
                {
                    currenTab.Invoke(new Hide((p) => p.Dispose()), currenTab);
                });
            };

        }
        private delegate void Hide(TabPage page);
    }
}