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
        RevDB db = new RevDB();
        public CatalogView()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            panel1.AutoScrollMargin = new Size(0, 20);

            preload();
        }
        private void ShowView(UserControl view)
        {
            view.Dock = DockStyle.Top;
            panel1.Controls.Add(view);
            panel1.ScrollControlIntoView(view);
        }

        private void preload()
        {
            DataTable dt = db.getData($"SELECT * FROM tbl_motor WHERE user_id='{Session.UserID}'ORDER BY motor_id ASC");

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["motor_id"]);

                Item item = new Item(id, true);

                item.Model = row["motor_model"].ToString();
                item.Owner = row["motor_owner"].ToString();
                item.Plate = row["motor_plate"].ToString();
                item.Entry = row["motor_entry"].ToString();
                item.Status = row["motor_status"].ToString();
                item.DateIssued = row["motor_dateIssued"].ToString();
                item.DateResolved = row["motor_dateResolved"].ToString();
                item.OwnerDetails = row["motor_ownerDetails"].ToString();

                ShowView(item);
            }
        }

        private void sortBy(string order, string motorDB, string filter = "")
        {
            string query = $"SELECT * FROM tbl_motor WHERE user_id='{Session.UserID}'";

            if (!string.IsNullOrEmpty(filter))
            {
                query += $" AND (" +
                         $"motor_model LIKE '%{filter}%' OR " +
                         $"motor_owner LIKE '%{filter}%' OR " +
                         $"motor_plate LIKE '%{filter}%')";
            }

            query += $" ORDER BY {motorDB} {order}";

            DataTable dt = db.getData(query);
            panel1.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["motor_id"]);

                Item item = new Item(id, true);
                item.Model = row["motor_model"].ToString();
                item.Owner = row["motor_owner"].ToString();
                item.Plate = row["motor_plate"].ToString();
                item.Entry = row["motor_entry"].ToString();
                item.Status = row["motor_status"].ToString();
                item.DateIssued = row["motor_dateIssued"].ToString();
                item.DateResolved = row["motor_dateResolved"].ToString();
                item.OwnerDetails = row["motor_ownerDetails"].ToString();

                ShowView(item);
            }
        }

        private void sortBy(string order, string motorDB)
        {
            sortBy(order, motorDB, "");
        }

        private void changeOrder()
        {
            if (order.Equals("ASC"))
            {
                sortStrip2.Items[0].Text = "Descending";
                order = "DESC";
            }
            else
            {
                sortStrip2.Items[0].Text = "Ascending";
                order = "ASC";
            }
        }


        // Buttons And Menu Items Below
        string motorDB = "motor_id";
        string order = "ASC";
        string filter = "";

        private void addButtonClick(object sender, EventArgs e)
        {
            Item item = new Item();
            ShowView(item);
            item.Size = new Size(900, 55);
        }

        // Sort by ID Ascending/Descending
        private void sortStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (order.Equals("ASC"))
            {
                sortStrip2.Items[0].Text = "Descending";
                order = "DESC";
                sortBy(order, motorDB, filter);
            }
            else
            {
                sortStrip2.Items[0].Text = "Ascending";
                order = "ASC";
                sortBy(order, motorDB, filter);
            }
        }

        // Sort by different criteria
        private void iDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "ID";
            motorDB = "motor_id";
            sortBy(order, motorDB, filter);
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Model";
            motorDB = "motor_model";
            sortBy(order, motorDB, filter);
        }

        private void ownerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Owner";
            motorDB = "motor_owner";
            sortBy(order, motorDB, filter);
        }

        private void plateStripMenuItem_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Plate";
            motorDB = "motor_plate";
            sortBy(order, motorDB, filter);
        }

        private void resolvedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Resolved";
            motorDB = "motor_status";
            sortBy(order, motorDB, filter);
        }

        private void idSort_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "ID";
            motorDB = "motor_id";
            sortBy(order, motorDB, filter);
            changeOrder();
        }

        private void modelSort_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Model";
            motorDB = "motor_model";
            sortBy(order, motorDB, filter);
            changeOrder();
        }

        private void ownerSort_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Owner";
            motorDB = "motor_owner";
            sortBy(order, motorDB, filter);
            changeOrder();
        }

        private void plateSort_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Plate";
            motorDB = "motor_plate";
            sortBy(order, motorDB, filter);
            changeOrder();
        }

        private void statusSort_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Resolved";
            motorDB = "motor_status";
            sortBy(order, motorDB, filter);
            changeOrder();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stop beep
                if (string.IsNullOrWhiteSpace(searchBox.Text))
                {
                    preload();
                }
                else
                {
                    filter = searchBox.Text.Trim();
                    sortBy(order, motorDB, filter);
                }
            }
        }

    }
}
