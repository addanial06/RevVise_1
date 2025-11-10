using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace RevVise1.Forms.Views
{
    partial class DashboardView
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
            scrollPanel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(966, 152);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dashboardLabel
            // 
            dashboardLabel.AutoSize = true;
            dashboardLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardLabel.ForeColor = Color.DarkGray;
            dashboardLabel.Location = new Point(13, 10);
            dashboardLabel.Name = "dashboardLabel";
            dashboardLabel.Size = new Size(258, 65);
            dashboardLabel.TabIndex = 0;
            dashboardLabel.Text = "Dashboard";
            dashboardLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scrollPanel1
            // 
            scrollPanel1.AutoScroll = true;
            scrollPanel1.Location = new Point(3, 161);
            scrollPanel1.Name = "scrollPanel1";
            scrollPanel1.Padding = new Padding(10);
            scrollPanel1.Size = new Size(943, 526);
            scrollPanel1.TabIndex = 1;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(scrollPanel1);
            Controls.Add(tableLayoutPanel1);
            Name = "DashboardView";
            Size = new Size(949, 690);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label dashboardLabel;
        private Panel scrollPanel1;
        private Button button1;
    }
}
