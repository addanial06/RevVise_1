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
            loginButton = new Button();
            LogoText = new Label();
            passwordText = new TextBox();
            usernameText = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            createAccLinkLabel = new LinkLabel();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top;
            loginButton.Location = new Point(21, 166);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(86, 27);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginClick;
            // 
            // LogoText
            // 
            LogoText.Anchor = AnchorStyles.Top;
            LogoText.AutoSize = true;
            LogoText.FlatStyle = FlatStyle.Popup;
            LogoText.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LogoText.ForeColor = SystemColors.ScrollBar;
            LogoText.Location = new Point(9, 55);
            LogoText.Margin = new Padding(0, 70, 3, 0);
            LogoText.Name = "LogoText";
            LogoText.Size = new Size(162, 50);
            LogoText.TabIndex = 1;
            LogoText.Text = "Rev Vise";
            LogoText.Click += Authentication_Click;
            // 
            // passwordText
            // 
            passwordText.Anchor = AnchorStyles.Top;
            passwordText.Location = new Point(21, 137);
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.PlaceholderText = "Password";
            passwordText.Size = new Size(195, 23);
            passwordText.TabIndex = 3;
            passwordText.KeyPress += passwordText_KeyPress;
            // 
            // usernameText
            // 
            usernameText.Anchor = AnchorStyles.Top;
            usernameText.Location = new Point(21, 108);
            usernameText.Name = "usernameText";
            usernameText.PlaceholderText = "Username";
            usernameText.Size = new Size(195, 23);
            usernameText.TabIndex = 2;
            usernameText.KeyPress += usernameText_KeyPress;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.56349F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.43651F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Location = new Point(-8, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(697, 292);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(createAccLinkLabel);
            panel1.Controls.Add(LogoText);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(usernameText);
            panel1.Controls.Add(passwordText);
            panel1.Location = new Point(380, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 292);
            panel1.TabIndex = 0;
            // 
            // createAccLinkLabel
            // 
            createAccLinkLabel.AutoSize = true;
            createAccLinkLabel.LinkColor = Color.FromArgb(150, 150, 255);
            createAccLinkLabel.Location = new Point(206, 247);
            createAccLinkLabel.Name = "createAccLinkLabel";
            createAccLinkLabel.Size = new Size(89, 15);
            createAccLinkLabel.TabIndex = 4;
            createAccLinkLabel.TabStop = true;
            createAccLinkLabel.Text = "Create Account";
            createAccLinkLabel.LinkClicked += createAccLinkLabel_LinkClicked;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 292);
            panel2.TabIndex = 1;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 285);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MaximumSize = new Size(697, 324);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(697, 324);
            Name = "AuthForm";
            ShowIcon = false;
            Text = "RevVise App";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button loginButton;
        private Label LogoText;
        private TextBox passwordText;
        private TextBox usernameText;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private LinkLabel createAccLinkLabel;
    }
}