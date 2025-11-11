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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tableLayoutPanel1 = new TableLayoutPanel();
            dashboardLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            totalMotorLabel = new Label();
            label9 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            resolvedMotorLabel = new Label();
            label8 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            unresolvedMotorLabel = new Label();
            label1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel4 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label3 = new Label();
            statusChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)statusChart).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 514F));
            tableLayoutPanel1.Controls.Add(dashboardLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 170F));
            tableLayoutPanel1.Size = new Size(943, 684);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dashboardLabel
            // 
            dashboardLabel.AutoSize = true;
            dashboardLabel.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardLabel.ForeColor = Color.DarkGray;
            dashboardLabel.Location = new Point(13, 10);
            dashboardLabel.Name = "dashboardLabel";
            dashboardLabel.Size = new Size(265, 65);
            dashboardLabel.TabIndex = 0;
            dashboardLabel.Text = "Dashboard";
            dashboardLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Location = new Point(10, 85);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(923, 589);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel10, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel9, 2, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(917, 107);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel10.BackColor = Color.FromArgb(115, 91, 115);
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(totalMotorLabel, 0, 1);
            tableLayoutPanel10.Controls.Add(label9, 0, 0);
            tableLayoutPanel10.Location = new Point(3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(299, 101);
            tableLayoutPanel10.TabIndex = 5;
            // 
            // totalMotorLabel
            // 
            totalMotorLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalMotorLabel.AutoSize = true;
            totalMotorLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            totalMotorLabel.ForeColor = SystemColors.Control;
            totalMotorLabel.Location = new Point(204, 56);
            totalMotorLabel.Name = "totalMotorLabel";
            totalMotorLabel.Size = new Size(92, 45);
            totalMotorLabel.TabIndex = 2;
            totalMotorLabel.Text = "1000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(230, 230, 230);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(274, 32);
            label9.TabIndex = 1;
            label9.Text = "Total Motors Registered";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel9.BackColor = Color.FromArgb(125, 109, 125);
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(resolvedMotorLabel, 0, 1);
            tableLayoutPanel9.Controls.Add(label8, 0, 0);
            tableLayoutPanel9.Location = new Point(613, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(301, 101);
            tableLayoutPanel9.TabIndex = 4;
            // 
            // resolvedMotorLabel
            // 
            resolvedMotorLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            resolvedMotorLabel.AutoSize = true;
            resolvedMotorLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            resolvedMotorLabel.ForeColor = SystemColors.Control;
            resolvedMotorLabel.Location = new Point(206, 56);
            resolvedMotorLabel.Name = "resolvedMotorLabel";
            resolvedMotorLabel.Size = new Size(92, 45);
            resolvedMotorLabel.TabIndex = 2;
            resolvedMotorLabel.Text = "1000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(230, 230, 230);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(178, 32);
            label8.TabIndex = 1;
            label8.Text = "Resolved Cases";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel8.BackColor = Color.FromArgb(115, 91, 115);
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(unresolvedMotorLabel, 0, 1);
            tableLayoutPanel8.Controls.Add(label1, 0, 0);
            tableLayoutPanel8.Location = new Point(308, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(299, 101);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // unresolvedMotorLabel
            // 
            unresolvedMotorLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            unresolvedMotorLabel.AutoSize = true;
            unresolvedMotorLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            unresolvedMotorLabel.ForeColor = SystemColors.Control;
            unresolvedMotorLabel.Location = new Point(204, 56);
            unresolvedMotorLabel.Name = "unresolvedMotorLabel";
            unresolvedMotorLabel.Size = new Size(92, 45);
            unresolvedMotorLabel.TabIndex = 2;
            unresolvedMotorLabel.Text = "1000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(230, 230, 230);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 1;
            label1.Text = "Unresolved Cases";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel4, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel4.Location = new Point(3, 113);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(917, 473);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(128, 113, 128);
            panel4.Controls.Add(tableLayoutPanel6);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(452, 467);
            panel4.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel6.Controls.Add(label4, 0, 0);
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 440F));
            tableLayoutPanel6.Size = new Size(446, 461);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(440, 434);
            dataGridView1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(230, 230, 230);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(193, 32);
            label4.TabIndex = 1;
            label4.Text = "Recent Activities";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel1, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel5.Location = new Point(458, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 52.3622055F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 47.6377945F));
            tableLayoutPanel5.Size = new Size(459, 473);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(0, 247);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 226);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.BackColor = Color.FromArgb(128, 113, 128);
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(label3, 0, 0);
            tableLayoutPanel7.Controls.Add(statusChart, 0, 1);
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(453, 241);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(230, 230, 230);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(252, 32);
            label3.TabIndex = 1;
            label3.Text = "Resolved : Unresolved";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusChart
            // 
            statusChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            statusChart.BackColor = Color.FromArgb(128, 113, 128);
            statusChart.BorderlineWidth = 0;
            chartArea1.Name = "ChartArea1";
            statusChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            statusChart.Legends.Add(legend1);
            statusChart.Location = new Point(3, 39);
            statusChart.Name = "statusChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            statusChart.Series.Add(series1);
            statusChart.Size = new Size(447, 199);
            statusChart.TabIndex = 2;
            statusChart.Text = "chart1";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "DashboardView";
            Size = new Size(949, 690);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)statusChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label dashboardLabel;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel totalEntriesPanel;
        private Label totalRegisteredLabel;
        private Label label1;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel8;
        private Label unresolvedMotorLabel;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel10;
        private Label totalMotorLabel;
        private Label label2;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel9;
        private Label resolvedMotorLabel;
        private Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart statusChart;
    }
}
