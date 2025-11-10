namespace RevVise1.Forms.Views
{
    partial class Item
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
            IDLabel = new Label();
            modelLabel = new Label();
            contactLabel = new Label();
            vehicleLabel = new Label();
            editButton = new Button();
            modelText = new TextBox();
            contactText = new TextBox();
            vehicleText = new TextBox();
            entryText = new RichTextBox();
            entryLabel = new Label();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(19, 10);
            IDLabel.Margin = new Padding(2, 0, 2, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(25, 21);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(60, 10);
            modelLabel.Margin = new Padding(2, 0, 2, 0);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(54, 21);
            modelLabel.TabIndex = 1;
            modelLabel.Text = "Model";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new Point(200, 10);
            contactLabel.Margin = new Padding(2, 0, 2, 0);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(63, 21);
            contactLabel.TabIndex = 2;
            contactLabel.Text = "Contact";
            // 
            // vehicleLabel
            // 
            vehicleLabel.AutoSize = true;
            vehicleLabel.Location = new Point(400, 10);
            vehicleLabel.Name = "vehicleLabel";
            vehicleLabel.Size = new Size(99, 21);
            vehicleLabel.TabIndex = 3;
            vehicleLabel.Text = "Vehicle Desc.";
            // 
            // editButton
            // 
            editButton.Location = new Point(819, 8);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 30);
            editButton.TabIndex = 4;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += Edit_Click;
            // 
            // modelText
            // 
            modelText.BackColor = SystemColors.InactiveCaption;
            modelText.BorderStyle = BorderStyle.FixedSingle;
            modelText.Location = new Point(60, 7);
            modelText.Name = "modelText";
            modelText.Size = new Size(100, 29);
            modelText.TabIndex = 5;
            modelText.Visible = false;
            // 
            // contactText
            // 
            contactText.BackColor = SystemColors.InactiveCaption;
            contactText.BorderStyle = BorderStyle.FixedSingle;
            contactText.Location = new Point(200, 7);
            contactText.Name = "contactText";
            contactText.Size = new Size(100, 29);
            contactText.TabIndex = 6;
            contactText.Visible = false;
            // 
            // vehicleText
            // 
            vehicleText.BackColor = SystemColors.InactiveCaption;
            vehicleText.BorderStyle = BorderStyle.FixedSingle;
            vehicleText.Location = new Point(400, 7);
            vehicleText.Name = "vehicleText";
            vehicleText.Size = new Size(100, 29);
            vehicleText.TabIndex = 7;
            vehicleText.Visible = false;
            // 
            // entryText
            // 
            entryText.BackColor = SystemColors.InactiveCaption;
            entryText.BorderStyle = BorderStyle.FixedSingle;
            entryText.Location = new Point(580, 8);
            entryText.Name = "entryText";
            entryText.Size = new Size(500, 120);
            entryText.TabIndex = 8;
            entryText.Text = "";
            entryText.Visible = false;
            // 
            // entryLabel
            // 
            entryLabel.AutoSize = true;
            entryLabel.Location = new Point(591, 13);
            entryLabel.MaximumSize = new Size(500, 120);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(227, 21);
            entryLabel.TabIndex = 9;
            entryLabel.Text = "entry 1a sdasd asd asd asd asd ";
            entryLabel.Visible = false;
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(entryLabel);
            Controls.Add(entryText);
            Controls.Add(vehicleText);
            Controls.Add(contactText);
            Controls.Add(modelText);
            Controls.Add(editButton);
            Controls.Add(vehicleLabel);
            Controls.Add(contactLabel);
            Controls.Add(modelLabel);
            Controls.Add(IDLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Item";
            Size = new Size(900, 43);
            Click += Item_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDLabel;
        private Label modelLabel;
        private Label contactLabel;
        private Label vehicleLabel;
        private Button editButton;
        private TextBox modelText;
        private TextBox contactText;
        private TextBox vehicleText;
        private RichTextBox entryText;
        private Label entryLabel;
    }
}