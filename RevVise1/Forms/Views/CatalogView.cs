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

        private void addButtonClick(object sender, EventArgs e)
        {
            Item item = new Item();
            ShowView(item);
            item.Size = new Size(900, 55);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
