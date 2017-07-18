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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("salalalal");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("rtrturturtu");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabInbox = new System.Windows.Forms.TabPage();
            this.emailListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMail = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton7 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton8 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabControl1.SuspendLayout();
            this.tabInbox.SuspendLayout();
            this.tabMail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
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
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(199, 63);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(3, 300, 3, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Padding = new System.Windows.Forms.Padding(0, 300, 0, 0);
            this.materialTabSelector1.Size = new System.Drawing.Size(1081, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabInbox);
            this.materialTabControl1.Controls.Add(this.tabMail);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(199, 86);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1081, 634);
            this.materialTabControl1.TabIndex = 2;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
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
            this.tabMail.Controls.Add(this.webBrowser1);
            this.tabMail.Location = new System.Drawing.Point(4, 22);
            this.tabMail.Name = "tabMail";
            this.tabMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabMail.Size = new System.Drawing.Size(1073, 608);
            this.tabMail.TabIndex = 1;
            this.tabMail.Text = "Rosszlanyok.hu regisztracio";
            this.tabMail.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1067, 602);
            this.webBrowser1.TabIndex = 0;
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
            this.panel1.Controls.Add(this.materialFlatButton7);
            this.panel1.Controls.Add(this.materialFlatButton6);
            this.panel1.Controls.Add(this.materialFlatButton4);
            this.panel1.Controls.Add(this.materialFlatButton3);
            this.panel1.Controls.Add(this.materialFlatButton2);
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 657);
            this.panel1.TabIndex = 3;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(0, 108);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(199, 36);
            this.materialFlatButton4.TabIndex = 3;
            this.materialFlatButton4.Text = "Spam";
            this.materialFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(0, 72);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(199, 36);
            this.materialFlatButton3.TabIndex = 2;
            this.materialFlatButton3.Text = "Starred";
            this.materialFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(0, 36);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(199, 36);
            this.materialFlatButton2.TabIndex = 1;
            this.materialFlatButton2.Text = "Drafts";
            this.materialFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(199, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "Inbox (234)";
            this.materialFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tabPage1.Size = new System.Drawing.Size(1073, 608);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "WRITE EMAIL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(72, 38);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(208, 23);
            this.materialSingleLineTextField1.TabIndex = 4;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
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
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(319, 38);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(208, 23);
            this.materialSingleLineTextField2.TabIndex = 5;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialFlatButton6.Icon = null;
            this.materialFlatButton6.Location = new System.Drawing.Point(0, 621);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(199, 36);
            this.materialFlatButton6.TabIndex = 4;
            this.materialFlatButton6.Text = "LOG OUT";
            this.materialFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialFlatButton6.UseVisualStyleBackColor = false;
            // 
            // materialFlatButton7
            // 
            this.materialFlatButton7.AutoSize = true;
            this.materialFlatButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.materialFlatButton7.Depth = 0;
            this.materialFlatButton7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialFlatButton7.Icon = null;
            this.materialFlatButton7.Location = new System.Drawing.Point(0, 585);
            this.materialFlatButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton7.Name = "materialFlatButton7";
            this.materialFlatButton7.Primary = false;
            this.materialFlatButton7.Size = new System.Drawing.Size(199, 36);
            this.materialFlatButton7.TabIndex = 5;
            this.materialFlatButton7.Text = "SETTINGS";
            this.materialFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialFlatButton7.UseVisualStyleBackColor = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(72, 76);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(455, 23);
            this.materialSingleLineTextField3.TabIndex = 6;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.materialSingleLineTextField5);
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Controls.Add(this.materialSingleLineTextField4);
            this.panel2.Controls.Add(this.materialLabel4);
            this.panel2.Controls.Add(this.materialSingleLineTextField3);
            this.panel2.Controls.Add(this.materialSingleLineTextField1);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.materialSingleLineTextField2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 122);
            this.panel2.TabIndex = 11;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(533, 76);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(27, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Cc";
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(566, 76);
            this.materialSingleLineTextField4.MaxLength = 32767;
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(208, 23);
            this.materialSingleLineTextField4.TabIndex = 6;
            this.materialSingleLineTextField4.TabStop = false;
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(780, 76);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(34, 19);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "Bcc";
            // 
            // materialSingleLineTextField5
            // 
            this.materialSingleLineTextField5.Depth = 0;
            this.materialSingleLineTextField5.Hint = "";
            this.materialSingleLineTextField5.Location = new System.Drawing.Point(820, 72);
            this.materialSingleLineTextField5.MaxLength = 32767;
            this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
            this.materialSingleLineTextField5.PasswordChar = '\0';
            this.materialSingleLineTextField5.SelectedText = "";
            this.materialSingleLineTextField5.SelectionLength = 0;
            this.materialSingleLineTextField5.SelectionStart = 0;
            this.materialSingleLineTextField5.Size = new System.Drawing.Size(208, 23);
            this.materialSingleLineTextField5.TabIndex = 7;
            this.materialSingleLineTextField5.TabStop = false;
            this.materialSingleLineTextField5.UseSystemPasswordChar = false;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.materialFlatButton5);
            this.panel3.Controls.Add(this.materialFlatButton8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 560);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1053, 48);
            this.panel3.TabIndex = 13;
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.BackColor = System.Drawing.Color.Silver;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.materialFlatButton5.Icon = null;
            this.materialFlatButton5.Location = new System.Drawing.Point(957, 6);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(92, 36);
            this.materialFlatButton5.TabIndex = 8;
            this.materialFlatButton5.Text = "SEND MAIL";
            this.materialFlatButton5.UseVisualStyleBackColor = false;
            // 
            // materialFlatButton8
            // 
            this.materialFlatButton8.AutoSize = true;
            this.materialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton8.BackColor = System.Drawing.Color.Silver;
            this.materialFlatButton8.Depth = 0;
            this.materialFlatButton8.Icon = null;
            this.materialFlatButton8.Location = new System.Drawing.Point(827, 6);
            this.materialFlatButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton8.Name = "materialFlatButton8";
            this.materialFlatButton8.Primary = true;
            this.materialFlatButton8.Size = new System.Drawing.Size(122, 36);
            this.materialFlatButton8.TabIndex = 10;
            this.materialFlatButton8.Text = "SAVE AS DRAFT";
            this.materialFlatButton8.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(0, 63, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lakatos Krisztián (lakatos.krisz.23@citromail.hu)";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabInbox.ResumeLayout(false);
            this.tabMail.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabInbox;
        private System.Windows.Forms.TabPage tabMail;
        private MaterialSkin.Controls.MaterialListView emailListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton7;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton8;
    }
}