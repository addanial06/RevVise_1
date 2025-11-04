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

        public Item(int id)
        {
            InitializeComponent();

            this.Location.Y.Equals(id * this.Height);
            IDLabel.Text = id.ToString();

            entryText.Location = new Point(modelLabel.Location.X, modelLabel.Location.Y + 30);
            entryLabel.Location = new Point(modelLabel.Location.X, modelLabel.Location.Y + 30);



            size = this.Size;
        }

        private void showTextBox()
        {
            SuspendLayout();
            modelText.Visible = true;
            contactText.Visible = true;
            vehicleText.Visible = true;
            entryText.Visible = true;

            ResumeLayout(false);
        }

        private void showTextLabel()
        {
            modelLabel.Visible = true;
            contactLabel.Visible = true;
            vehicleLabel.Visible = true;
        }

        private void hideTextBox()
        {
            SuspendLayout();
            modelText.Hide();
            contactText.Hide();
            vehicleText.Hide();
            entryText.Hide();


            ResumeLayout(false);
        }

        private void hideTextLabel()
        {
            modelLabel.Hide();
            contactLabel.Hide();
            vehicleLabel.Hide();
        }

        private void saveTexts()
        {
            modelLabel.Text = modelText.Text;
            contactLabel.Text = contactText.Text;
            vehicleLabel.Text = vehicleText.Text;
            entryLabel.Text = entryText.Text;
        }

        private void Item_Click(object sender, EventArgs e)
        {
            if (!itemExpand)
            {
                this.Size = new Size(size.Width, size.Height * 5);

                entryLabel.Show();
                entryText.Enabled = false;

                editButton.Enabled = false;
                
                itemExpand = true;
            }
            else
            {
                this.Size = size;

                entryLabel.Hide();
                entryText.Enabled = true;
                editButton.Enabled = true;

                itemExpand = false;
            }

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (!itemExpand2)
            {
                this.Size = new Size(size.Width, size.Height * 5);
                editButton.Text = "Save";

                showTextBox();
                hideTextLabel();



                itemExpand2 = true;
            }
            else
            {
                this.Size = size;
                editButton.Text = "Edit";


                saveTexts();
                hideTextBox();
                showTextLabel();

                itemExpand2 = false;
            }
        }
    }
}
