namespace Karatsuba
{
    partial class Karatsuba
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public FontStyle FontStyle { get; private set; }

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Karatsuba));
            groupBox1 = new GroupBox();
            btn_ChuoiDau = new Button();
            textBox9 = new TextBox();
            txt_ChuoiDau1 = new TextBox();
            txt_ChuoiGiua1 = new TextBox();
            txt_ChuoiCuoi1 = new TextBox();
            btn_KetQua = new Button();
            btnExit = new Button();
            txt_KetQua = new TextBox();
            txt_NhapB = new TextBox();
            label1 = new Label();
            txt_NhapA = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label16 = new Label();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            txt_ChuoiGiua = new TextBox();
            txt_ChuoiDau = new TextBox();
            txt_ChuoiCuoi = new TextBox();
            btn_LoadTreeView = new Button();
            button6 = new Button();
            btn_CatChuoiDau = new Button();
            btn_CatChuoiGiua = new Button();
            btn_CatChuoiCuoi = new Button();
            btn_Back = new Button();
            btnDeleteAll = new Button();
            txt_ThoiGian = new TextBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txt_TGTra = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_ChuoiDau);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(txt_ChuoiDau1);
            groupBox1.Controls.Add(txt_ChuoiGiua1);
            groupBox1.Controls.Add(txt_ChuoiCuoi1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(511, 198);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(372, 316);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Xử lý chia";
            // 
            // btn_ChuoiDau
            // 
            btn_ChuoiDau.Location = new Point(27, 221);
            btn_ChuoiDau.Margin = new Padding(5);
            btn_ChuoiDau.Name = "btn_ChuoiDau";
            btn_ChuoiDau.Size = new Size(311, 69);
            btn_ChuoiDau.TabIndex = 58;
            btn_ChuoiDau.Text = "Tính chuỗi đầu";
            btn_ChuoiDau.UseVisualStyleBackColor = true;
            btn_ChuoiDau.Click += btn_ChuoiDau_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(55, -60);
            textBox9.Margin = new Padding(5);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(132, 26);
            textBox9.TabIndex = 25;
            // 
            // txt_ChuoiDau1
            // 
            txt_ChuoiDau1.BorderStyle = BorderStyle.FixedSingle;
            txt_ChuoiDau1.Enabled = false;
            txt_ChuoiDau1.Font = new Font("Tahoma", 12F);
            txt_ChuoiDau1.Location = new Point(27, 43);
            txt_ChuoiDau1.Margin = new Padding(5);
            txt_ChuoiDau1.Name = "txt_ChuoiDau1";
            txt_ChuoiDau1.Size = new Size(311, 32);
            txt_ChuoiDau1.TabIndex = 27;
            txt_ChuoiDau1.TextAlign = HorizontalAlignment.Center;
            txt_ChuoiDau1.TextChanged += txt_ChuoiDau1_TextChanged;
            // 
            // txt_ChuoiGiua1
            // 
            txt_ChuoiGiua1.BorderStyle = BorderStyle.FixedSingle;
            txt_ChuoiGiua1.Enabled = false;
            txt_ChuoiGiua1.Font = new Font("Tahoma", 12F);
            txt_ChuoiGiua1.Location = new Point(27, 106);
            txt_ChuoiGiua1.Margin = new Padding(5);
            txt_ChuoiGiua1.Name = "txt_ChuoiGiua1";
            txt_ChuoiGiua1.Size = new Size(311, 32);
            txt_ChuoiGiua1.TabIndex = 22;
            txt_ChuoiGiua1.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_ChuoiCuoi1
            // 
            txt_ChuoiCuoi1.BorderStyle = BorderStyle.FixedSingle;
            txt_ChuoiCuoi1.Enabled = false;
            txt_ChuoiCuoi1.Font = new Font("Tahoma", 12F);
            txt_ChuoiCuoi1.Location = new Point(27, 165);
            txt_ChuoiCuoi1.Margin = new Padding(5);
            txt_ChuoiCuoi1.Name = "txt_ChuoiCuoi1";
            txt_ChuoiCuoi1.Size = new Size(311, 32);
            txt_ChuoiCuoi1.TabIndex = 28;
            txt_ChuoiCuoi1.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_KetQua
            // 
            btn_KetQua.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_KetQua.Location = new Point(1097, 96);
            btn_KetQua.Margin = new Padding(5);
            btn_KetQua.Name = "btn_KetQua";
            btn_KetQua.Size = new Size(208, 86);
            btn_KetQua.TabIndex = 53;
            btn_KetQua.Text = "Kết quả";
            btn_KetQua.UseVisualStyleBackColor = true;
            btn_KetQua.Click += btn_KetQua_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(190, 551);
            btnExit.Margin = new Padding(5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(143, 48);
            btnExit.TabIndex = 54;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txt_KetQua
            // 
            txt_KetQua.Font = new Font("Tahoma", 12F);
            txt_KetQua.Location = new Point(920, 224);
            txt_KetQua.Margin = new Padding(5);
            txt_KetQua.Multiline = true;
            txt_KetQua.Name = "txt_KetQua";
            txt_KetQua.ReadOnly = true;
            txt_KetQua.ScrollBars = ScrollBars.Both;
            txt_KetQua.Size = new Size(551, 171);
            txt_KetQua.TabIndex = 50;
            txt_KetQua.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_NhapB
            // 
            txt_NhapB.Font = new Font("Tahoma", 12F);
            txt_NhapB.Location = new Point(150, 130);
            txt_NhapB.Margin = new Padding(5);
            txt_NhapB.Name = "txt_NhapB";
            txt_NhapB.Size = new Size(517, 32);
            txt_NhapB.TabIndex = 56;
            txt_NhapB.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(328, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 52);
            label1.TabIndex = 39;
            label1.Text = "ĐẦU VÀO";
            // 
            // txt_NhapA
            // 
            txt_NhapA.Font = new Font("Tahoma", 12F);
            txt_NhapA.Location = new Point(150, 76);
            txt_NhapA.Margin = new Padding(5);
            txt_NhapA.Name = "txt_NhapA";
            txt_NhapA.Size = new Size(517, 32);
            txt_NhapA.TabIndex = 40;
            txt_NhapA.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label4.Location = new Point(7, 144);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 24);
            label4.TabIndex = 45;
            label4.Text = "Chuỗi giữa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label3.Location = new Point(7, 47);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 24);
            label3.TabIndex = 44;
            label3.Text = "Chuỗi đầu";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label16.Location = new Point(920, 188);
            label16.Margin = new Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new Size(79, 20);
            label16.TabIndex = 49;
            label16.Text = "Kết quả:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(22, 130);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 48;
            label6.Text = "Nhập số B";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(22, 76);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 47;
            label2.Text = "Nhập số A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label5.Location = new Point(7, 231);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 24);
            label5.TabIndex = 46;
            label5.Text = "Chuỗi cuối";
            // 
            // txt_ChuoiGiua
            // 
            txt_ChuoiGiua.BorderStyle = BorderStyle.FixedSingle;
            txt_ChuoiGiua.Enabled = false;
            txt_ChuoiGiua.Font = new Font("Tahoma", 12F);
            txt_ChuoiGiua.Location = new Point(135, 144);
            txt_ChuoiGiua.Margin = new Padding(5);
            txt_ChuoiGiua.Name = "txt_ChuoiGiua";
            txt_ChuoiGiua.Size = new Size(311, 32);
            txt_ChuoiGiua.TabIndex = 58;
            txt_ChuoiGiua.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_ChuoiDau
            // 
            txt_ChuoiDau.BorderStyle = BorderStyle.FixedSingle;
            txt_ChuoiDau.Enabled = false;
            txt_ChuoiDau.Font = new Font("Tahoma", 12F);
            txt_ChuoiDau.Location = new Point(135, 47);
            txt_ChuoiDau.Margin = new Padding(5);
            txt_ChuoiDau.Name = "txt_ChuoiDau";
            txt_ChuoiDau.Size = new Size(311, 32);
            txt_ChuoiDau.TabIndex = 59;
            txt_ChuoiDau.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_ChuoiCuoi
            // 
            txt_ChuoiCuoi.BorderStyle = BorderStyle.FixedSingle;
            txt_ChuoiCuoi.Enabled = false;
            txt_ChuoiCuoi.Font = new Font("Tahoma", 12F);
            txt_ChuoiCuoi.Location = new Point(135, 229);
            txt_ChuoiCuoi.Margin = new Padding(5);
            txt_ChuoiCuoi.Name = "txt_ChuoiCuoi";
            txt_ChuoiCuoi.Size = new Size(311, 32);
            txt_ChuoiCuoi.TabIndex = 60;
            txt_ChuoiCuoi.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_LoadTreeView
            // 
            btn_LoadTreeView.BackColor = Color.LimeGreen;
            btn_LoadTreeView.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_LoadTreeView.ForeColor = Color.White;
            btn_LoadTreeView.Location = new Point(934, 534);
            btn_LoadTreeView.Margin = new Padding(3, 4, 3, 4);
            btn_LoadTreeView.Name = "btn_LoadTreeView";
            btn_LoadTreeView.Size = new Size(146, 69);
            btn_LoadTreeView.TabIndex = 61;
            btn_LoadTreeView.Text = "LoadTreeView";
            btn_LoadTreeView.UseVisualStyleBackColor = false;
            btn_LoadTreeView.Click += btn_LoadTreeView_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Blue;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(675, 76);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(208, 86);
            button6.TabIndex = 62;
            button6.Text = "Cắt chuỗi";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // btn_CatChuoiDau
            // 
            btn_CatChuoiDau.BackColor = Color.Blue;
            btn_CatChuoiDau.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_CatChuoiDau.ForeColor = Color.White;
            btn_CatChuoiDau.Location = new Point(208, 93);
            btn_CatChuoiDau.Margin = new Padding(3, 4, 3, 4);
            btn_CatChuoiDau.Name = "btn_CatChuoiDau";
            btn_CatChuoiDau.Size = new Size(155, 36);
            btn_CatChuoiDau.TabIndex = 63;
            btn_CatChuoiDau.Text = "Cắt chuỗi đầu";
            btn_CatChuoiDau.UseVisualStyleBackColor = false;
            btn_CatChuoiDau.Click += btn_CatChuoiDau_Click;
            // 
            // btn_CatChuoiGiua
            // 
            btn_CatChuoiGiua.BackColor = Color.Blue;
            btn_CatChuoiGiua.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_CatChuoiGiua.ForeColor = Color.White;
            btn_CatChuoiGiua.Location = new Point(208, 185);
            btn_CatChuoiGiua.Margin = new Padding(3, 4, 3, 4);
            btn_CatChuoiGiua.Name = "btn_CatChuoiGiua";
            btn_CatChuoiGiua.Size = new Size(155, 36);
            btn_CatChuoiGiua.TabIndex = 64;
            btn_CatChuoiGiua.Text = "Cắt chuỗi giữa";
            btn_CatChuoiGiua.UseVisualStyleBackColor = false;
            btn_CatChuoiGiua.Click += btn_CatChuoiGiua_Click;
            // 
            // btn_CatChuoiCuoi
            // 
            btn_CatChuoiCuoi.BackColor = Color.Blue;
            btn_CatChuoiCuoi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_CatChuoiCuoi.ForeColor = Color.White;
            btn_CatChuoiCuoi.Location = new Point(208, 273);
            btn_CatChuoiCuoi.Margin = new Padding(3, 4, 3, 4);
            btn_CatChuoiCuoi.Name = "btn_CatChuoiCuoi";
            btn_CatChuoiCuoi.Size = new Size(155, 36);
            btn_CatChuoiCuoi.TabIndex = 65;
            btn_CatChuoiCuoi.Text = "Cắt chuỗi cuối";
            btn_CatChuoiCuoi.UseVisualStyleBackColor = false;
            btn_CatChuoiCuoi.Click += btn_CatChuoiCuoi_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.Black;
            btn_Back.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = Color.White;
            btn_Back.Location = new Point(377, 551);
            btn_Back.Margin = new Padding(3, 4, 3, 4);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(143, 48);
            btn_Back.TabIndex = 66;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDeleteAll.ForeColor = SystemColors.ActiveCaptionText;
            btnDeleteAll.Location = new Point(12, 551);
            btnDeleteAll.Margin = new Padding(5);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(143, 48);
            btnDeleteAll.TabIndex = 67;
            btnDeleteAll.Text = "Xóa hết";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // txt_ThoiGian
            // 
            txt_ThoiGian.BorderStyle = BorderStyle.FixedSingle;
            txt_ThoiGian.Enabled = false;
            txt_ThoiGian.Font = new Font("Tahoma", 12F);
            txt_ThoiGian.Location = new Point(1197, 421);
            txt_ThoiGian.Margin = new Padding(5);
            txt_ThoiGian.Name = "txt_ThoiGian";
            txt_ThoiGian.Size = new Size(241, 32);
            txt_ThoiGian.TabIndex = 59;
            txt_ThoiGian.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_ChuoiGiua);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btn_CatChuoiCuoi);
            groupBox2.Controls.Add(txt_ChuoiDau);
            groupBox2.Controls.Add(btn_CatChuoiGiua);
            groupBox2.Controls.Add(txt_ChuoiCuoi);
            groupBox2.Controls.Add(btn_CatChuoiDau);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 198);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(478, 316);
            groupBox2.TabIndex = 68;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tách chuỗi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.ForeColor = Color.FromArgb(0, 0, 192);
            label7.Location = new Point(1097, 19);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(194, 52);
            label7.TabIndex = 69;
            label7.Text = "ĐẦU RA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.Location = new Point(920, 427);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(222, 20);
            label8.TabIndex = 70;
            label8.Text = "Thời gian xử lý Karatsuba";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.Location = new Point(920, 480);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(239, 20);
            label9.TabIndex = 72;
            label9.Text = "Thời gian xử lý nhân thường";
            // 
            // txt_TGTra
            // 
            txt_TGTra.BorderStyle = BorderStyle.FixedSingle;
            txt_TGTra.Enabled = false;
            txt_TGTra.Font = new Font("Tahoma", 12F);
            txt_TGTra.Location = new Point(1197, 474);
            txt_TGTra.Margin = new Padding(5);
            txt_TGTra.Name = "txt_TGTra";
            txt_TGTra.Size = new Size(241, 32);
            txt_TGTra.TabIndex = 71;
            txt_TGTra.TextAlign = HorizontalAlignment.Center;
            // 
            // Karatsuba
            // 
            AcceptButton = btn_KetQua;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Silver;
            CancelButton = btnExit;
            ClientSize = new Size(1485, 617);
            Controls.Add(label9);
            Controls.Add(txt_TGTra);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(txt_ThoiGian);
            Controls.Add(btnDeleteAll);
            Controls.Add(btn_Back);
            Controls.Add(btn_KetQua);
            Controls.Add(button6);
            Controls.Add(btn_LoadTreeView);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(txt_KetQua);
            Controls.Add(txt_NhapB);
            Controls.Add(label1);
            Controls.Add(txt_NhapA);
            Controls.Add(label16);
            Controls.Add(label6);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Karatsuba";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Karatsuba algorithm";
            FormClosing += Close_Window;
            Load += Karatsuba_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox textBox9;
        private TextBox txt_ChuoiDau1;
        private TextBox txt_ChuoiGiua1;
        private TextBox txt_ChuoiCuoi1;
        private Button btnExit;
        private Button btn_KetQua;
        private TextBox txt_KetQua;
        private TextBox txt_NhapB;
        private Label label1;
        private TextBox txt_NhapA;
        private Label label4;
        private Label label3;
        private Label label16;
        private Label label6;
        private Label label2;
        private Label label5;
        private Button btn_ChuoiDau;
        private TextBox txt_ChuoiGiua;
        private TextBox txt_ChuoiDau;
        private TextBox txt_ChuoiCuoi;
        private Button btn_LoadTreeView;
        private Button button6;
        private Button btn_CatChuoiDau;
        private Button btn_CatChuoiGiua;
        private Button btn_CatChuoiCuoi;
        private Button btn_Back;
        private Button btnDeleteAll;
        private TextBox txt_ThoiGian;
        private GroupBox groupBox2;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_TGTra;
    }
}
