using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RevVise1.Forms.Views
{
    public partial class NewAccount : UserControl
    {
        RevDB db = new RevDB();
        Logger logger = new Logger();
        public NewAccount()
        {
            InitializeComponent();
        }

        private void backtoLoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }
        private bool userExists(String username) 
        {
            String query = "SELECT COUNT(*) FROM tbl_users WHERE username = @username";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"@username", username}
            };
            DataTable dt = db.getData(query, parameters);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0;
        }
        private void createAccButton_Click(object sender, EventArgs e)
        {
            bool check = userExists(usernameText.Text);
            if (passwordText.Text.Equals(passwordText2.Text) && !String.IsNullOrWhiteSpace(passwordText.Text) || !String.IsNullOrWhiteSpace(passwordText2.Text))
            {
                if (check)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                }
                else 
                {
                    String query = "INSERT INTO tbl_users(username,password) VALUES(@username,@password)";
                    Dictionary<string, object> parameters = new Dictionary<string, object>()
                        {
                            {"@username", usernameText.Text},
                            {"@password", passwordText.Text}
                        };
                    db.SQLManager(query, parameters);
                    logger.log($"New account {usernameText.Text} created.");
                }
            }
        }
    }
}
