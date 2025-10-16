namespace Karatsuba
{
    public partial class Karatsuba : Form
    {
        //this is the constructor of the class
        public KaratsubaTreeview algo;
        public static KaratsubaNode TreeResult;
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

        private void btn_LoadTreeView_Click(object sender, EventArgs e)
        {
            TreeView tv = new TreeView();
            tv.Show();
            this.Hide();
        }

        private void btn_KetQua_Click(object sender, EventArgs e)
        {
            try
            {
                long x = long.Parse(txt_NhapA.Text);
                long y = long.Parse(txt_NhapB.Text);

                algo = new KaratsubaTreeview();
                long result = algo.Compute(x, y);
                txt_KetQua.Text = result.ToString();

                // lưu cây kết quả để dùng
                TreeResult = algo.Root;


                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        int currentY = 20;

        

        private void btnExit_Click (object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to exit?", "⚠️ Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
                    {
                this.Close();
            }
            return;
        }


        #endregion

        //####################################################################################################################

    }
}
