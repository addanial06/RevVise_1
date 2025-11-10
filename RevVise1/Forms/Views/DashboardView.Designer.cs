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
            greenBox = new Label();
            yellowBox = new Label();
            redBox = new Label();
            scrollPanel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 514F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(dashboardLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(greenBox, 1, 0);
            tableLayoutPanel1.Controls.Add(yellowBox, 2, 0);
            tableLayoutPanel1.Controls.Add(redBox, 3, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(986, 162);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
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
            // greenBox
            // 
            greenBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            greenBox.AutoSize = true;
            greenBox.BackColor = Color.PaleGreen;
            greenBox.FlatStyle = FlatStyle.Flat;
            greenBox.Location = new Point(524, 10);
            greenBox.Margin = new Padding(0);
            greenBox.Name = "greenBox";
            greenBox.Padding = new Padding(40, 30, 40, 30);
            greenBox.Size = new Size(143, 85);
            greenBox.TabIndex = 2;
            greenBox.Text = "Green Box";
            // 
            // yellowBox
            // 
            yellowBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            yellowBox.AutoSize = true;
            yellowBox.BackColor = Color.Gold;
            yellowBox.Location = new Point(667, 10);
            yellowBox.Margin = new Padding(0);
            yellowBox.Name = "yellowBox";
            yellowBox.Padding = new Padding(40, 30, 40, 30);
            yellowBox.Size = new Size(143, 85);
            yellowBox.TabIndex = 3;
            yellowBox.Text = "Yellow Box";
            // 
            // redBox
            // 
            redBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            redBox.AutoSize = true;
            redBox.BackColor = Color.DarkRed;
            redBox.Location = new Point(810, 10);
            redBox.Margin = new Padding(0);
            redBox.Name = "redBox";
            redBox.Padding = new Padding(40, 30, 40, 30);
            redBox.Size = new Size(143, 85);
            redBox.TabIndex = 4;
            redBox.Text = "redBox";
            // 
            // scrollPanel1
            // 
            scrollPanel1.AutoScroll = true;
            scrollPanel1.Location = new Point(16, 161);
            scrollPanel1.Name = "scrollPanel1";
            scrollPanel1.Padding = new Padding(10);
            scrollPanel1.Size = new Size(930, 526);
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
        private Label greenBox;
        private Label yellowBox;
        private Label redBox;
    }
}
