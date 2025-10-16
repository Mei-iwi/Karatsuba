namespace Karatsuba
{
    public partial class Karatsuba : Form
    {
        //this is the constructor of the class
        public KaratsubaTreeview algo;
        public static KaratsubaNode TreeResult;
        private long originalA, originalB;
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




        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to exit?", "⚠️ Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            return;
        }

        //hàm cawys chuỗi và hiển thị lại
        private void CatChuoiVaHienThi(long x, long y,
            TextBox txtDau, TextBox txtGiua, TextBox txtCuoi)
        {
            int maxSize = Math.Max(x.ToString().Length, y.ToString().Length);
            int halfSize = maxSize / 2;

            long a = x / (long)Math.Pow(10, halfSize);
            long b = x % (long)Math.Pow(10, halfSize);
            long c = y / (long)Math.Pow(10, halfSize);
            long d = y % (long)Math.Pow(10, halfSize);

            txt_ChuoiDau.Text = $"({a} ; {c})";
            txt_ChuoiGiua.Text = $"({a + b} ; {c + d})";
            txt_ChuoiCuoi.Text = $"({b} ; {d})";
        }
        //button cắt chuỗi
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                if (!long.TryParse(txt_NhapA.Text.Trim(), out long x) || !long.TryParse(txt_NhapB.Text.Trim(), out long y))
                {
                    MessageBox.Show("Nhập số nguyên");
                    return;
                }

                originalA = x;
                originalB = y;

                CatChuoiVaHienThi(x, y, txt_ChuoiDau, txt_ChuoiGiua, txt_ChuoiCuoi);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        //button cắt chuỗi đầu
        private void btn_CatChuoiDau_Click(object sender, EventArgs e)
        {
            //lay du liệu ac trong txtChuoiDau
            string dauText = txt_ChuoiDau.Text.Trim();
            //kiểm tra 
            if (!dauText.StartsWith("(") || !dauText.EndsWith(")") || !dauText.Contains(";"))
            {
                MessageBox.Show("Dứ liệu chuỗi đầu không hợp lệ");
                return;
            }
            // Tách a và c
            string[] parts = txt_ChuoiDau.Text.Replace("(", "")
                                  .Replace(")", "")
                                  .Replace(";", "")
                                  .Trim()
                                  .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
            {
                MessageBox.Show("Dữ liệu không đúng định dạng");
                return;
            }
            if (parts[0].Length == 1 & parts[1].Length == 1)
            {
                MessageBox.Show("Khoong thể tách được nữa");
                return;
            }

            long a = long.Parse(parts[0]);
            long c = long.Parse(parts[1]);
            // Gán lại lên ô nhập
            txt_NhapA.Text = a.ToString();
            txt_NhapB.Text = c.ToString();
            CatChuoiVaHienThi(a, c, txt_ChuoiDau, txt_ChuoiGiua, txt_ChuoiCuoi);
        }
        private void btn_CatChuoiGiua_Click(object sender, EventArgs e)
        {
            string giuaText = txt_ChuoiGiua.Text.Trim();
            //kiểm tra
            if (!giuaText.StartsWith("(") || !giuaText.EndsWith(")") || !giuaText.Contains(";"))
            {
                MessageBox.Show("Dứ liệu chuỗi giữa không hợp lệ");
                return;
            }
            //cat cac ky tu thua trong chuoi
           
            string[] parts = txt_ChuoiGiua.Text.Replace("(", "")
                                  .Replace(")", "")
                                  .Replace(";", "")
                                  .Trim()
                                  .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
            {
                MessageBox.Show("Dữ liệu không đúng định dạng");
                return;
            }
            if (parts[0].Length == 1 & parts[1].Length == 1)
            {
                MessageBox.Show("Khoong thể tách được nữa");
                return;
            }
            long ab = long.Parse(parts[0]);
            long cd = long.Parse(parts[1]);

            // Gán lại lên ô nhập
            txt_NhapA.Text = ab.ToString();
            txt_NhapB.Text = cd.ToString();
            CatChuoiVaHienThi(ab, cd, txt_ChuoiDau, txt_ChuoiGiua, txt_ChuoiCuoi);

        }

        private void btn_CatChuoiCuoi_Click(object sender, EventArgs e)
        {
            string cuoiText = txt_ChuoiCuoi.Text.Trim();
            //kiểm tra
            if (!cuoiText.StartsWith("(") || !cuoiText.EndsWith(")") || !cuoiText.Contains(";"))
            {
                MessageBox.Show("Dứ liệu chuỗi cuối không hợp lệ");
                return;
            }
            //cat cac ky tu thua trong chuoi
            string[] parts = txt_ChuoiCuoi.Text.Replace("(", "")
                                  .Replace(")", "")
                                  .Replace(";", "")
                                  .Trim()
                                  .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
                {
                MessageBox.Show("Dữ liệu không đúng định dạng");
                return;
            }
            if (parts[0].Length == 1 & parts[1].Length==1)
            {
                MessageBox.Show("Khoong thể tách được nữa");
                return;
            }
            long b = long.Parse(parts[0]);
            long d = long.Parse(parts[1]);
            // Gán lại lên ô nhập
            txt_NhapA.Text = b.ToString();
            txt_NhapB.Text = d.ToString();
            CatChuoiVaHienThi(b, d, txt_ChuoiDau, txt_ChuoiGiua, txt_ChuoiCuoi);

        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Khôi phục lại X, Y bước trước
            txt_NhapA.Text = originalA.ToString();
            txt_NhapB.Text = originalB.ToString();

            // Cắt lại chuỗi gốc để hiển thị
            CatChuoiVaHienThi(originalA, originalB, txt_ChuoiDau, txt_ChuoiGiua, txt_ChuoiCuoi);

            // Xóa dữ liệu cấp 2 cảu chuooiux đầu
            txt_ChuoiDau1.Clear();
            txt_ChuoiGiua1.Clear();
            txt_ChuoiCuoi1.Clear();

            //xoas chuỗi giữa
            txt_ChuoiDau2.Clear();
            txt_ChuoiGiua2.Clear();
            txt_ChuoiCuoi2.Clear();

            //xoas du lieu cap 2 o chuoi cuoi
            txt_ChuoiDau3.Clear();
            txt_ChuoiGiua3.Clear();
            txt_ChuoiCuoi3.Clear();
        }

       


        #endregion

        //####################################################################################################################

    }
}
