namespace SaintSender
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.inboxTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mailDataGridView = new System.Windows.Forms.DataGridView();
            this.icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mailWebBrowser = new System.Windows.Forms.WebBrowser();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.menuList = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.inboxTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inboxTab
            // 
            this.inboxTab.Controls.Add(this.tabPage1);
            this.inboxTab.Controls.Add(this.tabPage2);
            this.inboxTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inboxTab.Location = new System.Drawing.Point(0, 0);
            this.inboxTab.Margin = new System.Windows.Forms.Padding(2);
            this.inboxTab.Name = "inboxTab";
            this.inboxTab.SelectedIndex = 0;
            this.inboxTab.Size = new System.Drawing.Size(525, 444);
            this.inboxTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCheckBox1);
            this.tabPage1.Controls.Add(this.materialFlatButton1);
            this.tabPage1.Controls.Add(this.mailDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(517, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inbox";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mailDataGridView
            // 
            this.mailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mailDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.mailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.icon,
            this.title,
            this.date,
            this.from});
            this.mailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailDataGridView.GridColor = System.Drawing.Color.White;
            this.mailDataGridView.Location = new System.Drawing.Point(2, 2);
            this.mailDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.mailDataGridView.Name = "mailDataGridView";
            this.mailDataGridView.RowHeadersWidth = 4;
            this.mailDataGridView.RowTemplate.Height = 24;
            this.mailDataGridView.Size = new System.Drawing.Size(513, 414);
            this.mailDataGridView.TabIndex = 0;
            this.mailDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // icon
            // 
            this.icon.HeaderText = "";
            this.icon.Name = "icon";
            this.icon.ReadOnly = true;
            this.icon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.icon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.icon.Width = 21;
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 52;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 55;
            // 
            // from
            // 
            this.from.HeaderText = "From";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            this.from.Width = 55;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mailWebBrowser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(517, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rosszlanyok.hu regisztration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mailWebBrowser
            // 
            this.mailWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailWebBrowser.Location = new System.Drawing.Point(2, 2);
            this.mailWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.mailWebBrowser.Name = "mailWebBrowser";
            this.mailWebBrowser.Size = new System.Drawing.Size(513, 414);
            this.mailWebBrowser.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.menuList);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.splitContainer.Panel1MinSize = 100;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.inboxTab);
            this.splitContainer.Size = new System.Drawing.Size(791, 444);
            this.splitContainer.SplitterDistance = 263;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 1;
            // 
            // menuList
            // 
            this.menuList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuList.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuList.ForeColor = System.Drawing.SystemColors.MenuText;
            this.menuList.FormattingEnabled = true;
            this.menuList.ItemHeight = 21;
            this.menuList.Items.AddRange(new object[] {
            "Inbox (234)",
            "Spam",
            "Starred"});
            this.menuList.Location = new System.Drawing.Point(4, 4);
            this.menuList.Margin = new System.Windows.Forms.Padding(2);
            this.menuList.MultiColumn = true;
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(259, 440);
            this.menuList.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(791, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "FIle";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(119, 223);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(181, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "materialFlatButton1";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(119, 132);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(150, 30);
            this.materialCheckBox1.TabIndex = 2;
            this.materialCheckBox1.Text = "materialCheckBox1";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 469);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inboxTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl inboxTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView mailDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ListBox menuList;
        private System.Windows.Forms.WebBrowser mailWebBrowser;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
    }
}

