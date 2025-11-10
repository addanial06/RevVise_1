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
            modelLabel = new Label();
            plateLabel = new Label();
            modelTB = new TextBox();
            plateTB = new TextBox();
            ownerTB = new TextBox();
            contactTB = new TextBox();
            ownerLabel = new Label();
            contactLabel = new Label();
            maintenanceLabel = new Label();
            maintenanceTB = new TextBox();
            remarkLabel = new Label();
            remarksTB = new TextBox();
            addBtn = new Button();
            updateBtn = new Button();
            SuspendLayout();
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(14, 13);
            modelLabel.Margin = new Padding(2, 0, 2, 0);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(54, 21);
            modelLabel.TabIndex = 1;
            modelLabel.Text = "Model";
            // 
            // plateLabel
            // 
            plateLabel.AutoSize = true;
            plateLabel.Location = new Point(14, 48);
            plateLabel.Name = "plateLabel";
            plateLabel.Size = new Size(72, 21);
            plateLabel.TabIndex = 3;
            plateLabel.Text = "Plate No.";
            // 
            // modelTB
            // 
            modelTB.Location = new Point(115, 10);
            modelTB.Name = "modelTB";
            modelTB.Size = new Size(296, 29);
            modelTB.TabIndex = 4;
            // 
            // plateTB
            // 
            plateTB.Location = new Point(115, 45);
            plateTB.Name = "plateTB";
            plateTB.Size = new Size(296, 29);
            plateTB.TabIndex = 5;
            // 
            // ownerTB
            // 
            ownerTB.Location = new Point(115, 80);
            ownerTB.Name = "ownerTB";
            ownerTB.Size = new Size(296, 29);
            ownerTB.TabIndex = 6;
            // 
            // contactTB
            // 
            contactTB.Location = new Point(115, 115);
            contactTB.Name = "contactTB";
            contactTB.Size = new Size(296, 29);
            contactTB.TabIndex = 9;
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.Location = new Point(14, 83);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new Size(57, 21);
            ownerLabel.TabIndex = 10;
            ownerLabel.Text = "Owner";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new Point(14, 118);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(91, 21);
            contactLabel.TabIndex = 11;
            contactLabel.Text = "Contact No.";
            // 
            // maintenanceLabel
            // 
            maintenanceLabel.AutoSize = true;
            maintenanceLabel.Location = new Point(463, 13);
            maintenanceLabel.Margin = new Padding(2, 0, 2, 0);
            maintenanceLabel.Name = "maintenanceLabel";
            maintenanceLabel.Size = new Size(139, 21);
            maintenanceLabel.TabIndex = 12;
            maintenanceLabel.Text = "Maintenance Entry";
            // 
            // maintenanceTB
            // 
            maintenanceTB.Location = new Point(607, 10);
            maintenanceTB.Name = "maintenanceTB";
            maintenanceTB.Size = new Size(296, 29);
            maintenanceTB.TabIndex = 13;
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new Point(463, 53);
            remarkLabel.Margin = new Padding(2, 0, 2, 0);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new Size(71, 21);
            remarkLabel.TabIndex = 14;
            remarkLabel.Text = "Remarks";
            // 
            // remarksTB
            // 
            remarksTB.Location = new Point(607, 45);
            remarksTB.Name = "remarksTB";
            remarksTB.Size = new Size(296, 29);
            remarksTB.TabIndex = 15;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(467, 118);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 29);
            addBtn.TabIndex = 16;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(548, 118);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 29);
            updateBtn.TabIndex = 17;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1075, 157);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(remarksTB);
            Controls.Add(remarkLabel);
            Controls.Add(maintenanceTB);
            Controls.Add(maintenanceLabel);
            Controls.Add(contactLabel);
            Controls.Add(ownerLabel);
            Controls.Add(contactTB);
            Controls.Add(ownerTB);
            Controls.Add(plateTB);
            Controls.Add(modelTB);
            Controls.Add(plateLabel);
            Controls.Add(modelLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(10);
            Name = "Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label modelLabel;
        private Label plateLabel;
        private TextBox modelTB;
        private TextBox plateTB;
        private TextBox ownerTB;
        private TextBox contactTB;
        private Label ownerLabel;
        private Label contactLabel;
        private Label maintenanceLabel;
        private TextBox maintenanceTB;
        private Label remarkLabel;
        private TextBox remarksTB;
        private Button addBtn;
        private Button updateBtn;
    }
}