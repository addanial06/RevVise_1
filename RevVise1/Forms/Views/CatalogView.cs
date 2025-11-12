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
        Logger logger = new Logger("Catalog", Session.Username);
        public CatalogView()
        {
            DashboardView dv = new DashboardView();
            InitializeComponent();
            panel1.AutoScroll = true;
            totalVehicleLabel.Text = dv.getTotalVehicle();
            preload();
        }
        private void ShowView(UserControl view)
        {
            view.Dock = DockStyle.Top;
            panel1.Controls.Add(view);
            panel1.ScrollControlIntoView(view);
        }

        private Item loadItem(DataRow row, bool isPreload = false)
        {
            int id = Convert.ToInt32(row["vehicle_id"]);
            Item item = new Item(id, isPreload);
            item.Model = row["vehicle_model"].ToString();
            item.Owner = row["vehicle_owner"].ToString();
            item.Plate = row["vehicle_plate"].ToString();
            item.Entry = row["vehicle_entry"].ToString();
            item.Status = row["vehicle_status"].ToString();
            item.DateIssued = row["vehicle_dateIssued"].ToString();
            item.DateResolved = row["vehicle_dateResolved"].ToString();
            item.OwnerDetails = row["vehicle_ownerDetails"].ToString();
            return item;
        }
        private void resetView()
        {
            filter = "";
            panel1.Controls.Clear();
            preload();
        }
        private void preload()
        {
            DataTable dt;
            if (Session.Role == "Admin")
            {
                dt = db.getData($"SELECT * FROM tbl_vehicle ORDER BY vehicle_id ASC");
            }
            else
            {
                dt = db.getData($"SELECT * FROM tbl_vehicle WHERE user_id='{Session.UserID}'ORDER BY vehicle_id ASC");
            }
            foreach (DataRow row in dt.Rows)
            {
                Item item = loadItem(row, true);
                ShowView(item);
            }
        }

        private void sortBy(string order, string vehicleDB, string filter = "")
        {
            string query;
            panel1.Controls.Clear();
            if (Session.Role == "Admin")
            {
                query = $"SELECT * FROM tbl_vehicle";
            }
            else
            {
                query = $"SELECT * FROM tbl_vehicle WHERE user_id='{Session.UserID}'";
            }
            if (!string.IsNullOrEmpty(filter))
            {
                query += $" AND (" +
                         $"vehicle_model LIKE '%{filter}%' OR " +
                         $"vehicle_owner LIKE '%{filter}%' OR " +
                         $"vehicle_plate LIKE '%{filter}%')";
            }
            query += $" ORDER BY {vehicleDB} {order}";
            DataTable dt = db.getData(query);
            foreach (DataRow row in dt.Rows)
            {
                Item item = loadItem(row, true);
                ShowView(item);
            }
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
        string vehicleDB = "vehicle_id";
        string order = "ASC";
        string filter = "";

        private void addButtonClick(object sender, EventArgs e)
        {
            Item item = new Item();
            ShowView(item);
            item.Size = new Size(900, 55);
            logger.log("Added new vehicle entry form.");
        }

        // Sort by ID Ascending/Descending
        private void sortStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (order.Equals("ASC"))
            {
                sortStrip2.Items[0].Text = "Descending";
                order = "DESC";
                sortBy(order, vehicleDB, filter);
            }
            else
            {
                sortStrip2.Items[0].Text = "Ascending";
                order = "ASC";
                sortBy(order, vehicleDB, filter);
            }
        }

        // Sort by different criteria
        private void iDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "ID";
            vehicleDB = "vehicle_id";
            sortBy(order, vehicleDB, filter);
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Model";
            vehicleDB = "vehicle_model";
            sortBy(order, vehicleDB, filter);
        }

        private void ownerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Owner";
            vehicleDB = "vehicle_owner";
            sortBy(order, vehicleDB, filter);
        }

        private void plateStripMenuItem_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Plate";
            vehicleDB = "vehicle_plate";
            sortBy(order, vehicleDB, filter);
        }
        private void ownerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Owner Details";
            vehicleDB = "vehicle_ownerDetails";
            sortBy(order, vehicleDB, filter);
        }

        private void resolvedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Status";
            vehicleDB = "vehicle_status";
            sortBy(order, vehicleDB, filter);
        }

        private void idSort_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "ID";
            vehicleDB = "vehicle_id";
            sortBy(order, vehicleDB, filter);
            changeOrder();
        }

        private void modelSort_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Model";
            vehicleDB = "vehicle_model";
            sortBy(order, vehicleDB, filter);
            changeOrder();
        }

        private void ownerSort_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Owner";
            vehicleDB = "vehicle_owner";
            sortBy(order, vehicleDB, filter);
            changeOrder();
        }

        private void plateSort_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Plate";
            vehicleDB = "vehicle_plate";
            sortBy(order, vehicleDB, filter);
            changeOrder();
        }

        private void statusSort_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Status";
            vehicleDB = "vehicle_status";
            sortBy(order, vehicleDB, filter);
            changeOrder();
        }

        private void owner2Sort_Click(object sender, EventArgs e)
        {
            sortStrip.Items[0].Text = "Owner Details";
            vehicleDB = "vehicle_ownerDetails";
            sortBy(order, vehicleDB, filter);
            changeOrder();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stop beep
                if (string.IsNullOrWhiteSpace(searchBox.Text))
                {
                    resetView();
                }
                else
                {
                    filter = searchBox.Text.Trim();
                    sortBy(order, vehicleDB, filter);
                }
            }
        }

    }
}
