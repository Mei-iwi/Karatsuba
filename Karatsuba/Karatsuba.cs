namespace Karatsuba
{
    public partial class Karatsuba : Form
    {
        //this is the constructor of the class
        public KaratsubaTreeview algo;
        public static KaratsubaNode TreeResult;
        private long originalA, originalB;
        private int dongHienTai = 1;
        public Karatsuba()
        {
            InitializeComponent();
        }
        //####################################################################################################################

        #region This region contains all events of the form
        //This is a event to close form


        private void Close_Window(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "⚠️ Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

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
            //this.Hide();
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
            Close();
        }
        /// <summary>
        /// -------------------------------------------------------------------------------------------------------------------------------------------
        /// </summary>
        private void LuuKetQua(bool tuNodeGoc, int dong)
        {
            if (!tuNodeGoc)
            {
                // Clear các dòng khác ngoài dòng hiện tại
                for (int i = 1; i <= 3; i++)
                {
                    if (i == dong) continue;
                    TextBox txtD = this.Controls.Find($"txt_ChuoiDau{i}", true).FirstOrDefault() as TextBox;
                    TextBox txtG = this.Controls.Find($"txt_ChuoiGiua{i}", true).FirstOrDefault() as TextBox;
                    TextBox txtC = this.Controls.Find($"txt_ChuoiCuoi{i}", true).FirstOrDefault() as TextBox;

                    if (txtD != null) txtD.Clear();
                    if (txtG != null) txtG.Clear();
                    if (txtC != null) txtC.Clear();
                }
            }

            // Lưu dòng hiện tại
            TextBox txtDau = this.Controls.Find($"txt_ChuoiDau{dong}", true).FirstOrDefault() as TextBox;
            TextBox txtGiua = this.Controls.Find($"txt_ChuoiGiua{dong}", true).FirstOrDefault() as TextBox;
            TextBox txtCuoi = this.Controls.Find($"txt_ChuoiCuoi{dong}", true).FirstOrDefault() as TextBox;

            if (txtDau != null) txtDau.Text = txt_ChuoiDau.Text;
            if (txtGiua != null) txtGiua.Text = txt_ChuoiGiua.Text;
            if (txtCuoi != null) txtCuoi.Text = txt_ChuoiCuoi.Text;
        }

        // Đồng bộ bảng xuống textbox gốc
        private void DongBoTextBoxXuongBangc(int dong)
        {
            // Lấy 3 textbox dòng tương ứng trong bảng
            TextBox txtDau = this.Controls.Find($"txt_ChuoiDau{dong}", true).FirstOrDefault() as TextBox;
            TextBox txtGiua = this.Controls.Find($"txt_ChuoiGiua{dong}", true).FirstOrDefault() as TextBox;
            TextBox txtCuoi = this.Controls.Find($"txt_ChuoiCuoi{dong}", true).FirstOrDefault() as TextBox;

            if (txtDau != null) txtDau.Text = txt_ChuoiDau.Text;
            if (txtGiua != null) txtGiua.Text = txt_ChuoiGiua.Text;
            if (txtCuoi != null) txtCuoi.Text = txt_ChuoiCuoi.Text;
        }
    

       
        
        /// ---------------------------------------------------------------------------------------------------------------------------///
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
            ///cập nhật lại bảng ở dưới
            LuuKetQua(true, 1); // node gốc
            dongHienTai = 1;
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
            //CapNhatBangKetQua//
            LuuKetQua(false, 1); // node con, clear các dòng khác
            dongHienTai = 1;
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
            //CapNhatBangKetQua("Dau", txt_ChuoiDau.Text, txt_ChuoiGiua.Text, txt_ChuoiCuoi.Text);
            LuuKetQua(false, 1);
            dongHienTai = 1;
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
            if (parts[0].Length == 1 & parts[1].Length == 1)
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
            //cập nhật 
            LuuKetQua(false, 1);
            dongHienTai = 1;

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
            //txt_ChuoiDau2.Clear();
            //txt_ChuoiGiua2.Clear();
            //txt_ChuoiCuoi2.Clear();

            ////xoas du lieu cap 2 o chuoi cuoi
            //txt_ChuoiDau3.Clear();
            //txt_ChuoiGiua3.Clear();
            //txt_ChuoiCuoi3.Clear();
            //cập nhật 
          
        }
        private void TinhDong(TextBox txtGocDau, TextBox txtGocGiua, TextBox txtGocCuoi,
                       TextBox txtDongDau, TextBox txtDongGiua, TextBox txtDongCuoi)
        {
            txtDongDau.Text = TinhKaratsubaTuTextBox(txtGocDau);
            txtDongGiua.Text = TinhKaratsubaTuTextBox(txtGocGiua);
            txtDongCuoi.Text = TinhKaratsubaTuTextBox(txtGocCuoi);
        }

        private string TinhKaratsubaTuTextBox(TextBox txt)
        {
            string s = txt.Text.Trim('(', ')');
            string[] parts = s.Split(';').Select(p => p.Trim()).ToArray();
            if (parts.Length == 2 &&
                long.TryParse(parts[0], out long a) &&
                long.TryParse(parts[1], out long b))
            {
                Karatsuba_Algrorithm kar = new Karatsuba_Algrorithm(a, b);
                return kar.Result.ToString();
            }
            return "0";
        }
        private void btn_ChuoiDau_Click(object sender, EventArgs e)
        {
          

            txt_ChuoiDau1.Text = TinhKaratsubaTuTextBox(txt_ChuoiDau);
            txt_ChuoiGiua1.Text = TinhKaratsubaTuTextBox(txt_ChuoiGiua);
            txt_ChuoiCuoi1.Text = TinhKaratsubaTuTextBox(txt_ChuoiCuoi);

             // lưu kết quả trở lại bảng dòng 1
        }

        //private void btn_ChuoiGiua_Click(object sender, EventArgs e)
        //{
          

        //    txt_ChuoiDau2.Text = TinhKaratsubaTuTextBox(txt_ChuoiDau);
        //    txt_ChuoiGiua2.Text = TinhKaratsubaTuTextBox(txt_ChuoiGiua);
        //    txt_ChuoiCuoi2.Text = TinhKaratsubaTuTextBox(txt_ChuoiCuoi);

          
        //}

        //private void btn_ChuoiCuoi_Click(object sender, EventArgs e)
        //{
           

        //    txt_ChuoiDau3.Text = TinhKaratsubaTuTextBox(txt_ChuoiDau);
        //    txt_ChuoiGiua3.Text = TinhKaratsubaTuTextBox(txt_ChuoiGiua);
        //    txt_ChuoiCuoi3.Text = TinhKaratsubaTuTextBox(txt_ChuoiCuoi);

            
        //}




        #endregion

        //####################################################################################################################

    }
}
