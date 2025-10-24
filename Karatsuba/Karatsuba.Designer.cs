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
            label7 = new Label();
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(1062, 75);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(16, 20);
            label7.TabIndex = 57;
            label7.Text = ")";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_ChuoiDau);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(txt_ChuoiDau1);
            groupBox1.Controls.Add(txt_ChuoiGiua1);
            groupBox1.Controls.Add(txt_ChuoiCuoi1);
            groupBox1.Controls.Add(btn_KetQua);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(42, 297);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1133, 211);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Xử lý chia";
            // 
            // btn_ChuoiDau
            // 
            btn_ChuoiDau.Location = new Point(344, 116);
            btn_ChuoiDau.Margin = new Padding(5);
            btn_ChuoiDau.Name = "btn_ChuoiDau";
            btn_ChuoiDau.Size = new Size(195, 69);
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
            txt_ChuoiDau1.Multiline = true;
            txt_ChuoiDau1.Name = "txt_ChuoiDau1";
            txt_ChuoiDau1.Size = new Size(311, 61);
            txt_ChuoiDau1.TabIndex = 27;
            txt_ChuoiDau1.TextAlign = HorizontalAlignment.Center;
            txt_ChuoiDau1.TextChanged += txt_ChuoiDau1_TextChanged;
            // 
            // txt_ChuoiGiua1
            // 
            txt_ChuoiGiua1.BorderStyle = BorderStyle.FixedSingle;
            txt_ChuoiGiua1.Enabled = false;
            txt_ChuoiGiua1.Font = new Font("Tahoma", 12F);
            txt_ChuoiGiua1.Location = new Point(400, 43);
            txt_ChuoiGiua1.Margin = new Padding(5);
            txt_ChuoiGiua1.Multiline = true;
            txt_ChuoiGiua1.Name = "txt_ChuoiGiua1";
            txt_ChuoiGiua1.Size = new Size(311, 61);
            txt_ChuoiGiua1.TabIndex = 22;
            txt_ChuoiGiua1.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_ChuoiCuoi1
            // 
            txt_ChuoiCuoi1.BorderStyle = BorderStyle.FixedSingle;
            txt_ChuoiCuoi1.Enabled = false;
            txt_ChuoiCuoi1.Font = new Font("Tahoma", 12F);
            txt_ChuoiCuoi1.Location = new Point(787, 43);
            txt_ChuoiCuoi1.Margin = new Padding(5);
            txt_ChuoiCuoi1.Multiline = true;
            txt_ChuoiCuoi1.Name = "txt_ChuoiCuoi1";
            txt_ChuoiCuoi1.Size = new Size(311, 61);
            txt_ChuoiCuoi1.TabIndex = 28;
            txt_ChuoiCuoi1.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_KetQua
            // 
            btn_KetQua.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_KetQua.Location = new Point(561, 115);
            btn_KetQua.Margin = new Padding(5);
            btn_KetQua.Name = "btn_KetQua";
            btn_KetQua.Size = new Size(195, 69);
            btn_KetQua.TabIndex = 53;
            btn_KetQua.Text = "Kết quả";
            btn_KetQua.UseVisualStyleBackColor = true;
            btn_KetQua.Click += btn_KetQua_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(638, 611);
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
            txt_KetQua.Location = new Point(162, 524);
            txt_KetQua.Margin = new Padding(5);
            txt_KetQua.Multiline = true;
            txt_KetQua.Name = "txt_KetQua";
            txt_KetQua.ReadOnly = true;
            txt_KetQua.ScrollBars = ScrollBars.Both;
            txt_KetQua.Size = new Size(797, 49);
            txt_KetQua.TabIndex = 50;
            txt_KetQua.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_NhapB
            // 
            txt_NhapB.Font = new Font("Tahoma", 12F);
            txt_NhapB.Location = new Point(672, 59);
            txt_NhapB.Margin = new Padding(5);
            txt_NhapB.Multiline = true;
            txt_NhapB.Name = "txt_NhapB";
            txt_NhapB.Size = new Size(380, 48);
            txt_NhapB.TabIndex = 56;
            txt_NhapB.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(495, -4);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 52);
            label1.TabIndex = 39;
            label1.Text = "KARATSUBA";
            // 
            // txt_NhapA
            // 
            txt_NhapA.Font = new Font("Tahoma", 12F);
            txt_NhapA.Location = new Point(219, 59);
            txt_NhapA.Margin = new Padding(5);
            txt_NhapA.Multiline = true;
            txt_NhapA.Name = "txt_NhapA";
            txt_NhapA.Size = new Size(404, 48);
            txt_NhapA.TabIndex = 40;
            txt_NhapA.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label4.Location = new Point(518, 132);
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
            label3.Location = new Point(178, 132);
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
            label16.Location = new Point(75, 539);
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
            label6.Location = new Point(638, 75);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 48;
            label6.Text = ";";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(103, 75);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 47;
            label2.Text = "Karatsuba (";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label5.Location = new Point(882, 132);
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
            txt_ChuoiGiua.Location = new Point(437, 163);
            txt_ChuoiGiua.Margin = new Padding(5);
            txt_ChuoiGiua.Multiline = true;
            txt_ChuoiGiua.Name = "txt_ChuoiGiua";
            txt_ChuoiGiua.Size = new Size(311, 61);
            txt_ChuoiGiua.TabIndex = 58;
            txt_ChuoiGiua.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_ChuoiDau
            // 
            txt_ChuoiDau.BorderStyle = BorderStyle.FixedSingle;
            txt_ChuoiDau.Enabled = false;
            txt_ChuoiDau.Font = new Font("Tahoma", 12F);
            txt_ChuoiDau.Location = new Point(104, 163);
            txt_ChuoiDau.Margin = new Padding(5);
            txt_ChuoiDau.Multiline = true;
            txt_ChuoiDau.Name = "txt_ChuoiDau";
            txt_ChuoiDau.Size = new Size(311, 61);
            txt_ChuoiDau.TabIndex = 59;
            txt_ChuoiDau.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_ChuoiCuoi
            // 
            txt_ChuoiCuoi.BorderStyle = BorderStyle.FixedSingle;
            txt_ChuoiCuoi.Enabled = false;
            txt_ChuoiCuoi.Font = new Font("Tahoma", 12F);
            txt_ChuoiCuoi.Location = new Point(768, 163);
            txt_ChuoiCuoi.Margin = new Padding(5);
            txt_ChuoiCuoi.Multiline = true;
            txt_ChuoiCuoi.Name = "txt_ChuoiCuoi";
            txt_ChuoiCuoi.Size = new Size(311, 61);
            txt_ChuoiCuoi.TabIndex = 60;
            txt_ChuoiCuoi.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_LoadTreeView
            // 
            btn_LoadTreeView.BackColor = Color.LimeGreen;
            btn_LoadTreeView.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_LoadTreeView.ForeColor = Color.White;
            btn_LoadTreeView.Location = new Point(1013, 517);
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
            button6.Location = new Point(1086, 59);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(143, 61);
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
            btn_CatChuoiDau.Location = new Point(178, 233);
            btn_CatChuoiDau.Margin = new Padding(3, 4, 3, 4);
            btn_CatChuoiDau.Name = "btn_CatChuoiDau";
            btn_CatChuoiDau.Size = new Size(143, 55);
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
            btn_CatChuoiGiua.Location = new Point(518, 233);
            btn_CatChuoiGiua.Margin = new Padding(3, 4, 3, 4);
            btn_CatChuoiGiua.Name = "btn_CatChuoiGiua";
            btn_CatChuoiGiua.Size = new Size(143, 55);
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
            btn_CatChuoiCuoi.Location = new Point(870, 233);
            btn_CatChuoiCuoi.Margin = new Padding(3, 4, 3, 4);
            btn_CatChuoiCuoi.Name = "btn_CatChuoiCuoi";
            btn_CatChuoiCuoi.Size = new Size(143, 55);
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
            btn_Back.Location = new Point(1098, 163);
            btn_Back.Margin = new Padding(3, 4, 3, 4);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(113, 61);
            btn_Back.TabIndex = 66;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDeleteAll.ForeColor = SystemColors.ActiveCaptionText;
            btnDeleteAll.Location = new Point(475, 611);
            btnDeleteAll.Margin = new Padding(5);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(143, 48);
            btnDeleteAll.TabIndex = 67;
            btnDeleteAll.Text = "Xóa hết";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // Karatsuba
            // 
            AcceptButton = btn_KetQua;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Silver;
            CancelButton = btnExit;
            ClientSize = new Size(1243, 667);
            Controls.Add(btnDeleteAll);
            Controls.Add(btn_Back);
            Controls.Add(btn_CatChuoiCuoi);
            Controls.Add(btn_CatChuoiGiua);
            Controls.Add(btn_CatChuoiDau);
            Controls.Add(button6);
            Controls.Add(btn_LoadTreeView);
            Controls.Add(txt_ChuoiCuoi);
            Controls.Add(txt_ChuoiDau);
            Controls.Add(txt_ChuoiGiua);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(txt_KetQua);
            Controls.Add(txt_NhapB);
            Controls.Add(label1);
            Controls.Add(txt_NhapA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label16);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Karatsuba";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Karatsuba algorithm";
            FormClosing += Close_Window;
            Load += Karatsuba_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
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
    }
}
