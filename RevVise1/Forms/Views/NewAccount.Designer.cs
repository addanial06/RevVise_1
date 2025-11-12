namespace RevVise1.Forms.Views
{
    partial class NewAccount
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
            createAccButton = new Button();
            usernameText = new TextBox();
            passwordText = new TextBox();
            LogoText = new Label();
            passwordText2 = new TextBox();
            backtoLoginLink = new LinkLabel();
            SuspendLayout();
            // 
            // createAccButton
            // 
            createAccButton.Anchor = AnchorStyles.Top;
            createAccButton.Location = new Point(18, 195);
            createAccButton.Name = "createAccButton";
            createAccButton.Size = new Size(111, 27);
            createAccButton.TabIndex = 4;
            createAccButton.Text = "Create Account";
            createAccButton.UseVisualStyleBackColor = true;
            createAccButton.Click += createAccButton_Click;
            // 
            // usernameText
            // 
            usernameText.Anchor = AnchorStyles.Top;
            usernameText.Location = new Point(18, 108);
            usernameText.Name = "usernameText";
            usernameText.PlaceholderText = "Username";
            usernameText.Size = new Size(195, 23);
            usernameText.TabIndex = 5;
            usernameText.KeyPress += usernameText_KeyPress;
            // 
            // passwordText
            // 
            passwordText.Anchor = AnchorStyles.Top;
            passwordText.Location = new Point(18, 137);
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.PlaceholderText = "Password";
            passwordText.Size = new Size(195, 23);
            passwordText.TabIndex = 6;
            passwordText.KeyPress += passwordText_KeyPress;
            // 
            // LogoText
            // 
            LogoText.Anchor = AnchorStyles.Top;
            LogoText.AutoSize = true;
            LogoText.FlatStyle = FlatStyle.Popup;
            LogoText.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LogoText.ForeColor = Color.FromArgb(210, 210, 210);
            LogoText.Location = new Point(6, 55);
            LogoText.Margin = new Padding(0, 70, 3, 0);
            LogoText.Name = "LogoText";
            LogoText.Size = new Size(243, 50);
            LogoText.TabIndex = 7;
            LogoText.Text = "New Account";
            // 
            // passwordText2
            // 
            passwordText2.Anchor = AnchorStyles.Top;
            passwordText2.Location = new Point(18, 166);
            passwordText2.Name = "passwordText2";
            passwordText2.PasswordChar = '*';
            passwordText2.PlaceholderText = "Confirm Password";
            passwordText2.Size = new Size(195, 23);
            passwordText2.TabIndex = 8;
            passwordText2.KeyPress += passwordText2_KeyPress;
            // 
            // backtoLoginLink
            // 
            backtoLoginLink.AutoSize = true;
            backtoLoginLink.LinkColor = Color.FromArgb(100, 100, 255);
            backtoLoginLink.Location = new Point(206, 247);
            backtoLoginLink.Name = "backtoLoginLink";
            backtoLoginLink.Size = new Size(76, 15);
            backtoLoginLink.TabIndex = 9;
            backtoLoginLink.TabStop = true;
            backtoLoginLink.Text = "Back to login";
            backtoLoginLink.LinkClicked += backtoLoginLink_LinkClicked;
            // 
            // NewAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(backtoLoginLink);
            Controls.Add(passwordText2);
            Controls.Add(LogoText);
            Controls.Add(createAccButton);
            Controls.Add(usernameText);
            Controls.Add(passwordText);
            Name = "NewAccount";
            Size = new Size(311, 286);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createAccButton;
        private TextBox usernameText;
        private TextBox passwordText;
        private Label LogoText;
        private TextBox passwordText2;
        private LinkLabel backtoLoginLink;
    }
}
