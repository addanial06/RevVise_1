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
        RevDB db = new RevDB();
        public AuthForm()
        {
            InitializeComponent();
            //MessageBox.Show("Running");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Authentication_Click(object sender, EventArgs e)
        {

        }

        private void loginClick(object sender, EventArgs e)
        {
            if (db.dbLogin(usernameText.Text, passwordText.Text))
            {
                DataRow user = db.GetUser(usernameText.Text, passwordText.Text);
                Session.startSession(Convert.ToInt32(user["user_id"]), user["username"].ToString(), user["role"].ToString());
                MessageBox.Show("Login Successful.");
                Program.isAuthenticated = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed.");
                Program.isAuthenticated = false;
            }
            
        }
    }
}
