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
    public partial class CatalogView : UserControl
    {
        public CatalogView()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            panel1.AutoScrollMargin = new Size(0, 20);
        }
        private void ShowView(UserControl view)
        {
            view.Dock = DockStyle.Top;
            panel1.Controls.Add(view);
            panel1.ScrollControlIntoView(view);
        }

        int itemCount = 0;

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowView(new Item(itemCount));
            itemCount++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void addEntry_Click(object sender, EventArgs e)
        {
        }
    }
}
