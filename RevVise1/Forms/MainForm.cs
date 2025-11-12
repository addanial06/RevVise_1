using System.Data;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RevVise1.Forms.Views;

namespace RevVise1.Forms
{
    public partial class MainForm : Form
    {
        RevDB db = new RevDB();
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        public MainForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            splitContainer1.IsSplitterFixed = true;
            ShowView(new DashboardView());
            getNotes();

        }
        private void getNotes()
        {
            String query = $"SELECT note FROM tbl_users WHERE user_id='{Session.UserID}'";
            DataTable dt = db.getData(query);
            if (dt.Rows.Count > 0)
            {
                notesTextBox.Text = dt.Rows[0]["note"].ToString();
            }
        }
        private void saveNotes()
        {
            var parameters = new Dictionary<string, object>()
            {
                { "@note", notesTextBox.Text },
                { "@userId", Session.UserID }
            };

            string query = "UPDATE tbl_users SET note = @note WHERE user_id = @userId";
            db.SQLManager(query, parameters);
        }
        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void ShowView(UserControl view)
        {
            contentPanel.Controls.Clear();
            view.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(view);
        }

        // Event handlers for navigation buttons
        private void dashboardView_Click(object sender, EventArgs e)
        {
            ShowView(new DashboardView());
        }
        private void settingView_Click(object sender, EventArgs e)
        {
            ShowView(new SettingView());
        }

        private void logView_Click(object sender, EventArgs e)
        {
            ShowView(new LogView());
        }

        private void catalogView_Click(object sender, EventArgs e)
        {
            ShowView(new CatalogView());
        }

        private void exitClick(object sender, EventArgs e)
        {
            saveNotes();
            Program.isAuthenticated = true;
            this.Close();
        }

        private void logoutClick(object sender, EventArgs e)
        {
            saveNotes();
            Session.endSession();
            Program.isAuthenticated = false;
            Close();
        }
    }
}


