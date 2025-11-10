namespace RevVise1.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel headerPanel;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button dashboardView;
        private System.Windows.Forms.Button catalogView;
        private System.Windows.Forms.Button logView;
        private System.Windows.Forms.Button settingView;
        private System.Windows.Forms.Button exitButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            headerPanel = new TableLayoutPanel();
            lblAppName = new Label();
            btnMaximize = new Button();
            btnClose = new Button();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            exitButton = new Button();
            settingView = new Button();
            logView = new Button();
            catalogView = new Button();
            dashboardView = new Button();
            contentPanel = new Panel();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(50, 50, 60);
            headerPanel.ColumnCount = 4;
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.25201F));
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.7479858F));
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            headerPanel.Controls.Add(lblAppName, 0, 0);
            headerPanel.Controls.Add(btnMaximize, 2, 0);
            headerPanel.Controls.Add(btnClose, 3, 0);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(0);
            headerPanel.Name = "headerPanel";
            headerPanel.RowCount = 1;
            headerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            headerPanel.Size = new Size(1200, 34);
            headerPanel.TabIndex = 0;
            headerPanel.MouseDown += HeaderPanel_MouseDown;
            // 
            // lblAppName
            // 
            lblAppName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAppName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(0, 0);
            lblAppName.Margin = new Padding(0);
            lblAppName.Name = "lblAppName";
            lblAppName.Padding = new Padding(15, 0, 0, 0);
            lblAppName.Size = new Size(249, 34);
            lblAppName.TabIndex = 3;
            lblAppName.Text = "RevVise";
            lblAppName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.FromArgb(90, 90, 100);
            btnMaximize.Dock = DockStyle.Fill;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1119, 0);
            btnMaximize.Margin = new Padding(0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(40, 34);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "▢";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.Dock = DockStyle.Fill;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1159, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 34);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += button5_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 34);
            splitContainer1.Margin = new Padding(0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(45, 45, 55);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(60, 60, 70);
            splitContainer1.Panel2.Controls.Add(contentPanel);
            splitContainer1.Size = new Size(1200, 716);
            splitContainer1.SplitterDistance = 250;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(exitButton, 0, 5);
            tableLayoutPanel1.Controls.Add(settingView, 0, 4);
            tableLayoutPanel1.Controls.Add(logView, 0, 3);
            tableLayoutPanel1.Controls.Add(catalogView, 0, 2);
            tableLayoutPanel1.Controls.Add(dashboardView, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 404F));
            tableLayoutPanel1.Size = new Size(249, 716);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            exitButton.AutoSize = true;
            exitButton.BackColor = Color.FromArgb(70, 70, 90);
            exitButton.BackgroundImageLayout = ImageLayout.None;
            exitButton.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 90);
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 12F);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(0, 250);
            exitButton.Margin = new Padding(0, 0, 0, 10);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(249, 50);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.TextAlign = ContentAlignment.MiddleRight;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += button5_Click;
            // 
            // settingView
            // 
            settingView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            settingView.AutoSize = true;
            settingView.BackColor = Color.FromArgb(70, 70, 90);
            settingView.BackgroundImageLayout = ImageLayout.None;
            settingView.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 90);
            settingView.FlatAppearance.BorderSize = 0;
            settingView.FlatStyle = FlatStyle.Flat;
            settingView.Font = new Font("Segoe UI", 12F);
            settingView.ForeColor = Color.White;
            settingView.Location = new Point(0, 190);
            settingView.Margin = new Padding(0, 0, 0, 10);
            settingView.Name = "settingView";
            settingView.Size = new Size(249, 50);
            settingView.TabIndex = 3;
            settingView.Text = "Settings";
            settingView.TextAlign = ContentAlignment.MiddleRight;
            settingView.UseVisualStyleBackColor = false;
            settingView.Click += settingView_Click;
            // 
            // logView
            // 
            logView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logView.AutoSize = true;
            logView.BackColor = Color.FromArgb(70, 70, 90);
            logView.BackgroundImageLayout = ImageLayout.None;
            logView.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 90);
            logView.FlatAppearance.BorderSize = 0;
            logView.FlatStyle = FlatStyle.Flat;
            logView.Font = new Font("Segoe UI", 12F);
            logView.ForeColor = Color.White;
            logView.Location = new Point(0, 130);
            logView.Margin = new Padding(0, 0, 0, 10);
            logView.Name = "logView";
            logView.Size = new Size(249, 50);
            logView.TabIndex = 2;
            logView.Text = "Logs";
            logView.TextAlign = ContentAlignment.MiddleRight;
            logView.UseVisualStyleBackColor = false;
            logView.Click += logView_Click;
            // 
            // catalogView
            // 
            catalogView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            catalogView.AutoSize = true;
            catalogView.BackColor = Color.FromArgb(70, 70, 90);
            catalogView.BackgroundImageLayout = ImageLayout.None;
            catalogView.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 90);
            catalogView.FlatAppearance.BorderSize = 0;
            catalogView.FlatStyle = FlatStyle.Flat;
            catalogView.Font = new Font("Segoe UI", 12F);
            catalogView.ForeColor = Color.White;
            catalogView.Location = new Point(0, 70);
            catalogView.Margin = new Padding(0, 0, 0, 10);
            catalogView.Name = "catalogView";
            catalogView.Size = new Size(249, 50);
            catalogView.TabIndex = 1;
            catalogView.Text = "Catalog";
            catalogView.TextAlign = ContentAlignment.MiddleRight;
            catalogView.UseVisualStyleBackColor = false;
            catalogView.Click += catalogView_Click;
            // 
            // dashboardView
            // 
            dashboardView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboardView.AutoSize = true;
            dashboardView.BackColor = Color.FromArgb(70, 70, 90);
            dashboardView.BackgroundImageLayout = ImageLayout.None;
            dashboardView.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 90);
            dashboardView.FlatAppearance.BorderSize = 0;
            dashboardView.FlatStyle = FlatStyle.Flat;
            dashboardView.Font = new Font("Segoe UI", 12F);
            dashboardView.ForeColor = Color.White;
            dashboardView.Location = new Point(0, 10);
            dashboardView.Margin = new Padding(0, 0, 0, 10);
            dashboardView.Name = "dashboardView";
            dashboardView.Size = new Size(249, 50);
            dashboardView.TabIndex = 0;
            dashboardView.Text = "Dashboard";
            dashboardView.TextAlign = ContentAlignment.MiddleRight;
            dashboardView.UseVisualStyleBackColor = false;
            dashboardView.Click += dashboardView_Click;
            // 
            // contentPanel
            // 
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.BackColor = Color.FromArgb(244, 244, 244);
            contentPanel.Location = new Point(0, 0);
            contentPanel.Margin = new Padding(0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(949, 716);
            contentPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 50);
            ClientSize = new Size(1200, 750);
            Controls.Add(splitContainer1);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RevVise";
            headerPanel.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Label lblAppName;
        private Panel contentPanel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
