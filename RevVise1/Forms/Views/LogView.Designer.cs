namespace RevVise1.Forms.Views
{
    partial class LogView
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
            dashboardLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            systemDataGridView = new DataGridView();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)systemDataGridView).BeginInit();
            SuspendLayout();
            // 
            // dashboardLabel
            // 
            dashboardLabel.AutoSize = true;
            dashboardLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardLabel.ForeColor = Color.DarkGray;
            dashboardLabel.Location = new Point(4, 1);
            dashboardLabel.Name = "dashboardLabel";
            dashboardLabel.Size = new Size(290, 65);
            dashboardLabel.TabIndex = 0;
            dashboardLabel.Text = "System Logs";
            dashboardLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.BackColor = SystemColors.Control;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dashboardLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(systemDataGridView, 0, 1);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(937, 655);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // systemDataGridView
            // 
            systemDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            systemDataGridView.BackgroundColor = Color.Gainsboro;
            systemDataGridView.BorderStyle = BorderStyle.None;
            systemDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            systemDataGridView.Location = new Point(6, 91);
            systemDataGridView.Margin = new Padding(5);
            systemDataGridView.Name = "systemDataGridView";
            systemDataGridView.Size = new Size(925, 558);
            systemDataGridView.TabIndex = 1;
            systemDataGridView.CellContentDoubleClick += cellDoubleClick;
            // 
            // LogView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "LogView";
            Size = new Size(937, 655);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)systemDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label dashboardLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView systemDataGridView;
    }
}
