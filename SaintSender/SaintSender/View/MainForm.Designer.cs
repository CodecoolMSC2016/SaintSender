using System;

namespace SaintSender.View
{
    partial class MainForm
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
            this.tabHolder = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSettings = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnLogOut = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSpam = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnStarred = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDrafts = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnInbox = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnWriteEmail = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.btnCloseTab = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabHolder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabHolder
            // 
            this.tabHolder.Controls.Add(this.tabPage1);
            this.tabHolder.Depth = 0;
            this.tabHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHolder.Location = new System.Drawing.Point(199, 86);
            this.tabHolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabHolder.Name = "tabHolder";
            this.tabHolder.SelectedIndex = 0;
            this.tabHolder.Size = new System.Drawing.Size(1081, 634);
            this.tabHolder.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1073, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.materialSingleLineTextField1);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSpam);
            this.panel1.Controls.Add(this.btnStarred);
            this.panel1.Controls.Add(this.btnDrafts);
            this.panel1.Controls.Add(this.btnInbox);
            this.panel1.Controls.Add(this.btnWriteEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 634);
            this.panel1.TabIndex = 3;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(0, 539);
            this.materialSingleLineTextField1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(199, 23);
            this.materialSingleLineTextField1.TabIndex = 6;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            this.materialSingleLineTextField1.TextChanged += new System.EventHandler(this.materialSingleLineTextField1_TextChanged);
            // 
            // btnSettings
            // 
            this.btnSettings.AutoSize = true;
            this.btnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettings.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSettings.Depth = 0;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.Icon = null;
            this.btnSettings.Location = new System.Drawing.Point(0, 562);
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
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLogOut.Depth = 0;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Icon = null;
            this.btnLogOut.Location = new System.Drawing.Point(0, 598);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Primary = false;
            this.btnLogOut.Size = new System.Drawing.Size(199, 36);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSpam
            // 
            this.btnSpam.AutoSize = true;
            this.btnSpam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSpam.Depth = 0;
            this.btnSpam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpam.Icon = null;
            this.btnSpam.Location = new System.Drawing.Point(0, 144);
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
            this.btnStarred.Location = new System.Drawing.Point(0, 108);
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
            this.btnDrafts.Location = new System.Drawing.Point(0, 72);
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
            this.btnInbox.Location = new System.Drawing.Point(0, 36);
            this.btnInbox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Primary = false;
            this.btnInbox.Size = new System.Drawing.Size(199, 36);
            this.btnInbox.TabIndex = 0;
            this.btnInbox.Text = "Inbox (234)";
            this.btnInbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInbox.UseVisualStyleBackColor = true;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // btnWriteEmail
            // 
            this.btnWriteEmail.AutoSize = true;
            this.btnWriteEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWriteEmail.Depth = 0;
            this.btnWriteEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWriteEmail.Icon = null;
            this.btnWriteEmail.Location = new System.Drawing.Point(0, 0);
            this.btnWriteEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWriteEmail.Name = "btnWriteEmail";
            this.btnWriteEmail.Primary = true;
            this.btnWriteEmail.Size = new System.Drawing.Size(199, 36);
            this.btnWriteEmail.TabIndex = 7;
            this.btnWriteEmail.Text = "WRITE EMAIL";
            this.btnWriteEmail.UseVisualStyleBackColor = true;
            this.btnWriteEmail.Click += new System.EventHandler(this.materialRaisedButton1_Click);
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
            this.tabSelector.BaseTabControl = this.tabHolder;
            this.tabSelector.Depth = 0;
            this.tabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSelector.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabSelector.Location = new System.Drawing.Point(0, 63);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(1280, 23);
            this.tabSelector.TabIndex = 4;
            this.tabSelector.Text = "tabSelector";
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTab.AutoSize = true;
            this.btnCloseTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseTab.Depth = 0;
            this.btnCloseTab.Icon = null;
            this.btnCloseTab.Location = new System.Drawing.Point(1184, 44);
            this.btnCloseTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.Primary = true;
            this.btnCloseTab.Size = new System.Drawing.Size(92, 36);
            this.btnCloseTab.TabIndex = 8;
            this.btnCloseTab.Text = "CLOSE TAB";
            this.btnCloseTab.UseVisualStyleBackColor = true;
            this.btnCloseTab.Click += new System.EventHandler(this.btnCloseTab_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnCloseTab);
            this.Controls.Add(this.tabHolder);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabSelector);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 63, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lakatos Krisztián (lakatos.krisz.23@citromail.hu)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabHolder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton btnInbox;
        private MaterialSkin.Controls.MaterialFlatButton btnSpam;
        private MaterialSkin.Controls.MaterialFlatButton btnStarred;
        private MaterialSkin.Controls.MaterialFlatButton btnDrafts;
        private MaterialSkin.Controls.MaterialFlatButton btnLogOut;
        private MaterialSkin.Controls.MaterialFlatButton btnSettings;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialTabControl tabHolder;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialRaisedButton btnWriteEmail;
        private MaterialSkin.Controls.MaterialRaisedButton btnCloseTab;
    }
}