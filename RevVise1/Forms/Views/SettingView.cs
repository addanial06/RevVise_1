using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;

namespace RevVise1.Forms.Views
{
    public partial class SettingView : UserControl
    {
        RevDB db = new RevDB();
        Logger logger = new Logger();
        public SettingView()
        {
            InitializeComponent();
            if (Session.Role.Equals("Admin"))
            {
                userDeleteUserButton.Enabled = false;
                loadStats(true);
                //userComboBox.SelectedIndex = 0;
            }
            else
            {
                hideAdminControls();
                loadStats();
            }

        }
        private String getDataCount(String type, String table, String extraQuery = "")
        {
            String query = $"SELECT COUNT(*) AS {type} FROM {table} " + extraQuery;
            DataTable dt = db.getData(query);
            return dt.Rows[0][type].ToString();
        }
        private void loadStats(bool isAdmin = false)
        {
            if (isAdmin)
            {
                adminUserRegisteredText.Text = getDataCount("username", "tbl_users");
                adminTotalVehicleText.Text = getDataCount("vehicle_id", "tbl_vehicle");
                adminTotalResolvedText.Text = getDataCount("vehicle_id", "tbl_vehicle", "WHERE vehicle_status='Resolved'");
                adminTotalUnresolvedText.Text = getDataCount("vehicle_id", "tbl_vehicle", "WHERE vehicle_status='unresolved'");
                loadCbBox();
            }
            userVehicleRegisteredText.Text = getDataCount("vehicle_id", "tbl_vehicle", $"WHERE user_id='{Session.UserID}'");
            userResolvedText.Text = getDataCount("vehicle_id", "tbl_vehicle", $"WHERE vehicle_status='Resolved' AND user_id='{Session.UserID}'");
            userUnresolvedText.Text = getDataCount("vehicle_id", "tbl_vehicle", $"WHERE  vehicle_status='Unresolved' AND user_id='{Session.UserID}'");
        }

        private void hideAdminControls()
        {
            adminPanel.Visible = false;
            adminPanel.Enabled = false;
            adminStatsPanel.Visible = false;
            adminStatsPanel.Enabled = false;
        }

        private void loadCbBox()
        {
            userComboBox.Items.Clear();
            String query = $"SELECT username FROM tbl_users ORDER BY user_id ASC";
            DataTable dt = db.getData(query);
            int counter = 0;
            bool isAdmin;
            foreach (DataRow row in dt.Rows)
            {
                String user = row["username"].ToString();
                if (!user.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    userComboBox.Items.Add(row["username"].ToString());
                }
            }
        }
        //button control helpers
        private void changePassword()
        {
            string newPass = Microsoft.VisualBasic.Interaction.InputBox("Enter new password:", "Change Password");
            if (!String.IsNullOrEmpty(newPass))
            {
                db.SQLManager($"UPDATE tbl_users SET password=@password WHERE user_id=@id", new Dictionary<string, object> { { "@password", newPass }, { "@id", Session.UserID } });
                MessageBox.Show("Password changed successfully.");
            }
            else
            {
                MessageBox.Show("Password not changed.");
            }
        }
        private void changePassword(String id)
        {
            string newPass = Microsoft.VisualBasic.Interaction.InputBox("Enter new password:", "Change Password");
            if (!String.IsNullOrEmpty(newPass))
            {
                db.SQLManager($"UPDATE tbl_users SET password=@password WHERE user_id=@id", new Dictionary<string, object> { { "@password", newPass }, { "@id", id } });
                MessageBox.Show("Password changed successfully.");
            }
            else
            {
                MessageBox.Show("Password not changed.");
            }
        }

        private String getUserID()
        {
            DataTable dt = db.getData("SELECT user_id FROM tbl_users WHERE username=@username", new Dictionary<string, object> { { "@username", userComboBox.SelectedItem.ToString() } });
            return dt.Rows[0]["user_id"].ToString(); ;
        }
        //button controls
        private void userChangePasswordButton_Click(object sender, EventArgs e)
        {
            string oldPass = Microsoft.VisualBasic.Interaction.InputBox("Enter your current password:", "Change Password");
            if (string.IsNullOrWhiteSpace(oldPass))
                return;
            String query = "SELECT password FROM tbl_users WHERE user_id=@id";
            DataTable dt = db.getData(query, new Dictionary<String, object> { { "@id", Session.UserID } });
            String currentPass = dt.Rows[0]["password"].ToString();

            if (oldPass != currentPass)
            {
                MessageBox.Show("Old password is incorrect.");
                return;
            }
            else
            {
                logger.log("User changed password.");
                changePassword();
            }
        }

