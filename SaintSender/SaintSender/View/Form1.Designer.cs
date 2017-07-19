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
        /// the contents of  method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            .inboxTab = new System.Windows.Forms.TabControl();
            .tabPage1 = new System.Windows.Forms.TabPage();
            .mailDataGridView = new System.Windows.Forms.DataGridView();
            .icon = new System.Windows.Forms.DataGridViewImageColumn();
            .title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            .date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            .from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            .tabPage2 = new System.Windows.Forms.TabPage();
            .mailWebBrowser = new System.Windows.Forms.WebBrowser();
            .splitContainer = new System.Windows.Forms.SplitContainer();
            .menuList = new System.Windows.Forms.ListBox();
            .toolStrip1 = new System.Windows.Forms.ToolStrip();
            .toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            .materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            .materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            .inboxTab.SuspendLayout();
            .tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(.mailDataGridView)).BeginInit();
            .tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(.splitContainer)).BeginInit();
            .splitContainer.Panel1.SuspendLayout();
            .splitContainer.Panel2.SuspendLayout();
            .splitContainer.SuspendLayout();
            .toolStrip1.SuspendLayout();
            .SuspendLayout();
            // 
            // inboxTab
            // 
            .inboxTab.Controls.Add(.tabPage1);
            .inboxTab.Controls.Add(.tabPage2);
            .inboxTab.Dock = System.Windows.Forms.DockStyle.Fill;
            .inboxTab.Location = new System.Drawing.Point(0, 0);
            .inboxTab.Margin = new System.Windows.Forms.Padding(2);
            .inboxTab.Name = "inboxTab";
            .inboxTab.SelectedIndex = 0;
            .inboxTab.Size = new System.Drawing.Size(525, 444);
            .inboxTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            .tabPage1.Controls.Add(.materialCheckBox1);
            .tabPage1.Controls.Add(.materialFlatButton1);
            .tabPage1.Controls.Add(.mailDataGridView);
            .tabPage1.Location = new System.Drawing.Point(4, 22);
            .tabPage1.Margin = new System.Windows.Forms.Padding(2);
            .tabPage1.Name = "tabPage1";
            .tabPage1.Padding = new System.Windows.Forms.Padding(2);
            .tabPage1.Size = new System.Drawing.Size(517, 418);
            .tabPage1.TabIndex = 0;
            .tabPage1.Text = "Inbox";
            .tabPage1.UseVisualStyleBackColor = true;
            // 
            // mailDataGridView
            // 
            .mailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            .mailDataGridView.BackgroundColor = System.Drawing.Color.White;
            .mailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            .mailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            .icon,
            .title,
            .date,
            .from});
            .mailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            .mailDataGridView.GridColor = System.Drawing.Color.White;
            .mailDataGridView.Location = new System.Drawing.Point(2, 2);
            .mailDataGridView.Margin = new System.Windows.Forms.Padding(2);
            .mailDataGridView.Name = "mailDataGridView";
            .mailDataGridView.RowHeadersWidth = 4;
            .mailDataGridView.RowTemplate.Height = 24;
            .mailDataGridView.Size = new System.Drawing.Size(513, 414);
            .mailDataGridView.TabIndex = 0;
            .mailDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(.dataGridView1_CellContentClick);
            // 
            // icon
            // 
            .icon.HeaderText = "";
            .icon.Name = "icon";
            .icon.ReadOnly = true;
            .icon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            .icon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            .icon.Width = 21;
            // 
            // title
            // 
            .title.HeaderText = "Title";
            .title.Name = "title";
            .title.ReadOnly = true;
            .title.Width = 52;
            // 
            // date
            // 
            .date.HeaderText = "Date";
            .date.Name = "date";
            .date.ReadOnly = true;
            .date.Width = 55;
            // 
            // from
            // 
            .from.HeaderText = "From";
            .from.Name = "from";
            .from.ReadOnly = true;
            .from.Width = 55;
            // 
            // tabPage2
            // 
            .tabPage2.Controls.Add(.mailWebBrowser);
            .tabPage2.Location = new System.Drawing.Point(4, 22);
            .tabPage2.Margin = new System.Windows.Forms.Padding(2);
            .tabPage2.Name = "tabPage2";
            .tabPage2.Padding = new System.Windows.Forms.Padding(2);
            .tabPage2.Size = new System.Drawing.Size(517, 418);
            .tabPage2.TabIndex = 1;
            .tabPage2.Text = "Rosszlanyok.hu regisztration";
            .tabPage2.UseVisualStyleBackColor = true;
            // 
            // mailWebBrowser
            // 
            .mailWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            .mailWebBrowser.Location = new System.Drawing.Point(2, 2);
            .mailWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            .mailWebBrowser.Name = "mailWebBrowser";
            .mailWebBrowser.Size = new System.Drawing.Size(513, 414);
            .mailWebBrowser.TabIndex = 0;
            // 
            // splitContainer
            // 
            .splitContainer.BackColor = System.Drawing.SystemColors.Control;
            .splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            .splitContainer.Location = new System.Drawing.Point(0, 25);
            .splitContainer.Margin = new System.Windows.Forms.Padding(2);
            .splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            .splitContainer.Panel1.Controls.Add(.menuList);
            .splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            .splitContainer.Panel1MinSize = 100;
            // 
            // splitContainer.Panel2
            // 
            .splitContainer.Panel2.Controls.Add(.inboxTab);
            .splitContainer.Size = new System.Drawing.Size(791, 444);
            .splitContainer.SplitterDistance = 263;
            .splitContainer.SplitterWidth = 3;
            .splitContainer.TabIndex = 1;
            // 
            // menuList
            // 
            .menuList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            .menuList.Dock = System.Windows.Forms.DockStyle.Fill;
            .menuList.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            .menuList.ForeColor = System.Drawing.SystemColors.MenuText;
            .menuList.FormattingEnabled = true;
            .menuList.ItemHeight = 21;
            .menuList.Items.AddRange(new object[] {
            "Inbox (234)",
            "Spam",
            "Starred"});
            .menuList.Location = new System.Drawing.Point(4, 4);
            .menuList.Margin = new System.Windows.Forms.Padding(2);
            .menuList.MultiColumn = true;
            .menuList.Name = "menuList";
            .menuList.Size = new System.Drawing.Size(259, 440);
            .menuList.TabIndex = 0;
            // 
            // toolStrip1
            // 
            .toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            .toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            .toolStripDropDownButton1});
            .toolStrip1.Location = new System.Drawing.Point(0, 0);
            .toolStrip1.Name = "toolStrip1";
            .toolStrip1.Size = new System.Drawing.Size(791, 25);
            .toolStrip1.TabIndex = 2;
            .toolStrip1.Text = "toolStrip1";
            .toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton1
            // 
            .toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            .toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            .toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            .toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            .toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            .toolStripDropDownButton1.Text = "FIle";
            // 
            // materialFlatButton1
            // 
            .materialFlatButton1.AutoSize = true;
            .materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            .materialFlatButton1.Depth = 0;
            .materialFlatButton1.Icon = null;
            .materialFlatButton1.Location = new System.Drawing.Point(119, 223);
            .materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            .materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            .materialFlatButton1.Name = "materialFlatButton1";
            .materialFlatButton1.Primary = false;
            .materialFlatButton1.Size = new System.Drawing.Size(181, 36);
            .materialFlatButton1.TabIndex = 1;
            .materialFlatButton1.Text = "materialFlatButton1";
            .materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox1
            // 
            .materialCheckBox1.AutoSize = true;
            .materialCheckBox1.Depth = 0;
            .materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            .materialCheckBox1.Location = new System.Drawing.Point(119, 132);
            .materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            .materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            .materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            .materialCheckBox1.Name = "materialCheckBox1";
            .materialCheckBox1.Ripple = true;
            .materialCheckBox1.Size = new System.Drawing.Size(150, 30);
            .materialCheckBox1.TabIndex = 2;
            .materialCheckBox1.Text = "materialCheckBox1";
            .materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            .AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            .AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            .ClientSize = new System.Drawing.Size(791, 469);
            .Controls.Add(.splitContainer);
            .Controls.Add(.toolStrip1);
            .FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            .Margin = new System.Windows.Forms.Padding(2);
            .Name = "formMain";
            .StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            .Text = "formMain";
            .Load += new System.EventHandler(.Form1_Load);
            .inboxTab.ResumeLayout(false);
            .tabPage1.ResumeLayout(false);
            .tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(.mailDataGridView)).EndInit();
            .tabPage2.ResumeLayout(false);
            .splitContainer.Panel1.ResumeLayout(false);
            .splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(.splitContainer)).EndInit();
            .splitContainer.ResumeLayout(false);
            .toolStrip1.ResumeLayout(false);
            .toolStrip1.PerformLayout();
            .ResumeLayout(false);
            .PerformLayout();

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

