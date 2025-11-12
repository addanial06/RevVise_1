using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevVise1.Forms.Views
{
    public partial class LogView : UserControl
    {
        private RevDB db = new RevDB();
        public LogView()
        {
            InitializeComponent();
            loadLogs();
        }
        private void cellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header
            DataGridViewRow row = systemDataGridView.Rows[e.RowIndex];

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
            BackColor = Color.FromArgb(211, 211, 211),
            ForeColor = Color.FromArgb(60, 60, 60),
            SelectionBackColor = Color.FromArgb(180, 180, 180),
            SelectionForeColor = Color.FromArgb(60, 60, 60),
            Font = new Font("Segoe UI", 9, FontStyle.Regular),
            WrapMode = DataGridViewTriState.False,
            Alignment = DataGridViewContentAlignment.MiddleLeft
        };

        DataGridViewCellStyle headerStyle = new DataGridViewCellStyle()
        {
            BackColor = Color.FromArgb(160, 160, 160),
            ForeColor = Color.White,                   
            Font = new Font("Segoe UI", 9, FontStyle.Bold),
            Alignment = DataGridViewContentAlignment.MiddleCenter
        };
        private void loadLogs() 
        {
            String query;
            if (Session.Role == "Admin")
            {
                query = $"SELECT log_date as 'Date'," +
                        $"log_source as 'Source' ," +
                        $"log_action as 'Action'," +
                        $"user as 'User'" +
                        $"FROM tbl_logs ORDER BY log_date DESC";
            }
            else 
            {
                query = $"SELECT log_date as 'Date'," +
                        $"log_source as 'Source'," +
                        $"log_action as 'Action'" + 
                        $"FROM tbl_logs WHERE user_id={Session.UserID} ORDER BY log_date DESC ";
            }
            DataTable dt = db.getData(query);
            systemDataGridView.DataSource = dt;
            systemDataGridView.Columns["Date"].Width = 120; 
            systemDataGridView.Columns["Source"].Width = 100;
            systemDataGridView.Columns["Action"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            systemDataGridView.DefaultCellStyle = style;
            systemDataGridView.ColumnHeadersDefaultCellStyle = headerStyle;
            systemDataGridView.EnableHeadersVisualStyles = false;
            systemDataGridView.ReadOnly = true;
            systemDataGridView.AllowUserToAddRows = false;
            systemDataGridView.AllowUserToDeleteRows = false;
            systemDataGridView.RowHeadersVisible = false;
            systemDataGridView.DefaultCellStyle = style;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Logger logger = new Logger("LogView",Session.Username);
            logger.log("Test log entry from LogView");
        }
    }
}
