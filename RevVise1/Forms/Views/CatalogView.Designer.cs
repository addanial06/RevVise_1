namespace RevVise1.Forms.Views
{
    partial class CatalogView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            sortStrip = new MenuStrip();
            sortByToolStripMenuItem = new ToolStripMenuItem();
            iDToolStripMenuItem = new ToolStripMenuItem();
            modelToolStripMenuItem = new ToolStripMenuItem();
            ownerToolStripMenuItem = new ToolStripMenuItem();
            plateStripMenuItem = new ToolStripMenuItem();
            resolvedToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            panel5 = new Panel();
            searchLabel = new Label();
            sortStrip2 = new MenuStrip();
            sortStripMenu = new ToolStripMenuItem();
            panel4 = new Panel();
            searchBox = new TextBox();
            panel3 = new Panel();
            addButton = new Button();
            dashboardLabel = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel6 = new Panel();
            idSort = new Button();
            panel7 = new Panel();
            modelSort = new Button();
            panel8 = new Panel();
            ownerSort = new Button();
            panel9 = new Panel();
            plateSort = new Button();
            panel10 = new Panel();
            owner2Sort = new Button();
            panel11 = new Panel();
            statusSort = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            sortStrip.SuspendLayout();
            panel5.SuspendLayout();
            sortStrip2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 632F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 246F));
            tableLayoutPanel1.Controls.Add(panel2);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(931, 150);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(sortStrip);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(searchBox);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(dashboardLabel);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(632, 150);
            panel2.TabIndex = 0;
            // 
            // sortStrip
            // 
            sortStrip.BackColor = Color.LightGray;
            sortStrip.Dock = DockStyle.None;
            sortStrip.Items.AddRange(new ToolStripItem[] { sortByToolStripMenuItem, toolStripMenuItem4, toolStripMenuItem5 });
            sortStrip.Location = new Point(541, 88);
            sortStrip.Name = "sortStrip";
            sortStrip.Size = new Size(62, 24);
            sortStrip.TabIndex = 0;
            sortStrip.Text = "menuStrip1";
            // 
            // sortByToolStripMenuItem
            // 
            sortByToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iDToolStripMenuItem, modelToolStripMenuItem, ownerToolStripMenuItem, plateStripMenuItem, resolvedToolStripMenuItem });
            sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            sortByToolStripMenuItem.Size = new Size(30, 20);
            sortByToolStripMenuItem.Text = "ID";
            // 
            // iDToolStripMenuItem
            // 
            iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            iDToolStripMenuItem.Size = new Size(122, 22);
            iDToolStripMenuItem.Text = "ID";
            iDToolStripMenuItem.Click += iDToolStripMenuItem_Click;
            // 
            // modelToolStripMenuItem
            // 
            modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            modelToolStripMenuItem.Size = new Size(122, 22);
            modelToolStripMenuItem.Text = "Model";
            modelToolStripMenuItem.Click += modelToolStripMenuItem_Click;
            // 
            // ownerToolStripMenuItem
            // 
            ownerToolStripMenuItem.Name = "ownerToolStripMenuItem";
            ownerToolStripMenuItem.Size = new Size(122, 22);
            ownerToolStripMenuItem.Text = "Owner";
            ownerToolStripMenuItem.Click += ownerToolStripMenuItem_Click;
            // 
            // plateStripMenuItem
            // 
            plateStripMenuItem.Name = "plateStripMenuItem";
            plateStripMenuItem.Size = new Size(122, 22);
            plateStripMenuItem.Text = "Plate No.";
            plateStripMenuItem.Click += plateStripMenuItem_Click;
            // 
            // resolvedToolStripMenuItem
            // 
            resolvedToolStripMenuItem.Name = "resolvedToolStripMenuItem";
            resolvedToolStripMenuItem.Size = new Size(122, 22);
            resolvedToolStripMenuItem.Text = "Resolved";
            resolvedToolStripMenuItem.Click += resolvedToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Enabled = false;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.ShowShortcutKeys = false;
            toolStripMenuItem4.Size = new Size(12, 20);
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Enabled = false;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.ShowShortcutKeys = false;
            toolStripMenuItem5.Size = new Size(12, 20);
            // 
            // panel5
            // 
            panel5.Controls.Add(searchLabel);
            panel5.Controls.Add(sortStrip2);
            panel5.Location = new Point(148, 88);
            panel5.Name = "panel5";
            panel5.Size = new Size(464, 25);
            panel5.TabIndex = 3;
            // 
            // searchLabel
            // 
            searchLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            searchLabel.Location = new Point(0, 0);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(42, 25);
            searchLabel.TabIndex = 1;
            searchLabel.Text = "Search";
            searchLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sortStrip2
            // 
            sortStrip2.BackColor = Color.LightGray;
            sortStrip2.BackgroundImageLayout = ImageLayout.None;
            sortStrip2.Dock = DockStyle.None;
            sortStrip2.Items.AddRange(new ToolStripItem[] { sortStripMenu });
            sortStrip2.Location = new Point(303, 0);
            sortStrip2.Name = "sortStrip2";
            sortStrip2.Size = new Size(83, 24);
            sortStrip2.TabIndex = 0;
            sortStrip2.Text = "menuStrip1";
            sortStrip2.ItemClicked += sortStrip2_ItemClicked;
            // 
            // sortStripMenu
            // 
            sortStripMenu.BackColor = Color.LightGray;
            sortStripMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            sortStripMenu.Name = "sortStripMenu";
            sortStripMenu.Size = new Size(75, 20);
            sortStripMenu.Text = "Ascending";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(134, 99);
            panel4.Name = "panel4";
            panel4.Size = new Size(3, 32);
            panel4.TabIndex = 2;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(148, 113);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(464, 23);
            searchBox.TabIndex = 2;
            searchBox.KeyDown += searchBox_KeyDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(11, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(601, 3);
            panel3.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Left;
            addButton.Location = new Point(11, 95);
            addButton.Name = "addButton";
            addButton.Size = new Size(114, 43);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButtonClick;
            // 
            // dashboardLabel
            // 
            dashboardLabel.AutoSize = true;
            dashboardLabel.BackColor = Color.Transparent;
            dashboardLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardLabel.ForeColor = Color.DimGray;
            dashboardLabel.Location = new Point(10, 9);
            dashboardLabel.Name = "dashboardLabel";
            dashboardLabel.Size = new Size(190, 65);
            dashboardLabel.TabIndex = 0;
            dashboardLabel.Text = "Catalog";
            dashboardLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(3, 194);
            panel1.Margin = new Padding(3, 0, 3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 0, 3, 3);
            panel1.Size = new Size(931, 452);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(0, 0, 0, 3);
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 156F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(937, 652);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 7;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel3.Controls.Add(panel6, 0, 0);
            tableLayoutPanel3.Controls.Add(panel7, 1, 0);
            tableLayoutPanel3.Controls.Add(panel8, 2, 0);
            tableLayoutPanel3.Controls.Add(panel9, 3, 0);
            tableLayoutPanel3.Controls.Add(panel10, 4, 0);
            tableLayoutPanel3.Controls.Add(panel11, 5, 0);
            tableLayoutPanel3.Location = new Point(3, 159);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(931, 31);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(idSort);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(44, 25);
            panel6.TabIndex = 0;
            // 
            // idSort
            // 
            idSort.BackColor = Color.LightGray;
            idSort.Dock = DockStyle.Fill;
            idSort.FlatStyle = FlatStyle.Popup;
            idSort.Location = new Point(0, 0);
            idSort.Name = "idSort";
            idSort.Size = new Size(44, 25);
            idSort.TabIndex = 0;
            idSort.Text = "ID";
            idSort.UseVisualStyleBackColor = false;
            idSort.Click += idSort_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(modelSort);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(53, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(151, 25);
            panel7.TabIndex = 1;
            // 
            // modelSort
            // 
            modelSort.BackColor = Color.LightGray;
            modelSort.Dock = DockStyle.Fill;
            modelSort.FlatStyle = FlatStyle.Popup;
            modelSort.Location = new Point(0, 0);
            modelSort.Name = "modelSort";
            modelSort.Size = new Size(151, 25);
            modelSort.TabIndex = 1;
            modelSort.Text = "Model";
            modelSort.TextAlign = ContentAlignment.MiddleLeft;
            modelSort.UseVisualStyleBackColor = false;
            modelSort.Click += modelSort_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(ownerSort);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(210, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(151, 25);
            panel8.TabIndex = 2;
            // 
            // ownerSort
            // 
            ownerSort.BackColor = Color.LightGray;
            ownerSort.Dock = DockStyle.Fill;
            ownerSort.FlatStyle = FlatStyle.Popup;
            ownerSort.Location = new Point(0, 0);
            ownerSort.Name = "ownerSort";
            ownerSort.Size = new Size(151, 25);
            ownerSort.TabIndex = 1;
            ownerSort.Text = "Owner";
            ownerSort.TextAlign = ContentAlignment.MiddleLeft;
            ownerSort.UseVisualStyleBackColor = false;
            ownerSort.Click += ownerSort_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(plateSort);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(367, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(151, 25);
            panel9.TabIndex = 3;
            // 
            // plateSort
            // 
            plateSort.BackColor = Color.LightGray;
            plateSort.Dock = DockStyle.Fill;
            plateSort.FlatStyle = FlatStyle.Popup;
            plateSort.Location = new Point(0, 0);
            plateSort.Name = "plateSort";
            plateSort.Size = new Size(151, 25);
            plateSort.TabIndex = 1;
            plateSort.Text = "Plate No.";
            plateSort.TextAlign = ContentAlignment.MiddleLeft;
            plateSort.UseVisualStyleBackColor = false;
            plateSort.Click += plateSort_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(owner2Sort);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(524, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(151, 25);
            panel10.TabIndex = 4;
            // 
            // owner2Sort
            // 
            owner2Sort.BackColor = Color.LightGray;
            owner2Sort.Dock = DockStyle.Fill;
            owner2Sort.FlatStyle = FlatStyle.Popup;
            owner2Sort.Location = new Point(0, 0);
            owner2Sort.Name = "owner2Sort";
            owner2Sort.Size = new Size(151, 25);
            owner2Sort.TabIndex = 1;
            owner2Sort.Text = "Owner2";
            owner2Sort.TextAlign = ContentAlignment.MiddleLeft;
            owner2Sort.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            panel11.Controls.Add(statusSort);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(681, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(151, 25);
            panel11.TabIndex = 5;
            // 
            // statusSort
            // 
            statusSort.BackColor = Color.LightGray;
            statusSort.Dock = DockStyle.Fill;
            statusSort.FlatStyle = FlatStyle.Popup;
            statusSort.Location = new Point(0, 0);
            statusSort.Name = "statusSort";
            statusSort.Size = new Size(151, 25);
            statusSort.TabIndex = 1;
            statusSort.Text = "Status";
            statusSort.TextAlign = ContentAlignment.MiddleLeft;
            statusSort.UseVisualStyleBackColor = false;
            statusSort.Click += statusSort_Click;
            // 
            // CatalogView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "CatalogView";
            Size = new Size(937, 655);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            sortStrip.ResumeLayout(false);
            sortStrip.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            sortStrip2.ResumeLayout(false);
            sortStrip2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label dashboardLabel;
        private Panel panel1;
        private Button addButton;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private TextBox searchBox;
        private Panel panel4;
        private Panel panel5;
        private MenuStrip sortStrip;
        private ToolStripMenuItem sortByToolStripMenuItem;
        private ToolStripMenuItem iDToolStripMenuItem;
        private ToolStripMenuItem modelToolStripMenuItem;
        private ToolStripMenuItem ownerToolStripMenuItem;
        private ToolStripMenuItem resolvedToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private MenuStrip sortStrip2;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem sortStripMenu;
        private ToolStripMenuItem plateStripMenuItem;
        private Label searchLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel6;
        private Button idSort;
        private Panel panel7;
        private Button modelSort;
        private Panel panel8;
        private Button ownerSort;
        private Panel panel9;
        private Button plateSort;
        private Panel panel10;
        private Button owner2Sort;
        private Panel panel11;
        private Button statusSort;
    }
}
