namespace GUI
{
    partial class frm_LapHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NgayLap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NVLap = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_MaNVLap = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_TaoHDMoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.cb_MaSach = new System.Windows.Forms.ComboBox();
            this.dgv_CTHD = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.btn_ThemCTHD = new System.Windows.Forms.Button();
            this.btn_XoaCTHD = new System.Windows.Forms.Button();
            this.btn_InHD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTHD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(146, 34);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.ReadOnly = true;
            this.txt_MaHD.Size = new System.Drawing.Size(237, 28);
            this.txt_MaHD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày lập: ";
            // 
            // txt_NgayLap
            // 
            this.txt_NgayLap.Location = new System.Drawing.Point(514, 37);
            this.txt_NgayLap.Name = "txt_NgayLap";
            this.txt_NgayLap.ReadOnly = true;
            this.txt_NgayLap.Size = new System.Drawing.Size(210, 28);
            this.txt_NgayLap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhân viên lập: ";
            // 
            // txt_NVLap
            // 
            this.txt_NVLap.Location = new System.Drawing.Point(480, 97);
            this.txt_NVLap.Name = "txt_NVLap";
            this.txt_NVLap.ReadOnly = true;
            this.txt_NVLap.Size = new System.Drawing.Size(244, 28);
            this.txt_NVLap.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_MaNVLap);
            this.groupBox1.Controls.Add(this.txt_NVLap);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_TaoHDMoi);
            this.groupBox1.Controls.Add(this.txt_NgayLap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_MaHD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 158);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txt_MaNVLap
            // 
            this.txt_MaNVLap.Location = new System.Drawing.Point(124, 97);
            this.txt_MaNVLap.Name = "txt_MaNVLap";
            this.txt_MaNVLap.ReadOnly = true;
            this.txt_MaNVLap.Size = new System.Drawing.Size(181, 28);
            this.txt_MaNVLap.TabIndex = 5;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Luu.Enabled = false;
            this.btn_Luu.FlatAppearance.BorderSize = 0;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(761, 89);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(220, 45);
            this.btn_Luu.TabIndex = 23;
            this.btn_Luu.Text = "Lưu hóa đơn";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "Mã NV lập: ";
            // 
            // btn_TaoHDMoi
            // 
            this.btn_TaoHDMoi.BackColor = System.Drawing.Color.Firebrick;
            this.btn_TaoHDMoi.FlatAppearance.BorderSize = 0;
            this.btn_TaoHDMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoHDMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoHDMoi.ForeColor = System.Drawing.Color.White;
            this.btn_TaoHDMoi.Location = new System.Drawing.Point(761, 26);
            this.btn_TaoHDMoi.Name = "btn_TaoHDMoi";
            this.btn_TaoHDMoi.Size = new System.Drawing.Size(220, 45);
            this.btn_TaoHDMoi.TabIndex = 21;
            this.btn_TaoHDMoi.Text = "Tạo hóa đơn mới";
            this.btn_TaoHDMoi.UseVisualStyleBackColor = false;
            this.btn_TaoHDMoi.Click += new System.EventHandler(this.btn_TaoHDMoi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã sách: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên sách: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Đơn giá: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(259, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số lượng: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(452, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Thành tiền:";
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSach.Location = new System.Drawing.Point(360, 29);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.ReadOnly = true;
            this.txt_TenSach.Size = new System.Drawing.Size(364, 28);
            this.txt_TenSach.TabIndex = 12;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Location = new System.Drawing.Point(110, 92);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.ReadOnly = true;
            this.txt_DonGia.Size = new System.Drawing.Size(130, 28);
            this.txt_DonGia.TabIndex = 13;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Enabled = false;
            this.txt_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(360, 92);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(66, 28);
            this.txt_SoLuong.TabIndex = 14;
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhTien.Location = new System.Drawing.Point(559, 92);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(165, 28);
            this.txt_ThanhTien.TabIndex = 15;
            // 
            // cb_MaSach
            // 
            this.cb_MaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaSach.FormattingEnabled = true;
            this.cb_MaSach.Location = new System.Drawing.Point(110, 28);
            this.cb_MaSach.Name = "cb_MaSach";
            this.cb_MaSach.Size = new System.Drawing.Size(130, 30);
            this.cb_MaSach.TabIndex = 16;
            this.cb_MaSach.TextChanged += new System.EventHandler(this.cb_MaSach_TextChanged);
            // 
            // dgv_CTHD
            // 
            this.dgv_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTHD.Location = new System.Drawing.Point(17, 157);
            this.dgv_CTHD.Name = "dgv_CTHD";
            this.dgv_CTHD.RowHeadersWidth = 51;
            this.dgv_CTHD.RowTemplate.Height = 24;
            this.dgv_CTHD.Size = new System.Drawing.Size(964, 258);
            this.dgv_CTHD.TabIndex = 17;
            this.dgv_CTHD.SelectionChanged += new System.EventHandler(this.dgv_CTHD_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(692, 653);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tổng tiền: ";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(794, 650);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(220, 28);
            this.txt_TongTien.TabIndex = 19;
            // 
            // btn_ThemCTHD
            // 
            this.btn_ThemCTHD.BackColor = System.Drawing.Color.Firebrick;
            this.btn_ThemCTHD.Enabled = false;
            this.btn_ThemCTHD.FlatAppearance.BorderSize = 0;
            this.btn_ThemCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemCTHD.ForeColor = System.Drawing.Color.White;
            this.btn_ThemCTHD.Location = new System.Drawing.Point(761, 21);
            this.btn_ThemCTHD.Name = "btn_ThemCTHD";
            this.btn_ThemCTHD.Size = new System.Drawing.Size(220, 45);
            this.btn_ThemCTHD.TabIndex = 20;
            this.btn_ThemCTHD.Text = "Thêm vào hóa đơn";
            this.btn_ThemCTHD.UseVisualStyleBackColor = false;
            this.btn_ThemCTHD.Click += new System.EventHandler(this.btn_ThemCTHD_Click);
            // 
            // btn_XoaCTHD
            // 
            this.btn_XoaCTHD.BackColor = System.Drawing.Color.Firebrick;
            this.btn_XoaCTHD.Enabled = false;
            this.btn_XoaCTHD.FlatAppearance.BorderSize = 0;
            this.btn_XoaCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaCTHD.ForeColor = System.Drawing.Color.White;
            this.btn_XoaCTHD.Location = new System.Drawing.Point(761, 84);
            this.btn_XoaCTHD.Name = "btn_XoaCTHD";
            this.btn_XoaCTHD.Size = new System.Drawing.Size(220, 45);
            this.btn_XoaCTHD.TabIndex = 22;
            this.btn_XoaCTHD.Text = "Xóa khỏi hóa đơn";
            this.btn_XoaCTHD.UseVisualStyleBackColor = false;
            this.btn_XoaCTHD.Click += new System.EventHandler(this.btn_XoaCTHD_Click);
            // 
            // btn_InHD
            // 
            this.btn_InHD.BackColor = System.Drawing.Color.Firebrick;
            this.btn_InHD.Enabled = false;
            this.btn_InHD.FlatAppearance.BorderSize = 0;
            this.btn_InHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHD.ForeColor = System.Drawing.Color.White;
            this.btn_InHD.Location = new System.Drawing.Point(289, 642);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(220, 45);
            this.btn_InHD.TabIndex = 23;
            this.btn_InHD.Text = "In hóa đơn";
            this.btn_InHD.UseVisualStyleBackColor = false;
            this.btn_InHD.Click += new System.EventHandler(this.btn_InHD_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_XoaCTHD);
            this.groupBox2.Controls.Add(this.btn_ThemCTHD);
            this.groupBox2.Controls.Add(this.dgv_CTHD);
            this.groupBox2.Controls.Add(this.cb_MaSach);
            this.groupBox2.Controls.Add(this.txt_ThanhTien);
            this.groupBox2.Controls.Add(this.txt_SoLuong);
            this.groupBox2.Controls.Add(this.txt_DonGia);
            this.groupBox2.Controls.Add(this.txt_TenSach);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(35, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 429);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.White;
            this.btn_Huy.Enabled = false;
            this.btn_Huy.FlatAppearance.BorderSize = 0;
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.Black;
            this.btn_Huy.Location = new System.Drawing.Point(35, 642);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(220, 45);
            this.btn_Huy.TabIndex = 23;
            this.btn_Huy.Text = "Hủy hóa đơn";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // frm_LapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 728);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_InHD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_LapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lập hóa đơn";
            this.Load += new System.EventHandler(this.frm_LapHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTHD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NVLap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.ComboBox cb_MaSach;
        private System.Windows.Forms.DataGridView dgv_CTHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_ThemCTHD;
        private System.Windows.Forms.Button btn_TaoHDMoi;
        private System.Windows.Forms.Button btn_XoaCTHD;
        private System.Windows.Forms.Button btn_InHD;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Huy;
        public System.Windows.Forms.TextBox txt_MaHD;
        public System.Windows.Forms.TextBox txt_NgayLap;
        public System.Windows.Forms.TextBox txt_TongTien;
        public System.Windows.Forms.TextBox txt_MaNVLap;
    }
}