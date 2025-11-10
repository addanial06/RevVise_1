namespace RevVise1.Forms
{
    partial class AuthForm
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
            LoginButton = new Button();
            LogoText = new Label();
            PasswordField = new TextBox();
            UsernameField = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Top;
            LoginButton.Location = new Point(38, 250);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(86, 27);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += button1_Click_1;
            // 
            // LogoText
            // 
            LogoText.Anchor = AnchorStyles.Top;
            LogoText.AutoSize = true;
            LogoText.FlatStyle = FlatStyle.Popup;
            LogoText.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoText.Location = new Point(38, 108);
            LogoText.Margin = new Padding(3, 70, 3, 0);
            LogoText.Name = "LogoText";
            LogoText.Size = new Size(167, 50);
            LogoText.TabIndex = 1;
            LogoText.Text = "Rev Vise";
            LogoText.TextAlign = ContentAlignment.TopCenter;
            LogoText.Click += Authentication_Click;
            // 
            // PasswordField
            // 
            PasswordField.Anchor = AnchorStyles.Top;
            PasswordField.Location = new Point(38, 208);
            PasswordField.Name = "PasswordField";
            PasswordField.PlaceholderText = "Password";
            PasswordField.Size = new Size(195, 23);
            PasswordField.TabIndex = 3;
            // 
            // UsernameField
            // 
            UsernameField.Anchor = AnchorStyles.Top;
            UsernameField.Location = new Point(38, 179);
            UsernameField.Name = "UsernameField";
            UsernameField.PlaceholderText = "Username";
            UsernameField.Size = new Size(195, 23);
            UsernameField.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1008, 602);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(LogoText);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(UsernameField);
            panel1.Controls.Add(PasswordField);
            panel1.Location = new Point(507, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 596);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(504, 602);
            panel2.TabIndex = 1;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 563);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "AuthForm";
            ShowIcon = false;
            Text = "RevVise App";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button LoginButton;
        private Label LogoText;
        private TextBox PasswordField;
        private TextBox UsernameField;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
    }
}