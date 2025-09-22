namespace Karatsuba
{
    public partial class Karatsuba : Form
    {
        //this is the constructor of the class
        public Karatsuba()
        {
            InitializeComponent();
        }
        //####################################################################################################################

        #region This region contains all events of the form
        //This is a event to close form
        private void Close_Window(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }


        }
        #endregion

        //####################################################################################################################

    }
}
