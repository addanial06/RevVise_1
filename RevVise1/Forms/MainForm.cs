using System.Runtime.InteropServices;
using RevVise1.Forms.Views;

namespace RevVise1.Forms
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
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

        public MainForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            splitContainer1.IsSplitterFixed = true;
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

        // end
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void catalogView_MouseHover(object sender, EventArgs e)
        {
        }
    }
}


