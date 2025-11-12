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
    public partial class SettingView : UserControl
    {
        RevDB db = new RevDB();
        public SettingView()
        {
            InitializeComponent();
        }
    }
}
