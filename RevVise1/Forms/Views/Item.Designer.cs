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
            plateLabel = new Label();
            editButton = new Button();
            modelText = new TextBox();
            contactText = new TextBox();
            plateText = new TextBox();
            entryText = new RichTextBox();
            entryLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            resolveButton = new Button();
            deleteButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            ownerDetailsText = new TextBox();
            statusLabel = new Label();
            ownerDetailsLabel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            dateResolved = new Label();
            dateIssued = new Label();
            dateIssuedLabel = new Label();
            dateResolvedLabel = new Label();
            entryTitle = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.Anchor = AnchorStyles.None;
            IDLabel.AutoSize = true;
            IDLabel.Enabled = false;
            IDLabel.Location = new Point(13, 12);
            IDLabel.Margin = new Padding(2, 0, 2, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(25, 21);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID";
            // 
            // modelLabel
            // 
            modelLabel.Anchor = AnchorStyles.None;
            modelLabel.AutoSize = true;
            modelLabel.Enabled = false;
            modelLabel.Location = new Point(69, 13);
            modelLabel.Margin = new Padding(2, 0, 2, 0);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(54, 21);
            modelLabel.TabIndex = 1;
            modelLabel.Text = "Model";
            // 
            // contactLabel
            // 
            contactLabel.Anchor = AnchorStyles.None;
            contactLabel.AutoSize = true;
            contactLabel.Enabled = false;
            contactLabel.Location = new Point(175, 13);
            contactLabel.Margin = new Padding(2, 0, 2, 0);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(63, 21);
            contactLabel.TabIndex = 2;
            contactLabel.Text = "Contact";
            // 
            // plateLabel
            // 
            plateLabel.AutoSize = true;
            plateLabel.Enabled = false;
            plateLabel.Location = new Point(281, 13);
            plateLabel.Name = "plateLabel";
            plateLabel.Size = new Size(72, 21);
            plateLabel.TabIndex = 3;
            plateLabel.Text = "Plate No.";
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editButton.Location = new Point(3, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(127, 30);
            editButton.TabIndex = 4;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += Edit_Click;
            // 
            // modelText
            // 
            modelText.Anchor = AnchorStyles.None;
            modelText.BackColor = SystemColors.Menu;
            modelText.BorderStyle = BorderStyle.FixedSingle;
            modelText.Location = new Point(64, 10);
            modelText.Name = "modelText";
            modelText.Size = new Size(100, 29);
            modelText.TabIndex = 5;
            modelText.Text = "Model";
            modelText.Visible = false;
            modelText.Click += modelClick;
            // 
            // contactText
            // 
            contactText.Anchor = AnchorStyles.None;
            contactText.BackColor = SystemColors.Menu;
            contactText.BorderStyle = BorderStyle.FixedSingle;
            contactText.Location = new Point(169, 10);
            contactText.Name = "contactText";
            contactText.Size = new Size(100, 29);
            contactText.TabIndex = 6;
            contactText.Text = "Contact";
            contactText.Visible = false;
            contactText.Click += contactClick;
            // 
            // plateText
            // 
            plateText.Anchor = AnchorStyles.None;
            plateText.BackColor = SystemColors.Menu;
            plateText.BorderStyle = BorderStyle.FixedSingle;
            plateText.Location = new Point(275, 10);
            plateText.Name = "plateText";
            plateText.Size = new Size(100, 29);
            plateText.TabIndex = 7;
            plateText.Text = "Plate No.";
            plateText.Visible = false;
            plateText.Click += plateClick;
            // 
            // entryText
            // 
            entryText.BackColor = SystemColors.Menu;
            entryText.BorderStyle = BorderStyle.FixedSingle;
            entryText.Location = new Point(3, 3);
            entryText.Name = "entryText";
            entryText.Size = new Size(500, 169);
            entryText.TabIndex = 8;
            entryText.Text = "Entry";
            entryText.Visible = false;
            entryText.Click += entryClick;
            // 
            // entryLabel
            // 
            entryLabel.AutoSize = true;
            entryLabel.Location = new Point(3, 3);
            entryLabel.MaximumSize = new Size(500, 120);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(227, 21);
            entryLabel.TabIndex = 9;
            entryLabel.Text = "entry 1a sdasd asd asd asd asd ";
            entryLabel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.55556F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.4444447F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.1132069F));
            tableLayoutPanel1.Size = new Size(900, 265);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(resolveButton, 0, 2);
            tableLayoutPanel2.Controls.Add(deleteButton, 0, 1);
            tableLayoutPanel2.Controls.Add(editButton, 0, 0);
            tableLayoutPanel2.Location = new Point(764, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 142F));
            tableLayoutPanel2.Size = new Size(133, 259);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // resolveButton
            // 
            resolveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            resolveButton.AutoSize = true;
            resolveButton.Location = new Point(3, 119);
            resolveButton.Name = "resolveButton";
            resolveButton.Size = new Size(127, 31);
            resolveButton.TabIndex = 13;
            resolveButton.Text = "Resolve";
            resolveButton.UseVisualStyleBackColor = true;
            resolveButton.Click += resolveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            deleteButton.Location = new Point(3, 61);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(127, 31);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += Delete_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20.38835F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 79.61165F));
            tableLayoutPanel3.Size = new Size(755, 259);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(modelText);
            panel1.Controls.Add(contactLabel);
            panel1.Controls.Add(modelLabel);
            panel1.Controls.Add(ownerDetailsText);
            panel1.Controls.Add(contactText);
            panel1.Controls.Add(IDLabel);
            panel1.Controls.Add(plateLabel);
            panel1.Controls.Add(plateText);
            panel1.Controls.Add(statusLabel);
            panel1.Controls.Add(ownerDetailsLabel);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 52);
            panel1.TabIndex = 9;
            panel1.Click += clickItem;
            panel1.MouseEnter += hover;
            panel1.MouseLeave += nothover;
            // 
            // ownerDetailsText
            // 
            ownerDetailsText.Anchor = AnchorStyles.None;
            ownerDetailsText.BackColor = SystemColors.Menu;
            ownerDetailsText.BorderStyle = BorderStyle.FixedSingle;
            ownerDetailsText.Location = new Point(381, 10);
            ownerDetailsText.Name = "ownerDetailsText";
            ownerDetailsText.Size = new Size(127, 29);
            ownerDetailsText.TabIndex = 13;
            ownerDetailsText.Text = "Owner Details";
            ownerDetailsText.Visible = false;
            // 
            // statusLabel
            // 
            statusLabel.Anchor = AnchorStyles.None;
            statusLabel.AutoSize = true;
            statusLabel.Enabled = false;
            statusLabel.Location = new Point(648, 12);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(89, 21);
            statusLabel.TabIndex = 13;
            statusLabel.Text = "Unresolved";
            // 
            // ownerDetailsLabel
            // 
            ownerDetailsLabel.AutoSize = true;
            ownerDetailsLabel.Enabled = false;
            ownerDetailsLabel.Location = new Point(386, 13);
            ownerDetailsLabel.Name = "ownerDetailsLabel";
            ownerDetailsLabel.Size = new Size(108, 21);
            ownerDetailsLabel.TabIndex = 14;
            ownerDetailsLabel.Text = "Owner Details";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.125F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.875F));
            tableLayoutPanel4.Controls.Add(panel2, 0, 0);
            tableLayoutPanel4.Controls.Add(panel3, 1, 0);
            tableLayoutPanel4.Location = new Point(3, 55);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(0, 20, 0, 0);
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(749, 201);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(entryText);
            panel2.Controls.Add(entryLabel);
            panel2.Location = new Point(3, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(474, 175);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dateResolved);
            panel3.Controls.Add(dateIssued);
            panel3.Controls.Add(dateIssuedLabel);
            panel3.Controls.Add(dateResolvedLabel);
            panel3.Location = new Point(483, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 175);
            panel3.TabIndex = 1;
            // 
            // dateResolved
            // 
            dateResolved.AutoSize = true;
            dateResolved.Location = new Point(0, 104);
            dateResolved.Name = "dateResolved";
            dateResolved.Size = new Size(89, 21);
            dateResolved.TabIndex = 0;
            dateResolved.Text = "Unresolved";
            // 
            // dateIssued
            // 
            dateIssued.AutoSize = true;
            dateIssued.Location = new Point(0, 21);
            dateIssued.Name = "dateIssued";
            dateIssued.Size = new Size(52, 21);
            dateIssued.TabIndex = 13;
            dateIssued.Text = "label1";
            // 
            // dateIssuedLabel
            // 
            dateIssuedLabel.AutoSize = true;
            dateIssuedLabel.Location = new Point(0, 0);
            dateIssuedLabel.Name = "dateIssuedLabel";
            dateIssuedLabel.Size = new Size(93, 21);
            dateIssuedLabel.TabIndex = 13;
            dateIssuedLabel.Text = "Date Issued:";
            // 
            // dateResolvedLabel
            // 
            dateResolvedLabel.AutoSize = true;
            dateResolvedLabel.Location = new Point(0, 83);
            dateResolvedLabel.Name = "dateResolvedLabel";
            dateResolvedLabel.Size = new Size(112, 21);
            dateResolvedLabel.TabIndex = 13;
            dateResolvedLabel.Text = "Date Resolved:";
            // 
            // entryTitle
            // 
            entryTitle.AutoSize = true;
            entryTitle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entryTitle.Location = new Point(39, 45);
            entryTitle.Name = "entryTitle";
            entryTitle.Size = new Size(50, 20);
            entryTitle.TabIndex = 12;
            entryTitle.Text = "Entry:";
            entryTitle.Visible = false;
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(entryTitle);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(10);
            Name = "Item";
            Size = new Size(900, 595);
            MouseLeave += nothover;
            MouseHover += hover;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDLabel;
        private Label modelLabel;
        private Label contactLabel;
        private Label plateLabel;
        private Button editButton;
        private TextBox modelText;
        private TextBox contactText;
        private TextBox plateText;
        private RichTextBox entryText;
        private Label entryLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button deleteButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private Label entryTitle;
        private Label statusLabel;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel2;
        private Label dateResolvedLabel;
        private Label dateIssuedLabel;
        private Label dateIssued;
        private Panel panel3;
        private Label dateResolved;
        private Button resolveButton;
        private TextBox ownerDetailsText;
        private Label ownerDetailsLabel;
    }
}