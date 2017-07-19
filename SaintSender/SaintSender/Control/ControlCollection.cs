using MaterialSkin.Controls;
using SaintSender.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender.Control
{
    class ControlCollection
    {

        public TabPage getTabInbox()
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
            emailListView.DoubleClick += EmailListView_DoubleClick;

            TabPage tabInbox = new TabPage();
            tabInbox.Controls.Add(emailListView);
            tabInbox.Location = new System.Drawing.Point(4, 22);
            tabInbox.Name = "tabInbox";
            tabInbox.Padding = new System.Windows.Forms.Padding(3, 20, 3, 3);
            tabInbox.Size = new System.Drawing.Size(1073, 608);
            tabInbox.TabIndex = 0;
            tabInbox.Text = "Inbox";
            tabInbox.UseVisualStyleBackColor = true;

            return tabInbox;
        }

        private void EmailListView_DoubleClick(object sender, EventArgs e)
        {
            //TODO: EMailListView Double Click
        }

        public TabPage GetTabMail()
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
            tabMail.Text = "Rosszlanyok.hu regisztracio";
            tabMail.UseVisualStyleBackColor = true;



            return tabMail;
        }        
    }
}
