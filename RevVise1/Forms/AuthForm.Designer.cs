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
            button1 = new Button();
            Authentication = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(396, 282);
            button1.Name = "button1";
            button1.Size = new Size(86, 27);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Authentication
            // 
            Authentication.Anchor = AnchorStyles.Top;
            Authentication.AutoSize = true;
            Authentication.FlatStyle = FlatStyle.Popup;
            Authentication.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Authentication.Location = new Point(358, 111);
            Authentication.Name = "Authentication";
            Authentication.Size = new Size(281, 50);
            Authentication.TabIndex = 1;
            Authentication.Text = "Authentication";
            Authentication.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(396, 199);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "User";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.Location = new Point(396, 237);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(195, 23);
            textBox2.TabIndex = 3;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 563);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Authentication);
            Controls.Add(button1);
            Name = "AuthForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Authentication;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}