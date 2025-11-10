namespace RevVise1.Forms.Views
{
    public partial class Item : Form
    {

        private Size size;
        bool itemExpand = false;
        bool itemExpand2 = false;

        //for db maybe
        //string modelTextString;
        //string contactTextString;
        //string vehicleTextString;
        //string entryTextString;

        public Item()
        {
            InitializeComponent();

            //this.Location.Y.Equals(id * this.Height);
            size = this.Size;
        }
        private void showTextBox()
        {
        }

        private void showTextLabel()
        {
        }

        private void hideTextBox()
        {
        }

        private void hideTextLabel()
        {
        }

        // need to save to db but no db yet I donot know how to to this help Me P{lssss
        private void saveTexts()
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void modelText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
