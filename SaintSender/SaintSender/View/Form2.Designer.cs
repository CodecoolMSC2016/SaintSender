namespace SaintSender.View
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("salalalal");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("rtrturturtu");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.emailWriteTab = new MaterialSkin.Controls.MaterialTabControl();
            this.tabInbox = new System.Windows.Forms.TabPage();
            this.emailListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMail = new System.Windows.Forms.TabPage();
            this.emailWebBrowser = new System.Windows.Forms.WebBrowser();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSpam = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnStarred = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDrafts = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnInbox = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabWriteEmail = new System.Windows.Forms.TabPage();
            this.txtMailFrom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMailTo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLogOut = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSettings = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtMailSubject = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.writeEmailFieldHolder = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMailCc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMailBcc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.writeEmailButtonHolder = new System.Windows.Forms.Panel();
            this.btnSendMail = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSaveDraft = new MaterialSkin.Controls.MaterialFlatButton();
            this.emailWriteTab.SuspendLayout();
            this.tabInbox.SuspendLayout();
            this.tabMail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabWriteEmail.SuspendLayout();
            this.writeEmailFieldHolder.SuspendLayout();
            this.writeEmailButtonHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.materialListView1.Location = new System.Drawing.Point(279, 190);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(311, 225);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = this.emailWriteTab;
            this.tabSelector.Depth = 0;
            this.tabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSelector.Location = new System.Drawing.Point(199, 63);
            this.tabSelector.Margin = new System.Windows.Forms.Padding(3, 300, 3, 0);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Padding = new System.Windows.Forms.Padding(0, 300, 0, 0);
            this.tabSelector.Size = new System.Drawing.Size(1081, 23);
            this.tabSelector.TabIndex = 1;
            this.tabSelector.Text = "materialTabSelector1";
            this.tabSelector.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // emailWriteTab
            // 
            this.emailWriteTab.Controls.Add(this.tabInbox);
            this.emailWriteTab.Controls.Add(this.tabMail);
            this.emailWriteTab.Controls.Add(this.tabWriteEmail);
            this.emailWriteTab.Depth = 0;
            this.emailWriteTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailWriteTab.Location = new System.Drawing.Point(199, 86);
            this.emailWriteTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailWriteTab.Name = "emailWriteTab";
            this.emailWriteTab.SelectedIndex = 0;
            this.emailWriteTab.Size = new System.Drawing.Size(1081, 634);
            this.emailWriteTab.TabIndex = 2;
            this.emailWriteTab.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tabInbox
            // 
            this.tabInbox.Controls.Add(this.emailListView);
            this.tabInbox.Location = new System.Drawing.Point(4, 22);
            this.tabInbox.Name = "tabInbox";
            this.tabInbox.Padding = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tabInbox.Size = new System.Drawing.Size(1073, 608);
            this.tabInbox.TabIndex = 0;
            this.tabInbox.Text = "Inbox";
            this.tabInbox.UseVisualStyleBackColor = true;
            // 
            // emailListView
            // 
            this.emailListView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailListView.CheckBoxes = true;
            this.emailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.emailListView.Depth = 0;
            this.emailListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.emailListView.FullRowSelect = true;
            this.emailListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.emailListView.Location = new System.Drawing.Point(3, 20);
            this.emailListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.emailListView.MouseState = MaterialSkin.MouseState.OUT;
            this.emailListView.Name = "emailListView";
            this.emailListView.OwnerDraw = true;
            this.emailListView.Size = new System.Drawing.Size(1067, 585);
            this.emailListView.TabIndex = 0;
            this.emailListView.UseCompatibleStateImageBehavior = false;
            this.emailListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Subject";
            this.columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "From";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 200;
            // 
            // tabMail
            // 
            this.tabMail.Controls.Add(this.emailWebBrowser);
            this.tabMail.Location = new System.Drawing.Point(4, 22);
            this.tabMail.Name = "tabMail";
            this.tabMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabMail.Size = new System.Drawing.Size(1073, 608);
            this.tabMail.TabIndex = 1;
            this.tabMail.Text = "Rosszlanyok.hu regisztracio";
            this.tabMail.UseVisualStyleBackColor = true;
            // 
            // emailWebBrowser
            // 
            this.emailWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailWebBrowser.Location = new System.Drawing.Point(3, 3);
            this.emailWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.emailWebBrowser.Name = "emailWebBrowser";
            this.emailWebBrowser.Size = new System.Drawing.Size(1067, 602);
            this.emailWebBrowser.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "hamburger.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSpam);
            this.panel1.Controls.Add(this.btnStarred);
            this.panel1.Controls.Add(this.btnDrafts);
            this.panel1.Controls.Add(this.btnInbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 657);
            this.panel1.TabIndex = 3;
            // 
            // btnSpam
            // 
            this.btnSpam.AutoSize = true;
            this.btnSpam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSpam.Depth = 0;
            this.btnSpam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpam.Icon = null;
            this.btnSpam.Location = new System.Drawing.Point(0, 108);
            this.btnSpam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSpam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSpam.Name = "btnSpam";
            this.btnSpam.Primary = false;
            this.btnSpam.Size = new System.Drawing.Size(199, 36);
            this.btnSpam.TabIndex = 3;
            this.btnSpam.Text = "Spam";
            this.btnSpam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpam.UseVisualStyleBackColor = true;
            // 
            // btnStarred
            // 
            this.btnStarred.AutoSize = true;
            this.btnStarred.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStarred.Depth = 0;
            this.btnStarred.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStarred.Icon = null;
            this.btnStarred.Location = new System.Drawing.Point(0, 72);
            this.btnStarred.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStarred.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStarred.Name = "btnStarred";
            this.btnStarred.Primary = false;
            this.btnStarred.Size = new System.Drawing.Size(199, 36);
            this.btnStarred.TabIndex = 2;
            this.btnStarred.Text = "Starred";
            this.btnStarred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStarred.UseVisualStyleBackColor = true;
            // 
            // btnDrafts
            // 
            this.btnDrafts.AutoSize = true;
            this.btnDrafts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDrafts.Depth = 0;
            this.btnDrafts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrafts.Icon = null;
            this.btnDrafts.Location = new System.Drawing.Point(0, 36);
            this.btnDrafts.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDrafts.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDrafts.Name = "btnDrafts";
            this.btnDrafts.Primary = false;
            this.btnDrafts.Size = new System.Drawing.Size(199, 36);
            this.btnDrafts.TabIndex = 1;
            this.btnDrafts.Text = "Drafts";
            this.btnDrafts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrafts.UseVisualStyleBackColor = true;
            // 
            // btnInbox
            // 
            this.btnInbox.AutoSize = true;
            this.btnInbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInbox.Depth = 0;
            this.btnInbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInbox.Icon = null;
            this.btnInbox.Location = new System.Drawing.Point(0, 0);
            this.btnInbox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Primary = false;
            this.btnInbox.Size = new System.Drawing.Size(199, 36);
            this.btnInbox.TabIndex = 0;
            this.btnInbox.Text = "Inbox (234)";
            this.btnInbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInbox.UseVisualStyleBackColor = true;
            // 
            // tabWriteEmail
            // 
            this.tabWriteEmail.Controls.Add(this.writeEmailButtonHolder);
            this.tabWriteEmail.Controls.Add(this.richTextBox1);
            this.tabWriteEmail.Controls.Add(this.writeEmailFieldHolder);
            this.tabWriteEmail.Location = new System.Drawing.Point(4, 22);
            this.tabWriteEmail.Name = "tabWriteEmail";
            this.tabWriteEmail.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tabWriteEmail.Size = new System.Drawing.Size(1073, 608);
            this.tabWriteEmail.TabIndex = 2;
            this.tabWriteEmail.Text = "WRITE EMAIL";
            this.tabWriteEmail.UseVisualStyleBackColor = true;
            // 
            // txtMailFrom
            // 
            this.txtMailFrom.Depth = 0;
            this.txtMailFrom.Hint = "";
            this.txtMailFrom.Location = new System.Drawing.Point(72, 38);
            this.txtMailFrom.MaxLength = 32767;
            this.txtMailFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMailFrom.Name = "txtMailFrom";
            this.txtMailFrom.PasswordChar = '\0';
            this.txtMailFrom.SelectedText = "";
            this.txtMailFrom.SelectionLength = 0;
            this.txtMailFrom.SelectionStart = 0;
            this.txtMailFrom.Size = new System.Drawing.Size(208, 23);
            this.txtMailFrom.TabIndex = 4;
            this.txtMailFrom.TabStop = false;
            this.txtMailFrom.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(22, 42);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(44, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "From";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(286, 42);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(27, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "To";
            // 
            // txtMailTo
            // 
            this.txtMailTo.Depth = 0;
            this.txtMailTo.Hint = "";
            this.txtMailTo.Location = new System.Drawing.Point(319, 38);
            this.txtMailTo.MaxLength = 32767;
            this.txtMailTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMailTo.Name = "txtMailTo";
            this.txtMailTo.PasswordChar = '\0';
            this.txtMailTo.SelectedText = "";
            this.txtMailTo.SelectionLength = 0;
            this.txtMailTo.SelectionStart = 0;
            this.txtMailTo.Size = new System.Drawing.Size(208, 23);
            this.txtMailTo.TabIndex = 5;
            this.txtMailTo.TabStop = false;
            this.txtMailTo.UseSystemPasswordChar = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLogOut.Depth = 0;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Icon = null;
            this.btnLogOut.Location = new System.Drawing.Point(0, 621);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Primary = false;
            this.btnLogOut.Size = new System.Drawing.Size(199, 36);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.AutoSize = true;
            this.btnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettings.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSettings.Depth = 0;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.Icon = null;
            this.btnSettings.Location = new System.Drawing.Point(0, 585);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Primary = false;
            this.btnSettings.Size = new System.Drawing.Size(199, 36);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "SETTINGS";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // txtMailSubject
            // 
            this.txtMailSubject.Depth = 0;
            this.txtMailSubject.Hint = "";
            this.txtMailSubject.Location = new System.Drawing.Point(72, 76);
            this.txtMailSubject.MaxLength = 32767;
            this.txtMailSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMailSubject.Name = "txtMailSubject";
            this.txtMailSubject.PasswordChar = '\0';
            this.txtMailSubject.SelectedText = "";
            this.txtMailSubject.SelectionLength = 0;
            this.txtMailSubject.SelectionStart = 0;
            this.txtMailSubject.Size = new System.Drawing.Size(455, 23);
            this.txtMailSubject.TabIndex = 6;
            this.txtMailSubject.TabStop = false;
            this.txtMailSubject.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(7, 76);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(59, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Subject";
            // 
            // writeEmailFieldHolder
            // 
            this.writeEmailFieldHolder.Controls.Add(this.txtMailBcc);
            this.writeEmailFieldHolder.Controls.Add(this.materialLabel5);
            this.writeEmailFieldHolder.Controls.Add(this.txtMailCc);
            this.writeEmailFieldHolder.Controls.Add(this.materialLabel4);
            this.writeEmailFieldHolder.Controls.Add(this.txtMailSubject);
            this.writeEmailFieldHolder.Controls.Add(this.txtMailFrom);
            this.writeEmailFieldHolder.Controls.Add(this.materialLabel3);
            this.writeEmailFieldHolder.Controls.Add(this.materialLabel1);
            this.writeEmailFieldHolder.Controls.Add(this.materialLabel2);
            this.writeEmailFieldHolder.Controls.Add(this.txtMailTo);
            this.writeEmailFieldHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.writeEmailFieldHolder.Location = new System.Drawing.Point(10, 0);
            this.writeEmailFieldHolder.Name = "writeEmailFieldHolder";
            this.writeEmailFieldHolder.Size = new System.Drawing.Size(1053, 122);
            this.writeEmailFieldHolder.TabIndex = 11;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(533, 76);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(27, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Cc";
            // 
            // txtMailCc
            // 
            this.txtMailCc.Depth = 0;
            this.txtMailCc.Hint = "";
            this.txtMailCc.Location = new System.Drawing.Point(566, 76);
            this.txtMailCc.MaxLength = 32767;
            this.txtMailCc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMailCc.Name = "txtMailCc";
            this.txtMailCc.PasswordChar = '\0';
            this.txtMailCc.SelectedText = "";
            this.txtMailCc.SelectionLength = 0;
            this.txtMailCc.SelectionStart = 0;
            this.txtMailCc.Size = new System.Drawing.Size(208, 23);
            this.txtMailCc.TabIndex = 6;
            this.txtMailCc.TabStop = false;
            this.txtMailCc.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(780, 76);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(34, 19);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "Bcc";
            // 
            // txtMailBcc
            // 
            this.txtMailBcc.Depth = 0;
            this.txtMailBcc.Hint = "";
            this.txtMailBcc.Location = new System.Drawing.Point(820, 72);
            this.txtMailBcc.MaxLength = 32767;
            this.txtMailBcc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMailBcc.Name = "txtMailBcc";
            this.txtMailBcc.PasswordChar = '\0';
            this.txtMailBcc.SelectedText = "";
            this.txtMailBcc.SelectionLength = 0;
            this.txtMailBcc.SelectionStart = 0;
            this.txtMailBcc.Size = new System.Drawing.Size(208, 23);
            this.txtMailBcc.TabIndex = 7;
            this.txtMailBcc.TabStop = false;
            this.txtMailBcc.UseSystemPasswordChar = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(10, 122);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1053, 486);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // writeEmailButtonHolder
            // 
            this.writeEmailButtonHolder.Controls.Add(this.btnSendMail);
            this.writeEmailButtonHolder.Controls.Add(this.btnSaveDraft);
            this.writeEmailButtonHolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.writeEmailButtonHolder.Location = new System.Drawing.Point(10, 560);
            this.writeEmailButtonHolder.Name = "writeEmailButtonHolder";
            this.writeEmailButtonHolder.Size = new System.Drawing.Size(1053, 48);
            this.writeEmailButtonHolder.TabIndex = 13;
            // 
            // btnSendMail
            // 
            this.btnSendMail.AutoSize = true;
            this.btnSendMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSendMail.BackColor = System.Drawing.Color.Silver;
            this.btnSendMail.Depth = 0;
            this.btnSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSendMail.Icon = null;
            this.btnSendMail.Location = new System.Drawing.Point(957, 6);
            this.btnSendMail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSendMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Primary = false;
            this.btnSendMail.Size = new System.Drawing.Size(92, 36);
            this.btnSendMail.TabIndex = 8;
            this.btnSendMail.Text = "SEND MAIL";
            this.btnSendMail.UseVisualStyleBackColor = false;
            // 
            // btnSaveDraft
            // 
            this.btnSaveDraft.AutoSize = true;
            this.btnSaveDraft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveDraft.BackColor = System.Drawing.Color.Silver;
            this.btnSaveDraft.Depth = 0;
            this.btnSaveDraft.Icon = null;
            this.btnSaveDraft.Location = new System.Drawing.Point(827, 6);
            this.btnSaveDraft.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveDraft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveDraft.Name = "btnSaveDraft";
            this.btnSaveDraft.Primary = true;
            this.btnSaveDraft.Size = new System.Drawing.Size(122, 36);
            this.btnSaveDraft.TabIndex = 10;
            this.btnSaveDraft.Text = "SAVE AS DRAFT";
            this.btnSaveDraft.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.emailWriteTab);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.tabSelector);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(0, 63, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lakatos Krisztián (lakatos.krisz.23@citromail.hu)";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.emailWriteTab.ResumeLayout(false);
            this.tabInbox.ResumeLayout(false);
            this.tabMail.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabWriteEmail.ResumeLayout(false);
            this.writeEmailFieldHolder.ResumeLayout(false);
            this.writeEmailFieldHolder.PerformLayout();
            this.writeEmailButtonHolder.ResumeLayout(false);
            this.writeEmailButtonHolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private MaterialSkin.Controls.MaterialTabControl emailWriteTab;
        private System.Windows.Forms.TabPage tabInbox;
        private System.Windows.Forms.TabPage tabMail;
        private MaterialSkin.Controls.MaterialListView emailListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.WebBrowser emailWebBrowser;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton btnInbox;
        private MaterialSkin.Controls.MaterialFlatButton btnSpam;
        private MaterialSkin.Controls.MaterialFlatButton btnStarred;
        private MaterialSkin.Controls.MaterialFlatButton btnDrafts;
        private System.Windows.Forms.TabPage tabWriteEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMailFrom;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMailTo;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton btnLogOut;
        private MaterialSkin.Controls.MaterialFlatButton btnSettings;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMailSubject;
        private System.Windows.Forms.Panel writeEmailFieldHolder;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMailBcc;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMailCc;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel writeEmailButtonHolder;
        private MaterialSkin.Controls.MaterialFlatButton btnSendMail;
        private MaterialSkin.Controls.MaterialFlatButton btnSaveDraft;
    }
}