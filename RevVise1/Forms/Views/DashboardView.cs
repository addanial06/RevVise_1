using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RevVise1.Forms.Views
{
    public partial class DashboardView : UserControl
    {
        RevDB db = new RevDB();
        String totalMotor;
        String resolvedMotor;
        String unresolvedMotor;
        public DashboardView()
        {
            InitializeComponent();
            LoadDashboardData();
            LoadPieChart();
        }
        private void LoadDashboardData() 
        {
            totalMotorLabel.Text = getTotalMotor();
            resolvedMotorLabel.Text = getResolvedMotor();
            unresolvedMotorLabel.Text = getUnresolvedMotor();
        }

        private String getTotalMotor() 
        {
            String sql = $"SELECT COUNT(*) AS total FROM tbl_motor WHERE user_id='{Session.UserID}'";
            DataTable dtTotalMotor = db.getData(sql);
            return dtTotalMotor.Rows[0]["total"].ToString();
        }
        private String getResolvedMotor()
        {
            String sql = $"SELECT COUNT(*) AS total FROM tbl_motor WHERE motor_status = 'Resolved' AND user_id='{Session.UserID}'";
            DataTable dtResolvedMotor = db.getData(sql);
            return dtResolvedMotor.Rows[0]["total"].ToString();
        }
        private String getUnresolvedMotor()
        {
            String sql = $"SELECT COUNT(*) AS total FROM tbl_motor WHERE motor_status = 'Unresolved' AND user_id='{Session.UserID}'";
            DataTable dtUnresolvedMotor = db.getData(sql);
            return dtUnresolvedMotor.Rows[0]["total"].ToString();
        }
        private void LoadPieChart()
        {
            statusChart.Series.Clear();
            statusChart.Titles.Clear();
            statusChart.Legends.Clear();

            if (statusChart.ChartAreas.Count == 0)
                statusChart.ChartAreas.Add(new ChartArea("MainArea"));

            var chartArea = statusChart.ChartAreas[0];
            chartArea.BackColor = Color.FromArgb(128, 113, 128); // match panel background
            chartArea.AxisX.Enabled = AxisEnabled.False;
            chartArea.AxisY.Enabled = AxisEnabled.False;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;

            Legend legend = new Legend();
            legend.Docking = Docking.Bottom;
            legend.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            legend.ForeColor = Color.White;
            legend.BackColor = Color.Transparent;
            statusChart.Legends.Add(legend);

            Series series = new Series("Status")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                LabelForeColor = Color.White,
            };
            series["PieLabelStyle"] = "Outside";
            series["PieStartAngle"] = "270";

            int resolved = int.Parse(getResolvedMotor());
            int unresolved = int.Parse(getUnresolvedMotor());

            series.Points.AddXY("Resolved", resolved);
            series.Points.AddXY("Unresolved", unresolved);
            series.Points[0].Color = Color.SeaGreen;
            series.Points[1].Color = Color.IndianRed;

 
            foreach (var point in series.Points)
                point.BorderWidth = 0;

 
            statusChart.Series.Add(series);
        }
    }
}
