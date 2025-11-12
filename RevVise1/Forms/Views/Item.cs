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
        Logger logger = new Logger("CatalogItem", Session.Username);

        private Size size;
        bool itemExpand = false;
        bool itemExpand2 = false;
        bool isNewEntry = false;

        int userId = Session.UserID;
        int id;
        String model;
        String owner;
        String plate;
        String entry;
        String status;
        String dateIssuedValue;
        String dateResolvedValue;
        String ownerDetails;
        String SQL;


        public Item(int id = 0, bool isPreload = false)
        {
            InitializeComponent();

            this.Size = new Size(900, 55);
            this.Location.Y.Equals(id * this.Height);


            if (isPreload)
            {
                IDLabel.Text = id.ToString();

                this.id = id;
                model = modelText.Text;
                owner = ownerText.Text;
                plate = plateText.Text;
                entry = entryText.Text;
                status = statusLabel.Text;
                dateIssued.Text = DateTime.Now.ToShortDateString();
                dateIssuedValue = DateTime.Now.ToShortDateString();

                isNewEntry = false;
            }
            else
            {
                IDLabel.Text = "ID";
                this.id = 0;
                isNewEntry = true;

                model = modelText.Text;
                owner = ownerText.Text;
                plate = plateText.Text;
                entry = entryText.Text;
                status = statusLabel.Text;
                dateIssued.Text = DateTime.Now.ToShortDateString();
                dateIssuedValue = DateTime.Now.ToShortDateString();
                ownerDetails = ownerDetailsText.Text;


            }

            size = new Size(900, 55);
        }

        private void showTextBox()
        {
            SuspendLayout();
            modelText.Visible = true;
            ownerText.Visible = true;
            plateText.Visible = true;
            entryText.Visible = true;

            entryTitle.Visible = true;
            ownerDetailsText.Visible = true;

            ResumeLayout(false);
        }

        private void showTextLabel()
        {
            modelLabel.Visible = true;
            ownerLabel.Visible = true;
            plateLabel.Visible = true;
            entryTitle.Visible = true;

            ownerDetailsLabel.Visible = true;

        }

        private void hideTextBox()
        {
            modelText.Hide();
            ownerText.Hide();
            plateText.Hide();
            entryText.Hide();
            entryTitle.Hide();
            ownerDetailsText.Hide();
        }

        private void hideTextLabel()
        {
            modelLabel.Hide();
            ownerLabel.Hide();
            plateLabel.Hide();
            entryTitle.Hide();

            ownerDetailsLabel.Hide();

        }

        private void saveTexts(bool isNewEntry = false)
        {
            modelLabel.Text = modelText.Text;
            ownerLabel.Text = ownerText.Text;
            plateLabel.Text = plateText.Text;
            entryLabel.Text = entryText.Text;
            ownerDetailsLabel.Text = ownerDetailsText.Text;
        }
        //sql commands
        private void addEntry(string model, string contact, string plate, string entry, string status, string dateIssuedValue, string ownerDetails)
        {
            SQL = "INSERT INTO tbl_motor(motor_model,motor_owner,motor_plate,motor_entry,motor_status,motor_dateissued,motor_ownerdetails,user_id) " +
                 $"VALUES('{model}','{contact}','{plate}','{entry}','{status}','{dateIssuedValue}','{ownerDetails}','{userId}')";
            db.SQLManager(SQL);
            isNewEntry = false;
        }
        private void updateEntry(int id, string model, string contact, string plate, string entry, string status, string dateIssuedValue, string dateResolvedValue, string ownerDetails)
        {
            SQL = $"UPDATE tbl_motor SET " +
                $"motor_model='{model}',motor_owner='{contact}',motor_plate='{plate}',motor_entry='{entry}',motor_status='{status}',motor_dateIssued='{dateIssuedValue}',motor_dateResolved='{dateResolvedValue}',motor_ownerDetails='{ownerDetails}'" +
                $"WHERE motor_id='{id}' AND user_id='{userId}'";
            db.SQLManager(SQL);
        }
        private void deleteEntry(int id)
        {
            SQL = $"DELETE FROM tbl_motor WHERE motor_id='{id}' AND user_id='{userId}'";
            db.SQLManager(SQL);
        }
        private void Edit_Click(object sender, EventArgs e)// saving
        {
            if (!itemExpand2)
            {
                this.Size = new Size(900, size.Height * 5);
                editButton.Text = "Save";
                hideTextLabel();
                showTextBox();

                itemExpand2 = true;

                modelText.Focus();
            }
            else
            {
                this.Size = size;
                editButton.Text = "Edit";

                if (isNewEntry)
                {
                    addEntry(modelText.Text, ownerText.Text, plateText.Text, entryText.Text, statusLabel.Text, dateIssued.Text, ownerDetailsText.Text);
                    saveTexts(true);
                    logger.log($"Added motor {modelLabel.Text}, {ownerLabel.Text},{plateLabel.Text}.");
                }
                else
                {
                    string oldModel = modelLabel.Text;
                    string oldOwner = ownerLabel.Text;
                    string oldPlate = plateLabel.Text;
                    string oldStatus = statusLabel.Text;



                    updateEntry(id, modelText.Text, ownerText.Text, plateText.Text, entryText.Text, statusLabel.Text, dateIssued.Text, dateResolved.Text, ownerDetailsText.Text);
                    saveTexts();
                    logger.log($"Updated motor id={id} | Model: '{oldModel}' -> '{modelLabel.Text}', Owner: '{oldOwner}' -> '{ownerLabel.Text}', Plate: '{oldPlate}' -> '{plateLabel.Text}', Status: '{oldStatus}' -> '{statusLabel.Text}'");
                }

                hideTextBox();
                showTextLabel();

                entryTitle.Hide();

                itemExpand2 = false;
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            if (!isNewEntry)
            {
                id = Int32.Parse(IDLabel.Text);
                logger.log($"Deleted motor id = {id}, Model = {modelText.Text}.");
                this.Dispose();
                deleteEntry(id);
            }
            this.Dispose();
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
                statusLabel.Text = "Unresolved";
                dateResolved.Text = "Unresolved";
                dateResolvedValue = "Unresolved";
            }
            else
            {
                resolveButton.Text = "Unresolve";
                statusLabel.Text = "Resolved";
                dateResolved.Text = DateTime.Now.ToShortDateString();
                dateResolvedValue = DateTime.Now.ToShortDateString();
            }

        }

        //textbox placeholders
        private void modelClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modelText.Text) || modelText.Text.Equals("Model"))
            {
                modelText.Text = "";
            }
        }

        private void ownerClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ownerText.Text) || ownerText.Text.Equals("Owner"))
            {
                ownerText.Text = "";
            }
        }

        private void plateClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(plateText.Text) || plateText.Text.Equals("Plate No."))
            {
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

        private void ownerDetailsClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ownerDetailsText.Text) || ownerDetailsText.Text.Equals("Owner Details")) ;
            {
                entryText.Text = "";
            }
        }

        private void modelText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ownerText.Focus();
            }
        }

        private void ownerText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                plateText.Focus();
            }
        }

        private void plateText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ownerDetailsText.Focus();
            }
        }

        private void ownerDetailsText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                entryText.Focus();
            }
        }

        private void entryText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                editButton.Focus();
            }
        }

        //setter getter for preload
        public string Model
        {
            get { return modelText.Text; }
            set { modelText.Text = value; modelLabel.Text = value; }
        }

        public string Owner
        {
            get { return ownerText.Text; }
            set { ownerText.Text = value; ownerLabel.Text = value; }
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

        public string OwnerDetails
        {
            get { return ownerDetailsText.Text; }
            set { ownerDetailsText.Text = value; ownerDetailsLabel.Text = value; }
        }
    }
}