        private void userResetVehicleDataButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all your vehicles?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String query = $"DELETE FROM tbl_vehicle WHERE user_id=@id";
                logger.log($"User \"{Session.Username}\" vehicle database cleared.");
                db.SQLManager(query, new Dictionary<string, object> { { "@id", Session.UserID } });
                MessageBox.Show("All user vehiclecycle data cleared.");
                loadStats(true);
            }
        }

        private void userDeleteUserButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete your account? This cannot be undone.", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String mquery = $"DELETE FROM tbl_vehicle WHERE user_id=@id";
                db.SQLManager(mquery, new Dictionary<string, object> { { "@id", Session.UserID } });
                String query = $"DELETE FROM tbl_users WHERE user_id=@id";
                logger.log($"User \"{Session.Username}\" deleted.");
                db.SQLManager(query, new Dictionary<string, object> { { "@id", Session.UserID } });
                MessageBox.Show("All user data deleted.");
                MessageBox.Show("Going back to Authentication UI.");

                Session.endSession();
                Program.isAuthenticated = false;
                FindForm().Close();
            }
        }

        //admin button controls
        private void adminResetUserPassButton_Click(object sender, EventArgs e)
        {
            String query = "SELECT user_id FROM tbl_users WHERE username=@username";
            if (userComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select a user.");
            }
            else
            {
                DataTable dt = db.getData(query, new Dictionary<string, object> { { "@username", userComboBox.SelectedItem.ToString() } });
                String id = dt.Rows[0]["user_id"].ToString();
                logger.log($"Admin changed user password.");
                changePassword(id);
            }

        }

        private void adminClearUserButton_Click(object sender, EventArgs e)
        {
            if (userComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select a user.");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to clear user data?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    String query = $"UPDATE tbl_users SET note='Notes go here' WHERE user_id = @id";
                    db.SQLManager(query, new Dictionary<string, object> { { "@id", getUserID() } });
                    String mquery = $"DELETE FROM tbl_vehicle WHERE user_id = @id";
                    db.SQLManager(mquery, new Dictionary<string, object> { { "@id", getUserID() } });
                    logger.log($"User \"{userComboBox.SelectedItem.ToString()}\" data cleared.");
                    MessageBox.Show("All user data cleared.");
                    loadStats(true);
                }
            }
        }
        private void adminDeleteUserButton_Click(object sender, EventArgs e)
        {
            if (userComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select a user.");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete user data?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    String mquery = $"DELETE FROM tbl_vehicle WHERE user_id = @id";
                    db.SQLManager(mquery, new Dictionary<string, object> { { "@id", getUserID() } });
                    logger.log($"User \"{userComboBox.SelectedItem.ToString()}\" deleted.");
                    String query = $"DELETE FROM tbl_users WHERE user_id = @id";
                    db.SQLManager(query, new Dictionary<string, object> { { "@id", getUserID() } });
                    MessageBox.Show("All user data deleted.");
                    loadStats(true);
                }
            }
        }
        private void adminResetVehicleDatabaseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all vehicle data?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String query = $"DELETE FROM tbl_vehicle";
                db.SQLManager(query);
                MessageBox.Show("Vehicle database cleared.");
                loadStats(true);
                logger.log("All vehicle database cleared.");
            }
        }

        private void adminResetLogDatabaseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all system logs?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String query = $"DELETE FROM tbl_logs";
                db.SQLManager(query);
                MessageBox.Show("System log database cleared.");
                loadStats(true);
                logger.log("All system log database cleared.");
            }
        }

        private void adminClearDatabaseButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete the database? This will delete everything!", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String mquery = $"DELETE FROM tbl_users WHERE user_id !='1'";
                db.SQLManager(mquery);
                String nquery = $"DELETE FROM tbl_vehicle";
                db.SQLManager(nquery);
                String query = $"DELETE FROM tbl_logs";
                db.SQLManager(query);
                MessageBox.Show("Database cleared.");
                loadStats(true);
                logger.log("Database cleared.");
            }
        }

        private void exportDBButton_Click(object sender, EventArgs e)
        {
            db.exportDB();
            logger.log("Database exported.");
        }
    }
}
