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
        String totalVehicle;
        String resolvedVehicle;
        String unresolvedVehicle;
        public DashboardView()
        {
            InitializeComponent();
            loadDashboardData();
            loadPieChart();
            loadRecentActivity();
        }

        private void cellDoubleClick1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header
            DataGridViewRow row = recentGridView.Rows[e.RowIndex];

            if (row.Height == 25) // default height
            {
                row.Height = 100; // expand to show full content
                row.Cells[e.ColumnIndex].Style.WrapMode = DataGridViewTriState.True;
            }
            else
            {
                row.Height = 25; // collapse
                row.Cells[e.ColumnIndex].Style.WrapMode = DataGridViewTriState.False;
            }
        }
        private void cellDoubleClick2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header
            DataGridViewRow row = resolvedDataView.Rows[e.RowIndex];

            if (row.Height == 25) // default height
            {
                row.Height = 100; // expand to show full content
                row.Cells[e.ColumnIndex].Style.WrapMode = DataGridViewTriState.True;
            }
            else
            {
                row.Height = 25; // collapse
                row.Cells[e.ColumnIndex].Style.WrapMode = DataGridViewTriState.False;
            }
        }

        DataGridViewCellStyle style = new DataGridViewCellStyle()
        {
            BackColor = Color.FromArgb(120, 105, 120),
            ForeColor = Color.FromArgb(230, 230, 230),
            SelectionBackColor = SystemColors.ScrollBar,
            SelectionForeColor = SystemColors.HighlightText,
            Font = new Font("Segoe UI", 9, FontStyle.Regular),
            WrapMode = DataGridViewTriState.False,
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
                query = $"SELECT vehicle_id AS ID, vehicle_model AS Model, vehicle_owner AS Owner, vehicle_plate AS Plate, vehicle_dateResolved AS 'Date Resolved' " +
                $"FROM tbl_vehicle WHERE vehicle_status = 'Resolved'" +
                $"ORDER BY vehicle_dateResolved DESC";

            }
            else 
            {
                query = $"SELECT vehicle_id AS ID, vehicle_model AS Model, vehicle_owner AS Owner, vehicle_plate AS Plate, vehicle_dateResolved AS 'Date Resolved' " +
                $"FROM tbl_vehicle WHERE vehicle_status = 'Resolved' AND user_id = '{Session.UserID}' " +
                $"ORDER BY vehicle_dateResolved DESC";
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
        private void loadDashboardData()
        {
            loadResolvedCases();
            welcomeDashboard.Text = $"Welcome, {Session.Username}.";
            descDashboard.Text = $"Here's an overview of your vehicle repairs.";
            totalVehicleLabel.Text = getTotalVehicle();
            resolvedVehicleLabel.Text = getResolvedVehicle();
            unresolvedVehicleLabel.Text = getUnresolvedVehicle();
        }
        private String sql(String query)
        {
            String sql;
            if (Session.Role == "Admin")
            {
                switch (query)
                {
                    case "total":
                        sql = $"SELECT COUNT(*) AS total FROM tbl_vehicle"; return sql;
                        break;
                    case "resolved":
                        sql = $"SELECT COUNT(*) AS total FROM tbl_vehicle WHERE vehicle_status = 'Resolved'"; return sql;
                        break;
                    case "unresolved":
                        sql = $"SELECT COUNT(*) AS total FROM tbl_vehicle WHERE vehicle_status = 'Unresolved'"; return sql;
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
                        sql = $"SELECT COUNT(*) AS total FROM tbl_vehicle WHERE user_id = '{Session.UserID}'"; return sql;
                        break;
                    case "resolved":
                        sql = $"SELECT COUNT(*) AS total FROM tbl_vehicle WHERE vehicle_status = 'Resolved' AND user_id='{Session.UserID}'"; return sql;
                        break;
                    case "unresolved":
                        sql = $"SELECT COUNT(*) AS total FROM tbl_vehicle WHERE vehicle_status = 'Unresolved' AND user_id='{Session.UserID}'"; return sql;
                        break;
                    default:
                        sql = ""; return sql;
                        break;
                }
            }

        }
        public String getTotalVehicle()
        {
            DataTable dtTotalVehicle = db.getData(sql("total"));
            return dtTotalVehicle.Rows[0]["total"].ToString();
        }
        private String getResolvedVehicle()
        {
            DataTable dtResolvedVehicle = db.getData(sql("resolved"));
            return dtResolvedVehicle.Rows[0]["total"].ToString();
        }
        private String getUnresolvedVehicle()
        {
            DataTable dtUnresolvedVehicle = db.getData(sql("unresolved"));
            return dtUnresolvedVehicle.Rows[0]["total"].ToString();
        }
        private void loadPieChart()
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

            int resolved = int.Parse(getResolvedVehicle());
            int unresolved = int.Parse(getUnresolvedVehicle());

            series.Points.AddXY("Resolved", resolved);
            series.Points.AddXY("Unresolved", unresolved);
            series.Points[0].Color = Color.SeaGreen;
            series.Points[1].Color = Color.IndianRed;


            foreach (var point in series.Points)
                point.BorderWidth = 0;


            statusChart.Series.Add(series);
        }
        private void loadRecentActivity()
        {
            String query;
            if (Session.Role == "Admin")
            {
                query = $"SELECT log_date as 'Date'," +
                        $"log_source as 'Source' ," +
                        $"log_action as 'Action'," +
                        $"user as 'User'" +
                        $"FROM tbl_logs WHERE log_source LIKE '%Catalog%' ORDER BY log_date DESC";
            }
            else
            {
                query = $"SELECT log_date as 'Date'," +
                        $"log_source as 'Source'," +
                        $"log_action as 'Action'" +
                        $"FROM tbl_logs WHERE user_id={Session.UserID} AND log_source LIKE '%Catalog%' ORDER BY log_date DESC ";
            }
            DataTable dt = db.getData(query);
            recentGridView.DataSource = dt;
            recentGridView.Columns["Date"].Width = 120;
            recentGridView.Columns["Source"].Width = 100;
            recentGridView.Columns["Action"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            recentGridView.DefaultCellStyle = style;
            recentGridView.ColumnHeadersDefaultCellStyle = headerStyle;
            recentGridView.EnableHeadersVisualStyles = false;
            recentGridView.ReadOnly = true;
            recentGridView.AllowUserToAddRows = false;
            recentGridView.AllowUserToDeleteRows = false;
            recentGridView.RowHeadersVisible = false;
            recentGridView.DefaultCellStyle = style;
        }
    }
}
