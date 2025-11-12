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
            ownerLabel = new Label();
            plateLabel = new Label();
            editButton = new Button();
            modelText = new TextBox();
            ownerText = new TextBox();
            plateText = new TextBox();
            entryText = new RichTextBox();
            entryLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            resolveButton = new Button();
            deleteButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            dateResolved = new Label();
            dateIssued = new Label();
            dateIssuedLabel = new Label();
            dateResolvedLabel = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel4 = new Panel();
            panel1 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            ownerDetailsLabel = new Label();
            ownerDetailsText = new TextBox();
            panel8 = new Panel();
            statusLabel = new Label();
            entryTitle = new Label();
            fontDialog1 = new FontDialog();
            panel9 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.Anchor = AnchorStyles.None;
            IDLabel.AutoSize = true;
            IDLabel.Enabled = false;
            IDLabel.Location = new Point(12, 12);
            IDLabel.Margin = new Padding(2, 0, 2, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(25, 21);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID";
            IDLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modelLabel
            // 
            modelLabel.Anchor = AnchorStyles.None;
            modelLabel.AutoSize = true;
            modelLabel.Enabled = false;
            modelLabel.Location = new Point(4, 9);
            modelLabel.Margin = new Padding(2, 0, 2, 0);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(54, 21);
            modelLabel.TabIndex = 1;
            modelLabel.Text = "Model";
            // 
            // ownerLabel
            // 
            ownerLabel.Anchor = AnchorStyles.None;
            ownerLabel.AutoSize = true;
            ownerLabel.Enabled = false;
            ownerLabel.Location = new Point(2, 9);
            ownerLabel.Margin = new Padding(2, 0, 2, 0);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new Size(57, 21);
            ownerLabel.TabIndex = 2;
            ownerLabel.Text = "Owner";
            // 
            // plateLabel
            // 
            plateLabel.AutoSize = true;
            plateLabel.Enabled = false;
            plateLabel.Location = new Point(3, 9);
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
            editButton.Size = new Size(88, 30);
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
            modelText.Location = new Point(4, 7);
            modelText.Name = "modelText";
            modelText.Size = new Size(100, 29);
            modelText.TabIndex = 5;
            modelText.Text = "Model";
            modelText.Visible = false;
            modelText.Click += modelClick;
            // 
            // ownerText
            // 
            ownerText.Anchor = AnchorStyles.None;
            ownerText.BackColor = SystemColors.Menu;
            ownerText.BorderStyle = BorderStyle.FixedSingle;
            ownerText.Location = new Point(3, 7);
            ownerText.Name = "ownerText";
            ownerText.Size = new Size(100, 29);
            ownerText.TabIndex = 6;
            ownerText.Text = "Owner";
            ownerText.Visible = false;
            ownerText.Click += ownerClick;
            // 
            // plateText
            // 
            plateText.Anchor = AnchorStyles.None;
            plateText.BackColor = SystemColors.Menu;
            plateText.BorderStyle = BorderStyle.FixedSingle;
            plateText.Location = new Point(3, 7);
            plateText.Name = "plateText";
            plateText.Size = new Size(100, 29);
            plateText.TabIndex = 7;
            plateText.Text = "Plate No.";
            plateText.Visible = false;
            plateText.Click += plateClick;
            // 
            // entryText
            // 
            entryText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            entryText.BackColor = SystemColors.Menu;
            entryText.BorderStyle = BorderStyle.FixedSingle;
            entryText.Location = new Point(-2, -1);
            entryText.Name = "entryText";
            entryText.Size = new Size(500, 159);
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
            entryLabel.Size = new Size(46, 21);
            entryLabel.TabIndex = 9;
            entryLabel.Text = "entry";
            entryLabel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
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
            tableLayoutPanel2.Location = new Point(803, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 142F));
            tableLayoutPanel2.Size = new Size(94, 259);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // resolveButton
            // 
            resolveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            resolveButton.AutoSize = true;
            resolveButton.Location = new Point(3, 119);
            resolveButton.Name = "resolveButton";
            resolveButton.Size = new Size(88, 31);
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
            deleteButton.Size = new Size(88, 31);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += Delete_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel9, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 21.2364769F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 78.76353F));
            tableLayoutPanel3.Size = new Size(794, 259);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.125F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.875F));
            tableLayoutPanel4.Controls.Add(panel2, 0, 0);
            tableLayoutPanel4.Controls.Add(panel3, 1, 0);
            tableLayoutPanel4.Location = new Point(3, 73);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(0, 20, 0, 0);
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(788, 183);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(entryText);
            panel2.Controls.Add(entryLabel);
            panel2.Location = new Point(4, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 155);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(dateResolved);
            panel3.Controls.Add(dateIssued);
            panel3.Controls.Add(dateIssuedLabel);
            panel3.Controls.Add(dateResolvedLabel);
            panel3.Location = new Point(508, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(276, 155);
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
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 6;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Controls.Add(panel4, 1, 0);
            tableLayoutPanel5.Controls.Add(panel1, 0, 0);
            tableLayoutPanel5.Controls.Add(panel5, 2, 0);
            tableLayoutPanel5.Controls.Add(panel6, 3, 0);
            tableLayoutPanel5.Controls.Add(panel7, 4, 0);
            tableLayoutPanel5.Controls.Add(panel8, 5, 0);
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(794, 46);
            tableLayoutPanel5.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.Controls.Add(modelLabel);
            panel4.Controls.Add(modelText);
            panel4.Location = new Point(53, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(133, 40);
            panel4.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(IDLabel);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 46);
            panel1.TabIndex = 9;
            panel1.Click += clickItem;
            panel1.MouseEnter += hover;
            panel1.MouseLeave += nothover;
            // 
            // panel5
            // 
            panel5.Controls.Add(ownerLabel);
            panel5.Controls.Add(ownerText);
            panel5.Location = new Point(201, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(133, 40);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(plateLabel);
            panel6.Controls.Add(plateText);
            panel6.Location = new Point(349, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(133, 40);
            panel6.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(ownerDetailsLabel);
            panel7.Controls.Add(ownerDetailsText);
            panel7.Location = new Point(497, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(133, 40);
            panel7.TabIndex = 4;
            // 
            // ownerDetailsLabel
            // 
            ownerDetailsLabel.AutoSize = true;
            ownerDetailsLabel.Enabled = false;
            ownerDetailsLabel.Location = new Point(3, 9);
            ownerDetailsLabel.Name = "ownerDetailsLabel";
            ownerDetailsLabel.Size = new Size(108, 21);
            ownerDetailsLabel.TabIndex = 14;
            ownerDetailsLabel.Text = "Owner Details";
            // 
            // ownerDetailsText
            // 
            ownerDetailsText.Anchor = AnchorStyles.None;
            ownerDetailsText.BackColor = SystemColors.Menu;
            ownerDetailsText.BorderStyle = BorderStyle.FixedSingle;
            ownerDetailsText.Location = new Point(3, 7);
            ownerDetailsText.Name = "ownerDetailsText";
            ownerDetailsText.Size = new Size(127, 29);
            ownerDetailsText.TabIndex = 13;
            ownerDetailsText.Text = "Owner Details";
            ownerDetailsText.Visible = false;
            ownerDetailsText.Click += ownerDetailsClick;
            // 
            // panel8
            // 
            panel8.Controls.Add(statusLabel);
            panel8.Location = new Point(645, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(137, 40);
            panel8.TabIndex = 5;
            // 
            // statusLabel
            // 
            statusLabel.Anchor = AnchorStyles.None;
            statusLabel.AutoSize = true;
            statusLabel.Enabled = false;
            statusLabel.Location = new Point(3, 9);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(89, 21);
            statusLabel.TabIndex = 13;
            statusLabel.Text = "Unresolved";
            // 
            // entryTitle
            // 
            entryTitle.AutoSize = true;
            entryTitle.BackColor = Color.Transparent;
            entryTitle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entryTitle.Location = new Point(39, 59);
            entryTitle.Name = "entryTitle";
            entryTitle.Size = new Size(50, 20);
            entryTitle.TabIndex = 12;
            entryTitle.Text = "Entry:";
            entryTitle.Visible = false;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BackColor = Color.WhiteSmoke;
            panel9.Location = new Point(3, 53);
            panel9.Name = "panel9";
            panel9.Size = new Size(788, 3);
            panel9.TabIndex = 13;
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
            tableLayoutPanel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDLabel;
        private Label modelLabel;
        private Label ownerLabel;
        private Label plateLabel;
        private Button editButton;
        private TextBox modelText;
        private TextBox ownerText;
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
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private FontDialog fontDialog1;
        private Panel panel9;
    }
}