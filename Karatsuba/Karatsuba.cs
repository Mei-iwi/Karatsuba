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
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "⚠️ Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }


        }
        //This is a event to load form
        private void Karatsuba_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.robotic_hand;
        }

        //This is a event to exit form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        //####################################################################################################################

    }
}
