using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RevVise1.Forms.Views;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RevVise1.Forms
{
    public partial class AuthForm : Form
    {
        RevDB db = new RevDB();
        public AuthForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            //MessageBox.Show("Running");
        }

        private void loginClick(object sender, EventArgs e)
        {
            if (db.dbLogin(usernameText.Text, passwordText.Text))
            {
                DataRow user = db.GetUser(usernameText.Text, passwordText.Text);
                Session.startSession(Convert.ToInt32(user["user_id"]), user["username"].ToString(), user["role"].ToString());
                MessageBox.Show("Login Successful.");

                Program.isAuthenticated = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed.");
                Program.isAuthenticated = false;
            }

        }

        private void createAccLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserControl view = new NewAccount();
            view.Dock = DockStyle.Top;
            panel1.Controls.Add(view);
            panel1.ScrollControlIntoView(view);
            view.BringToFront();
            view.Focus();

        }

        private void usernameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                passwordText.Focus();
            }
        }

        private void passwordText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginClick(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
