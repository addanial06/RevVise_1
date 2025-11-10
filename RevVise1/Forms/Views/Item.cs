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

        private Size size;
        bool itemExpand = false;
        bool itemExpand2 = false;

        // for db ?
        int id;
        String model;
        String contact;
        String vehicle;
        String entry;
        String status;
        String dateIssuedValue;
        String dateResolvedValue;


        public Item(int id)
        {
            InitializeComponent();

            this.Location.Y.Equals(id * this.Height);
            IDLabel.Text = id.ToString();

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

        private void Edit_Click(object sender, EventArgs e)
        {
            if (!itemExpand2)
            {
                this.Size = new Size(size.Width, size.Height * 5);
                editButton.Text = "Save";

                // saving
                id = Int32.Parse(IDLabel.Text);
                model = modelText.Text;
                contact = contactText.Text;
                vehicle = plateText.Text;
                entry = entryText.Text;
                status = statusLabel.Text;

                hideTextLabel();
                showTextBox();


                itemExpand2 = true;
            }
            else
            {
                this.Size = size;
                editButton.Text = "Edit";


                saveTexts();

                hideTextBox();
                showTextLabel();

                entryTitle.Hide();

                itemExpand2 = false;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
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
                entryText.Enabled = false;

                editButton.Enabled = false;

                itemExpand = true;
            }
            else if (itemExpand && !itemExpand2)
            {
                this.Size = size;
                entryTitle.Hide();
                entryLabel.Hide();
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
    }
}
