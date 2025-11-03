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
            UsernameField = new TextBox();
            PasswordField = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Top;
            LoginButton.Location = new Point(440, 408);
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
            LogoText.Location = new Point(399, 138);
            LogoText.Margin = new Padding(3, 70, 3, 0);
            LogoText.Name = "LogoText";
            LogoText.Size = new Size(167, 50);
            LogoText.TabIndex = 1;
            LogoText.Text = "Rev Vise";
            LogoText.TextAlign = ContentAlignment.TopCenter;
            LogoText.Click += Authentication_Click;
            // 
            // UsernameField
            // 
            UsernameField.Anchor = AnchorStyles.Top;
            UsernameField.Location = new Point(385, 242);
            UsernameField.Name = "UsernameField";
            UsernameField.PlaceholderText = "Username";
            UsernameField.Size = new Size(195, 23);
            UsernameField.TabIndex = 2;
            // 
            // PasswordField
            // 
            PasswordField.Anchor = AnchorStyles.Top;
            PasswordField.Location = new Point(385, 310);
            PasswordField.Name = "PasswordField";
            PasswordField.PlaceholderText = "Password";
            PasswordField.Size = new Size(195, 23);
            PasswordField.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(UsernameField, 1, 2);
            tableLayoutPanel1.Controls.Add(PasswordField, 1, 3);
            tableLayoutPanel1.Controls.Add(LogoText, 1, 1);
            tableLayoutPanel1.Controls.Add(LoginButton, 1, 5);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel1.Size = new Size(968, 545);
            tableLayoutPanel1.TabIndex = 4;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 310);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(8, 8);
            dataGridView1.TabIndex = 4;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 563);
            Controls.Add(tableLayoutPanel1);
            Name = "AuthForm";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button LoginButton;
        private Label LogoText;
        private TextBox UsernameField;
        private TextBox PasswordField;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
    }
}