namespace RevVise1.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel headerPanel;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel sidebarPanel;
        private System.Windows.Forms.Button dashboardView;
        private System.Windows.Forms.Button catalogView;
        private System.Windows.Forms.Button logView;
        private System.Windows.Forms.Button settingView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel contentPanel;

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
            sidebarPanel = new FlowLayoutPanel();
            dashboardView = new Button();
            catalogView = new Button();
            logView = new Button();
            settingView = new Button();
            exitButton = new Button();
            contentPanel = new Panel();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            sidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(50, 50, 60);
            headerPanel.ColumnCount = 4;
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
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
            headerPanel.Size = new Size(1200, 60);
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
            lblAppName.Size = new Size(551, 60);
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
            btnMaximize.Location = new Point(1129, 20);
            btnMaximize.Margin = new Padding(10, 20, 10, 20);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(20, 20);
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
            btnClose.Location = new Point(1169, 20);
            btnClose.Margin = new Padding(10, 20, 10, 20);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(21, 20);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += button5_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 60);
            splitContainer1.Margin = new Padding(0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(45, 45, 55);
            splitContainer1.Panel1.Controls.Add(sidebarPanel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(60, 60, 70);
            splitContainer1.Panel2.Controls.Add(contentPanel);
            splitContainer1.Size = new Size(1200, 690);
            splitContainer1.SplitterDistance = 250;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 1;
            // 
            // sidebarPanel
            // 
            sidebarPanel.AutoSize = true;
            sidebarPanel.BackColor = Color.FromArgb(45, 45, 55);
            sidebarPanel.Controls.Add(dashboardView);
            sidebarPanel.Controls.Add(catalogView);
            sidebarPanel.Controls.Add(logView);
            sidebarPanel.Controls.Add(settingView);
            sidebarPanel.Controls.Add(exitButton);
            sidebarPanel.Dock = DockStyle.Fill;
            sidebarPanel.FlowDirection = FlowDirection.TopDown;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Padding = new Padding(0, 10, 10, 10);
            sidebarPanel.Size = new Size(250, 690);
            sidebarPanel.TabIndex = 0;
            // 
            // dashboardView
            // 
            dashboardView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dashboardView.AutoSize = true;
            dashboardView.BackColor = Color.FromArgb(70, 70, 90);
            dashboardView.BackgroundImageLayout = ImageLayout.None;
            dashboardView.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 90);
            dashboardView.FlatAppearance.BorderSize = 0;
            dashboardView.FlatStyle = FlatStyle.Flat;
            dashboardView.Font = new Font("Segoe UI", 12F);
            dashboardView.ForeColor = Color.White;
            dashboardView.Location = new Point(1, 20);
            dashboardView.Margin = new Padding(0, 10, 0, 20);
            dashboardView.Name = "dashboardView";
            dashboardView.Size = new Size(240, 51);
            dashboardView.TabIndex = 0;
            dashboardView.Text = "Dashboard";
            dashboardView.TextAlign = ContentAlignment.MiddleRight;
            dashboardView.UseVisualStyleBackColor = false;
            dashboardView.Click += dashboardView_Click;
            // 
            // catalogView
            // 
            catalogView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            catalogView.AutoSize = true;
            catalogView.BackColor = Color.FromArgb(70, 70, 90);
            catalogView.BackgroundImageLayout = ImageLayout.None;
            catalogView.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 90);
            catalogView.FlatAppearance.BorderSize = 0;
            catalogView.FlatStyle = FlatStyle.Flat;
            catalogView.Font = new Font("Segoe UI", 12F);
            catalogView.ForeColor = Color.White;
            catalogView.Location = new Point(1, 91);
            catalogView.Margin = new Padding(0, 0, 0, 20);
            catalogView.Name = "catalogView";
            catalogView.Size = new Size(240, 51);
            catalogView.TabIndex = 1;
            catalogView.Text = "Catalog";
            catalogView.TextAlign = ContentAlignment.MiddleRight;
            catalogView.UseVisualStyleBackColor = false;
            // 
            // logView
            // 
            logView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logView.AutoSize = true;
            logView.BackColor = Color.FromArgb(70, 70, 90);
            logView.BackgroundImageLayout = ImageLayout.None;
            logView.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 90);
            logView.FlatAppearance.BorderSize = 0;
            logView.FlatStyle = FlatStyle.Flat;
            logView.Font = new Font("Segoe UI", 12F);
            logView.ForeColor = Color.White;
            logView.Location = new Point(1, 162);
            logView.Margin = new Padding(0, 0, 0, 20);
            logView.Name = "logView";
            logView.Size = new Size(240, 51);
            logView.TabIndex = 2;
            logView.Text = "Logs";
            logView.TextAlign = ContentAlignment.MiddleRight;
            logView.UseVisualStyleBackColor = false;
            // 
            // settingView
            // 
            settingView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            settingView.AutoSize = true;
            settingView.BackColor = Color.FromArgb(70, 70, 90);
            settingView.BackgroundImageLayout = ImageLayout.None;
            settingView.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 90);
            settingView.FlatAppearance.BorderSize = 0;
            settingView.FlatStyle = FlatStyle.Flat;
            settingView.Font = new Font("Segoe UI", 12F);
            settingView.ForeColor = Color.White;
            settingView.Location = new Point(1, 233);
            settingView.Margin = new Padding(0, 0, 0, 20);
            settingView.Name = "settingView";
            settingView.Size = new Size(240, 51);
            settingView.TabIndex = 3;
            settingView.Text = "Settings";
            settingView.TextAlign = ContentAlignment.MiddleRight;
            settingView.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitButton.AutoSize = true;
            exitButton.BackColor = Color.FromArgb(70, 70, 90);
            exitButton.BackgroundImageLayout = ImageLayout.None;
            exitButton.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 90);
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 12F);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(0, 304);
            exitButton.Margin = new Padding(0, 0, 0, 20);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(241, 51);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.TextAlign = ContentAlignment.MiddleRight;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += button5_Click;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(244, 244, 244);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Margin = new Padding(0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(949, 690);
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
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Label lblAppName;
    }
}
