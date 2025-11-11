using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevVise1.Forms.Views
{
    public partial class Item : UserControl
    {
        RevDB db = new RevDB();

        private Size size;
        bool itemExpand = false;
        bool itemExpand2 = false;

        // for db ?
        int id;
        String model;
        String contact;
        String plate;
        String entry;
        String status;
        String dateIssuedValue;
        String dateResolvedValue;
        String SQL;


        public Item(int id)
        {
            InitializeComponent();

            this.Location.Y.Equals(id * this.Height);
            IDLabel.Text = id.ToString();

            id = Int32.Parse(IDLabel.Text);
            model = modelText.Text;
            contact = contactText.Text;
            plate = plateText.Text;
            entry = entryText.Text;
            status = statusLabel.Text;
            dateIssued.Text = DateTime.Now.ToShortDateString();
            dateIssuedValue = DateTime.Now.ToShortDateString();

            addEntry(id, model, contact, plate, entry, status, dateIssuedValue);

            size = new Size(900, 55);
        }

        public Item(int id, bool isPreload)
        {
            InitializeComponent();
            this.Size = new Size(900, 55);
            this.Location.Y.Equals(id * this.Height);
            IDLabel.Text = id.ToString();

            id = Int32.Parse(IDLabel.Text);
            model = modelText.Text;
            contact = contactText.Text;
            plate = plateText.Text;
            entry = entryText.Text;
            status = statusLabel.Text;
            dateIssued.Text = DateTime.Now.ToShortDateString();
            dateIssuedValue = DateTime.Now.ToShortDateString();


            size = new Size(900, 55);
        }

        private void showTextBox()
        {
            SuspendLayout();
            modelText.Visible = true;
            contactText.Visible = true;
            plateText.Visible = true;
            entryText.Visible = true;

            entryTitle.Visible = true;
            ownerDetailsText.Visible = true;

            ResumeLayout(false);
        }

        private void showTextLabel()
        {
            modelLabel.Visible = true;
            contactLabel.Visible = true;
            plateLabel.Visible = true;
            entryTitle.Visible = true;

            ownerDetailsLabel.Visible = true;

        }

        private void hideTextBox()
        {
            SuspendLayout();
            modelText.Hide();
            contactText.Hide();
            plateText.Hide();
            entryText.Hide();

            entryTitle.Hide();
            ownerDetailsText.Hide();


            ResumeLayout(false);
        }

        private void hideTextLabel()
        {
            modelLabel.Hide();
            contactLabel.Hide();
            plateLabel.Hide();
            entryTitle.Hide();

            ownerDetailsLabel.Hide();

        }

        private void saveTexts()
        {
            modelLabel.Text = modelText.Text;
            contactLabel.Text = contactText.Text;
            plateLabel.Text = plateText.Text;
            entryLabel.Text = entryText.Text;
            ownerDetailsLabel.Text = ownerDetailsText.Text;
        }
        //sql commands
        private void addEntry(int id, string model, string contact, string plate, string entry, string status, string dateIssuedValue)
        {
            SQL = "INSERT INTO tbl_motor(motor_id,motor_model,motor_owner,motor_plate,motor_entry,motor_status,motor_dateIssued) " +
                "VALUES('" + id + "','" + model + "','" + contact + "','" + plate + "','" + entry + "','" + status + "','" + dateIssuedValue + "')";
            db.SQLManager(SQL);
        }

        private void updateEntry(int id, string model, string contact, string plate, string entry, string status, string dateIssuedValue, string dateResolvedValue)
        {
            SQL = $"UPDATE tbl_motor SET " +
                $"motor_model='{model}',motor_owner='{contact}',motor_plate='{plate}',motor_entry='{entry}',motor_status='{status}',motor_dateIssued='{dateIssuedValue}',motor_dateResolved='{dateResolvedValue}'" +
                $"WHERE motor_id='{id}'";
            db.SQLManager(SQL);
        }
        private void deleteEntry(int id)
        {
            SQL = $"DELETE FROM tbl_motor WHERE motor_id='{id}'";
            db.SQLManager(SQL);
        }
        private void Edit_Click(object sender, EventArgs e)// saving
        {
            if (!itemExpand2)
            {
                this.Size = new Size(size.Width, size.Height * 5);
                editButton.Text = "Save";
                hideTextLabel();
                showTextBox();


                itemExpand2 = true;
            }
            else
            {
                this.Size = size;
                editButton.Text = "Edit";


                saveTexts();

                id = Int32.Parse(IDLabel.Text);
                model = modelText.Text;
                contact = contactText.Text;
                plate = plateText.Text;
                entry = entryText.Text;
                status = statusLabel.Text;
                dateIssuedValue = dateIssued.Text;
                dateResolvedValue = dateResolved.Text;
                updateEntry(id, model, contact, plate, entry, status, dateIssuedValue, dateResolvedValue);
                hideTextBox();
                showTextLabel();

                entryTitle.Hide();

                itemExpand2 = false;
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            id = Int32.Parse(IDLabel.Text);
            this.Dispose();
            deleteEntry(id);
        }

        private void hover(object sender, EventArgs e)
        {
            if (!itemExpand2)
            {
                this.BackColor = Color.LightGray;
            }
        }

        private void nothover(object sender, EventArgs e)
        {
            if (!itemExpand2)
            {
                this.BackColor = Color.White;
            }
        }

        private void clickItem(object sender, EventArgs e)
        {
            if (!itemExpand && !itemExpand2)
            {
                this.Size = new Size(size.Width, size.Height * 5);
                entryTitle.Show();
                entryLabel.Show();
                resolveButton.Hide();
                entryText.Enabled = false;

                editButton.Enabled = false;

                itemExpand = true;
            }
            else if (itemExpand && !itemExpand2)
            {
                this.Size = size;
                entryTitle.Hide();
                entryLabel.Hide();
                resolveButton.Show();
                resolveButton.Enabled = true;
                entryText.Enabled = true;
                editButton.Enabled = true;

                itemExpand = false;
            }
        }

        private void resolveButton_Click(object sender, EventArgs e)
        {
            if (!dateResolved.Text.Equals("Unresolved"))
            {
                resolveButton.Text = "Resolve";

                dateResolvedValue = "Unresolved";
                statusLabel.Text = "Unresolved";
                dateResolved.Text = "Unresolved";

            }

            else
            {
                resolveButton.Text = "Unresolve";

                statusLabel.Text = "Resolved";
                dateResolved.Text = DateTime.Now.ToShortDateString();
                dateResolvedValue = DateTime.Now.ToShortDateString();
            }

        }

        private void modelClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modelText.Text) || modelText.Text.Equals("Model"))
            {
                modelText.Text = "";
            }
        }

        private void contactClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contactText.Text) || contactText.Text.Equals("Contact"))
            {
                contactText.Text = "";
            }
        }

        private void plateClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(plateText.Text) || plateText.Text.Equals("Plate No.")) {
                plateText.Text = "";
            }
        }

        private void entryClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(entryText.Text) || entryText.Text.Equals("Entry"))
            {
                entryText.Text = "";
            }
        }

        //setter getter
        public string Model
        {
            get { return modelText.Text; }
            set { modelText.Text = value; modelLabel.Text = value; }
        }

        public string Contact
        {
            get { return contactText.Text; }
            set { contactText.Text = value; contactLabel.Text = value; }
        }

        public string Plate
        {
            get { return plateText.Text; }
            set { plateText.Text = value; plateLabel.Text = value; }
        }

        public string Entry
        {
            get { return entryText.Text; }
            set { entryText.Text = value; entryLabel.Text = value; }
        }

        public string Status
        {
            get { return statusLabel.Text; }
            set { statusLabel.Text = value; }
        }

        public string DateIssued
        {
            get { return dateIssued.Text; }
            set { dateIssued.Text = value; }
        }

        public string DateResolved
        {
            get { return dateResolved.Text; }
            set { dateResolved.Text = value; }
        }
    }
}
