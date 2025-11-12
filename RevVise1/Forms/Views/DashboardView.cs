using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

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

        DataGridViewCellStyle style = new DataGridViewCellStyle()
        {
            BackColor = Color.FromArgb(120, 105, 120),
            ForeColor = Color.FromArgb(230, 230, 230),
            SelectionBackColor = SystemColors.ScrollBar,
            SelectionForeColor = SystemColors.HighlightText,
            Font = new Font("Segoe UI", 9, FontStyle.Regular),
            WrapMode = DataGridViewTriState.True,
            Alignment = DataGridViewContentAlignment.MiddleLeft
        };

        DataGridViewCellStyle headerStyle = new DataGridViewCellStyle()
        {
            BackColor = Color.FromArgb(110, 95, 110),
            ForeColor = Color.FromArgb(230, 230, 230),
            Font = new Font("Segoe UI", 9, FontStyle.Bold),
            Alignment = DataGridViewContentAlignment.MiddleCenter
        };
        private void loadResolvedCases()
        {
            String query;
            if (Session.Role == "Admin")
            {
                query = $"SELECT motor_id AS ID, motor_model AS Model, motor_owner AS Owner, motor_plate AS Plate, motor_dateResolved AS 'Date Resolved' " +
                $"FROM tbl_motor WHERE motor_status = 'Resolved'" +
                $"ORDER BY motor_dateResolved DESC";

            }
            else 
            {
                query = $"SELECT motor_id AS ID, motor_model AS Model, motor_owner AS Owner, motor_plate AS Plate, motor_dateResolved AS 'Date Resolved' " +
                $"FROM tbl_motor WHERE motor_status = 'Resolved' AND user_id = '{Session.UserID}' " +
                $"ORDER BY motor_dateResolved DESC";
            }
            DataTable dt = db.getData(query);

            resolvedDataView.EnableHeadersVisualStyles = false;
            resolvedDataView.DataSource = dt;
            resolvedDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resolvedDataView.ReadOnly = true;
            resolvedDataView.AllowUserToAddRows = false;
            resolvedDataView.AllowUserToDeleteRows = false;
            resolvedDataView.RowHeadersVisible = false;
            resolvedDataView.DefaultCellStyle = style;
            resolvedDataView.ColumnHeadersDefaultCellStyle = headerStyle;


        }
        private void LoadDashboardData()
        {
            loadResolvedCases();
            welcomeDashboard.Text = $"Welcome, {Session.Username}.";
            descDashboard.Text = $"Here's an overview of your motor repairs.";
            totalMotorLabel.Text = getTotalMotor();
            resolvedMotorLabel.Text = getResolvedMotor();
            unresolvedMotorLabel.Text = getUnresolvedMotor();
        }
        private String sql(String query)
        {
            String sql;
            if (Session.Role == "Admin")
            {
                switch (query)
                {
                    case "total":
                        sql = $"SELECT COUNT(*) AS total FROM tbl_motor"; return sql;
                        break;
                    case "resolved":
                        sql = $"SELECT COUNT(*) AS total FROM tbl_motor WHERE motor_status = 'Resolved'"; return sql;
                        break;
                    case "unresolved":
                        sql = $"SELECT COUNT(*) AS total FROM tbl_motor WHERE motor_status = 'Unresolved'"; return sql;
                        break;
                    default:
                        sql = ""; return sql;
                        break;
                }
            }
            else
            {
                switch (query)
                {
                    case "total":
                        sql = $"SELECT COUNT(*) AS total FROM tbl_motor WHERE user_id = '{Session.UserID}'"; return sql;
                        break;
                    case "resolved":
                        sql = $"SELECT COUNT(*) AS total FROM tbl_motor WHERE motor_status = 'Resolved' AND user_id='{Session.UserID}'"; return sql;
                        break;
                    case "unresolved":
                        sql = $"SELECT COUNT(*) AS total FROM tbl_motor WHERE motor_status = 'Unresolved' AND user_id='{Session.UserID}'"; return sql;
                        break;
                    default:
                        sql = ""; return sql;
                        break;
                }
            }

        }
        public String getTotalMotor()
        {
            DataTable dtTotalMotor = db.getData(sql("total"));
            return dtTotalMotor.Rows[0]["total"].ToString();
        }
        private String getResolvedMotor()
        {
            DataTable dtResolvedMotor = db.getData(sql("resolved"));
            return dtResolvedMotor.Rows[0]["total"].ToString();
        }
        private String getUnresolvedMotor()
        {
            DataTable dtUnresolvedMotor = db.getData(sql("unresolved"));
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
