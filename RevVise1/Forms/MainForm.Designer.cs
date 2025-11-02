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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
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
            lblAppName.Dock = DockStyle.Fill;
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
            btnMaximize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1119, 10);
            btnMaximize.Margin = new Padding(0, 10, 0, 10);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(40, 40);
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
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1159, 10);
            btnClose.Margin = new Padding(0, 10, 10, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(31, 40);
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
            sidebarPanel.Controls.Add(button1);
            sidebarPanel.Controls.Add(button2);
            sidebarPanel.Controls.Add(button3);
            sidebarPanel.Controls.Add(button4);
            sidebarPanel.Controls.Add(button5);
            sidebarPanel.Dock = DockStyle.Fill;
            sidebarPanel.FlowDirection = FlowDirection.TopDown;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Padding = new Padding(10);
            sidebarPanel.Size = new Size(250, 690);
            sidebarPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(70, 70, 90);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(10, 10);
            button1.Margin = new Padding(0, 0, 0, 10);
            button1.Name = "button1";
            button1.Size = new Size(230, 45);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(70, 70, 90);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(10, 65);
            button2.Margin = new Padding(0, 0, 0, 10);
            button2.Name = "button2";
            button2.Size = new Size(230, 45);
            button2.TabIndex = 1;
            button2.Text = "Inventory";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.FromArgb(70, 70, 90);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(10, 120);
            button3.Margin = new Padding(0, 0, 0, 10);
            button3.Name = "button3";
            button3.Size = new Size(230, 45);
            button3.TabIndex = 2;
            button3.Text = "Reports";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.FromArgb(70, 70, 90);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(10, 175);
            button4.Margin = new Padding(0, 0, 0, 10);
            button4.Name = "button4";
            button4.Size = new Size(230, 45);
            button4.TabIndex = 3;
            button4.Text = "Settings";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = Color.FromArgb(70, 70, 90);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(10, 230);
            button5.Margin = new Padding(0, 0, 0, 10);
            button5.Name = "button5";
            button5.Size = new Size(230, 45);
            button5.TabIndex = 4;
            button5.Text = "Exit";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
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
