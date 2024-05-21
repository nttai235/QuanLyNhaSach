namespace GUI
{
    partial class frm_LapPhieuNhap
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
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_InPN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_XoaCTPN = new System.Windows.Forms.Button();
            this.btn_ThemCTPN = new System.Windows.Forms.Button();
            this.dgv_CTPN = new System.Windows.Forms.DataGridView();
            this.cb_MaSach = new System.Windows.Forms.ComboBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_NCC = new System.Windows.Forms.ComboBox();
            this.txt_MaNVLap = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_TaoPNMoi = new System.Windows.Forms.Button();
            this.txt_NgayLap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaPN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTPN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.White;
            this.btn_Huy.Enabled = false;
            this.btn_Huy.FlatAppearance.BorderSize = 0;
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.Black;
            this.btn_Huy.Location = new System.Drawing.Point(32, 633);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(220, 45);
            this.btn_Huy.TabIndex = 27;
            this.btn_Huy.Text = "Hủy phiếu nhập";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_InPN
            // 
            this.btn_InPN.BackColor = System.Drawing.Color.Firebrick;
            this.btn_InPN.Enabled = false;
            this.btn_InPN.FlatAppearance.BorderSize = 0;
            this.btn_InPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InPN.ForeColor = System.Drawing.Color.White;
            this.btn_InPN.Location = new System.Drawing.Point(286, 633);
            this.btn_InPN.Name = "btn_InPN";
            this.btn_InPN.Size = new System.Drawing.Size(220, 45);
            this.btn_InPN.TabIndex = 28;
            this.btn_InPN.Text = "In phiếu nhập";
            this.btn_InPN.UseVisualStyleBackColor = false;
            this.btn_InPN.Click += new System.EventHandler(this.btn_InPN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_XoaCTPN);
            this.groupBox2.Controls.Add(this.btn_ThemCTPN);
            this.groupBox2.Controls.Add(this.dgv_CTPN);
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
            this.groupBox2.Location = new System.Drawing.Point(32, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 429);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // btn_XoaCTPN
            // 
            this.btn_XoaCTPN.BackColor = System.Drawing.Color.Firebrick;
            this.btn_XoaCTPN.Enabled = false;
            this.btn_XoaCTPN.FlatAppearance.BorderSize = 0;
            this.btn_XoaCTPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaCTPN.ForeColor = System.Drawing.Color.White;
            this.btn_XoaCTPN.Location = new System.Drawing.Point(761, 84);
            this.btn_XoaCTPN.Name = "btn_XoaCTPN";
            this.btn_XoaCTPN.Size = new System.Drawing.Size(220, 45);
            this.btn_XoaCTPN.TabIndex = 22;
            this.btn_XoaCTPN.Text = "Xóa khỏi phiếu nhập";
            this.btn_XoaCTPN.UseVisualStyleBackColor = false;
            this.btn_XoaCTPN.Click += new System.EventHandler(this.btn_XoaCTPN_Click);
            // 
            // btn_ThemCTPN
            // 
            this.btn_ThemCTPN.BackColor = System.Drawing.Color.Firebrick;
            this.btn_ThemCTPN.Enabled = false;
            this.btn_ThemCTPN.FlatAppearance.BorderSize = 0;
            this.btn_ThemCTPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemCTPN.ForeColor = System.Drawing.Color.White;
            this.btn_ThemCTPN.Location = new System.Drawing.Point(761, 21);
            this.btn_ThemCTPN.Name = "btn_ThemCTPN";
            this.btn_ThemCTPN.Size = new System.Drawing.Size(220, 45);
            this.btn_ThemCTPN.TabIndex = 20;
            this.btn_ThemCTPN.Text = "Thêm vào phiếu nhập";
            this.btn_ThemCTPN.UseVisualStyleBackColor = false;
            this.btn_ThemCTPN.Click += new System.EventHandler(this.btn_ThemCTPN_Click);
            // 
            // dgv_CTPN
            // 
            this.dgv_CTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTPN.Location = new System.Drawing.Point(17, 157);
            this.dgv_CTPN.Name = "dgv_CTPN";
            this.dgv_CTPN.RowHeadersWidth = 51;
            this.dgv_CTPN.RowTemplate.Height = 24;
            this.dgv_CTPN.Size = new System.Drawing.Size(964, 258);
            this.dgv_CTPN.TabIndex = 17;
            this.dgv_CTPN.SelectionChanged += new System.EventHandler(this.dgv_CTPN_SelectionChanged);
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
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhTien.Location = new System.Drawing.Point(559, 92);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(165, 28);
            this.txt_ThanhTien.TabIndex = 15;
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
            // txt_DonGia
            // 
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Location = new System.Drawing.Point(110, 92);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.ReadOnly = true;
            this.txt_DonGia.Size = new System.Drawing.Size(130, 28);
            this.txt_DonGia.TabIndex = 13;
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
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(791, 641);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(220, 28);
            this.txt_TongTien.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(689, 644);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 22);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tổng tiền: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_NCC);
            this.groupBox1.Controls.Add(this.txt_MaNVLap);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btn_TaoPNMoi);
            this.groupBox1.Controls.Add(this.txt_NgayLap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_MaPN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 158);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // cb_NCC
            // 
            this.cb_NCC.FormattingEnabled = true;
            this.cb_NCC.Location = new System.Drawing.Point(514, 97);
            this.cb_NCC.Name = "cb_NCC";
            this.cb_NCC.Size = new System.Drawing.Size(210, 30);
            this.cb_NCC.TabIndex = 24;
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
            this.btn_Luu.Text = "Lưu phiếu nhập";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhà cung cấp: ";
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
            // btn_TaoPNMoi
            // 
            this.btn_TaoPNMoi.BackColor = System.Drawing.Color.Firebrick;
            this.btn_TaoPNMoi.FlatAppearance.BorderSize = 0;
            this.btn_TaoPNMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoPNMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoPNMoi.ForeColor = System.Drawing.Color.White;
            this.btn_TaoPNMoi.Location = new System.Drawing.Point(761, 26);
            this.btn_TaoPNMoi.Name = "btn_TaoPNMoi";
            this.btn_TaoPNMoi.Size = new System.Drawing.Size(220, 45);
            this.btn_TaoPNMoi.TabIndex = 21;
            this.btn_TaoPNMoi.Text = "Tạo phiếu nhập mới";
            this.btn_TaoPNMoi.UseVisualStyleBackColor = false;
            this.btn_TaoPNMoi.Click += new System.EventHandler(this.btn_TaoPNMoi_Click);
            // 
            // txt_NgayLap
            // 
            this.txt_NgayLap.Location = new System.Drawing.Point(514, 37);
            this.txt_NgayLap.Name = "txt_NgayLap";
            this.txt_NgayLap.ReadOnly = true;
            this.txt_NgayLap.Size = new System.Drawing.Size(210, 28);
            this.txt_NgayLap.TabIndex = 3;
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
            // txt_MaPN
            // 
            this.txt_MaPN.Location = new System.Drawing.Point(156, 34);
            this.txt_MaPN.Name = "txt_MaPN";
            this.txt_MaPN.ReadOnly = true;
            this.txt_MaPN.Size = new System.Drawing.Size(227, 28);
            this.txt_MaPN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập:";
            // 
            // frm_LapPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1064, 728);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_InPN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_LapPhieuNhap";
            this.Text = "Lập phiếu nhập";
            this.Load += new System.EventHandler(this.frm_LapPhieuNhap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTPN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_InPN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_XoaCTPN;
        private System.Windows.Forms.Button btn_ThemCTPN;
        private System.Windows.Forms.DataGridView dgv_CTPN;
        private System.Windows.Forms.ComboBox cb_MaSach;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_MaNVLap;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_TaoPNMoi;
        private System.Windows.Forms.TextBox txt_NgayLap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_NCC;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_MaPN;
    }
}