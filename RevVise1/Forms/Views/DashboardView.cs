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
    public partial class DashboardView : UserControl
    {
        public DashboardView()
        {
            InitializeComponent();
            scrollPanel1.AutoScroll = true;
            scrollPanel1.AutoScrollMargin = new Size(0, 20);
        }

        private void ShowView(UserControl view)
        {
            view.Dock = DockStyle.Top;
            scrollPanel1.Controls.Add(view);
            scrollPanel1.ScrollControlIntoView(view);
        }

        int itemCount = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //ShowView(new Item());
            itemCount++;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
