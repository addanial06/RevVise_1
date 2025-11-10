using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RevVise1.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            //MessageBox.Show("Running");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Program.isAuthenticated = true;
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Authentication_Click(object sender, EventArgs e)
        {

        }
    }
}
