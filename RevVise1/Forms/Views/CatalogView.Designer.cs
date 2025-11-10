namespace RevVise1.Forms.Views
{
    partial class CatalogView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dashboardLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 514F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(dashboardLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.Size = new Size(943, 156);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dashboardLabel
            // 
            dashboardLabel.AutoSize = true;
            dashboardLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardLabel.ForeColor = Color.DarkGray;
            dashboardLabel.Location = new Point(13, 10);
            dashboardLabel.Name = "dashboardLabel";
            dashboardLabel.Size = new Size(190, 65);
            dashboardLabel.TabIndex = 0;
            dashboardLabel.Text = "Catalog";
            dashboardLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Location = new Point(13, 87);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(508, 56);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(114, 43);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(3, 165);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 525);
            panel1.TabIndex = 1;
            // 
            // CatalogView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "CatalogView";
            Size = new Size(949, 690);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label dashboardLabel;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
    }
}
