namespace GUI
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Quyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_TgDangNhap = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_ThayDoiMK = new System.Windows.Forms.Button();
            this.btn_TTNguoiDung = new System.Windows.Forms.Button();
            this.btn_ThongKePhieuNhap = new System.Windows.Forms.Button();
            this.btn_LapPhieuNhap = new System.Windows.Forms.Button();
            this.btn_ThongKeHoaDon = new System.Windows.Forms.Button();
            this.btn_LapHoaDon = new System.Windows.Forms.Button();
            this.btn_QLNhanVien = new System.Windows.Forms.Button();
            this.btn_QLNhaCC = new System.Windows.Forms.Button();
            this.btn_QLNXB = new System.Windows.Forms.Button();
            this.btn_QLLoaiSach = new System.Windows.Forms.Button();
            this.btn_QLSach = new System.Windows.Forms.Button();
            this.panel_UserName = new System.Windows.Forms.Panel();
            this.lbl_TenND = new System.Windows.Forms.Label();
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.panel_UserName.SuspendLayout();
            this.panel_TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Quyen,
            this.toolStripStatusLabel_TgDangNhap});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1027);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1332, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Quyen
            // 
            this.toolStripStatusLabel_Quyen.Enabled = false;
            this.toolStripStatusLabel_Quyen.Margin = new System.Windows.Forms.Padding(0, 4, 10, 2);
            this.toolStripStatusLabel_Quyen.Name = "toolStripStatusLabel_Quyen";
            this.toolStripStatusLabel_Quyen.Size = new System.Drawing.Size(233, 20);
            this.toolStripStatusLabel_Quyen.Text = "Bạn đang đăng nhập dưới quyền: ";
            // 
            // toolStripStatusLabel_TgDangNhap
            // 
            this.toolStripStatusLabel_TgDangNhap.Enabled = false;
            this.toolStripStatusLabel_TgDangNhap.Margin = new System.Windows.Forms.Padding(0, 4, 10, 2);
            this.toolStripStatusLabel_TgDangNhap.Name = "toolStripStatusLabel_TgDangNhap";
            this.toolStripStatusLabel_TgDangNhap.Size = new System.Drawing.Size(149, 20);
            this.toolStripStatusLabel_TgDangNhap.Text = "Thời gian đăng nhập:";
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.Firebrick;
            this.panel_Menu.Controls.Add(this.btn_Thoat);
            this.panel_Menu.Controls.Add(this.btn_DangXuat);
            this.panel_Menu.Controls.Add(this.btn_ThayDoiMK);
            this.panel_Menu.Controls.Add(this.btn_TTNguoiDung);
            this.panel_Menu.Controls.Add(this.btn_ThongKePhieuNhap);
            this.panel_Menu.Controls.Add(this.btn_LapPhieuNhap);
            this.panel_Menu.Controls.Add(this.btn_ThongKeHoaDon);
            this.panel_Menu.Controls.Add(this.btn_LapHoaDon);
            this.panel_Menu.Controls.Add(this.btn_QLNhanVien);
            this.panel_Menu.Controls.Add(this.btn_QLNhaCC);
            this.panel_Menu.Controls.Add(this.btn_QLNXB);
            this.panel_Menu.Controls.Add(this.btn_QLLoaiSach);
            this.panel_Menu.Controls.Add(this.btn_QLSach);
            this.panel_Menu.Controls.Add(this.panel_UserName);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(250, 1027);
            this.panel_Menu.TabIndex = 1;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Location = new System.Drawing.Point(0, 820);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(250, 60);
            this.btn_Thoat.TabIndex = 14;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DangXuat.FlatAppearance.BorderSize = 0;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.White;
            this.btn_DangXuat.Location = new System.Drawing.Point(0, 760);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(250, 60);
            this.btn_DangXuat.TabIndex = 13;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_ThayDoiMK
            // 
            this.btn_ThayDoiMK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ThayDoiMK.FlatAppearance.BorderSize = 0;
            this.btn_ThayDoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThayDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThayDoiMK.ForeColor = System.Drawing.Color.White;
            this.btn_ThayDoiMK.Location = new System.Drawing.Point(0, 700);
            this.btn_ThayDoiMK.Name = "btn_ThayDoiMK";
            this.btn_ThayDoiMK.Size = new System.Drawing.Size(250, 60);
            this.btn_ThayDoiMK.TabIndex = 12;
            this.btn_ThayDoiMK.Text = "Thay đổi mật khẩu";
            this.btn_ThayDoiMK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThayDoiMK.UseVisualStyleBackColor = true;
            this.btn_ThayDoiMK.Click += new System.EventHandler(this.btn_ThayDoiMK_Click);
            // 
            // btn_TTNguoiDung
            // 
            this.btn_TTNguoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TTNguoiDung.FlatAppearance.BorderSize = 0;
            this.btn_TTNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TTNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TTNguoiDung.ForeColor = System.Drawing.Color.White;
            this.btn_TTNguoiDung.Location = new System.Drawing.Point(0, 640);
            this.btn_TTNguoiDung.Name = "btn_TTNguoiDung";
            this.btn_TTNguoiDung.Size = new System.Drawing.Size(250, 60);
            this.btn_TTNguoiDung.TabIndex = 11;
            this.btn_TTNguoiDung.Text = "Thông tin người dùng";
            this.btn_TTNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TTNguoiDung.UseVisualStyleBackColor = true;
            this.btn_TTNguoiDung.Click += new System.EventHandler(this.btn_TTNguoiDung_Click);
            // 
            // btn_ThongKePhieuNhap
            // 
            this.btn_ThongKePhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ThongKePhieuNhap.FlatAppearance.BorderSize = 0;
            this.btn_ThongKePhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKePhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKePhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btn_ThongKePhieuNhap.Location = new System.Drawing.Point(0, 580);
            this.btn_ThongKePhieuNhap.Name = "btn_ThongKePhieuNhap";
            this.btn_ThongKePhieuNhap.Size = new System.Drawing.Size(250, 60);
            this.btn_ThongKePhieuNhap.TabIndex = 10;
            this.btn_ThongKePhieuNhap.Text = "Thống kê phiếu nhập";
            this.btn_ThongKePhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKePhieuNhap.UseVisualStyleBackColor = true;
            this.btn_ThongKePhieuNhap.Click += new System.EventHandler(this.btn_BaoCaoNhapSach_Click);
            // 
            // btn_LapPhieuNhap
            // 
            this.btn_LapPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LapPhieuNhap.FlatAppearance.BorderSize = 0;
            this.btn_LapPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LapPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LapPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btn_LapPhieuNhap.Location = new System.Drawing.Point(0, 520);
            this.btn_LapPhieuNhap.Name = "btn_LapPhieuNhap";
            this.btn_LapPhieuNhap.Size = new System.Drawing.Size(250, 60);
            this.btn_LapPhieuNhap.TabIndex = 9;
            this.btn_LapPhieuNhap.Text = "Lập phiếu nhập";
            this.btn_LapPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LapPhieuNhap.UseVisualStyleBackColor = true;
            this.btn_LapPhieuNhap.Click += new System.EventHandler(this.btn_LapPhieuNhap_Click);
            // 
            // btn_ThongKeHoaDon
            // 
            this.btn_ThongKeHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ThongKeHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_ThongKeHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKeHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKeHoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_ThongKeHoaDon.Location = new System.Drawing.Point(0, 460);
            this.btn_ThongKeHoaDon.Name = "btn_ThongKeHoaDon";
            this.btn_ThongKeHoaDon.Size = new System.Drawing.Size(250, 60);
            this.btn_ThongKeHoaDon.TabIndex = 8;
            this.btn_ThongKeHoaDon.Text = "Thống kê hóa đơn";
            this.btn_ThongKeHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKeHoaDon.UseVisualStyleBackColor = true;
            this.btn_ThongKeHoaDon.Click += new System.EventHandler(this.btn_BaoCaoDoanhThu_Click);
            // 
            // btn_LapHoaDon
            // 
            this.btn_LapHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LapHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_LapHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LapHoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_LapHoaDon.Location = new System.Drawing.Point(0, 400);
            this.btn_LapHoaDon.Name = "btn_LapHoaDon";
            this.btn_LapHoaDon.Size = new System.Drawing.Size(250, 60);
            this.btn_LapHoaDon.TabIndex = 7;
            this.btn_LapHoaDon.Text = "Lập hóa đơn";
            this.btn_LapHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LapHoaDon.UseVisualStyleBackColor = true;
            this.btn_LapHoaDon.Click += new System.EventHandler(this.btn_LapHoaDon_Click);
            // 
            // btn_QLNhanVien
            // 
            this.btn_QLNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QLNhanVien.FlatAppearance.BorderSize = 0;
            this.btn_QLNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_QLNhanVien.Location = new System.Drawing.Point(0, 340);
            this.btn_QLNhanVien.Name = "btn_QLNhanVien";
            this.btn_QLNhanVien.Size = new System.Drawing.Size(250, 60);
            this.btn_QLNhanVien.TabIndex = 5;
            this.btn_QLNhanVien.Text = "Quản lý nhân viên";
            this.btn_QLNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLNhanVien.UseVisualStyleBackColor = true;
            this.btn_QLNhanVien.Click += new System.EventHandler(this.btn_QLNhanVien_Click);
            // 
            // btn_QLNhaCC
            // 
            this.btn_QLNhaCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QLNhaCC.FlatAppearance.BorderSize = 0;
            this.btn_QLNhaCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNhaCC.ForeColor = System.Drawing.Color.White;
            this.btn_QLNhaCC.Location = new System.Drawing.Point(0, 280);
            this.btn_QLNhaCC.Name = "btn_QLNhaCC";
            this.btn_QLNhaCC.Size = new System.Drawing.Size(250, 60);
            this.btn_QLNhaCC.TabIndex = 4;
            this.btn_QLNhaCC.Text = "Quản lý nhà cung cấp";
            this.btn_QLNhaCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLNhaCC.UseVisualStyleBackColor = true;
            this.btn_QLNhaCC.Click += new System.EventHandler(this.btn_QLNhaCC_Click);
            // 
            // btn_QLNXB
            // 
            this.btn_QLNXB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QLNXB.FlatAppearance.BorderSize = 0;
            this.btn_QLNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNXB.ForeColor = System.Drawing.Color.White;
            this.btn_QLNXB.Location = new System.Drawing.Point(0, 220);
            this.btn_QLNXB.Name = "btn_QLNXB";
            this.btn_QLNXB.Size = new System.Drawing.Size(250, 60);
            this.btn_QLNXB.TabIndex = 3;
            this.btn_QLNXB.Text = "Quản lý NXB";
            this.btn_QLNXB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLNXB.UseVisualStyleBackColor = true;
            this.btn_QLNXB.Click += new System.EventHandler(this.btn_QLNXB_Click);
            // 
            // btn_QLLoaiSach
            // 
            this.btn_QLLoaiSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QLLoaiSach.FlatAppearance.BorderSize = 0;
            this.btn_QLLoaiSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLLoaiSach.ForeColor = System.Drawing.Color.White;
            this.btn_QLLoaiSach.Location = new System.Drawing.Point(0, 160);
            this.btn_QLLoaiSach.Name = "btn_QLLoaiSach";
            this.btn_QLLoaiSach.Size = new System.Drawing.Size(250, 60);
            this.btn_QLLoaiSach.TabIndex = 2;
            this.btn_QLLoaiSach.Text = "Quản lý thể loại sách";
            this.btn_QLLoaiSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLLoaiSach.UseVisualStyleBackColor = true;
            this.btn_QLLoaiSach.Click += new System.EventHandler(this.btn_QLLoaiSach_Click);
            // 
            // btn_QLSach
            // 
            this.btn_QLSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QLSach.FlatAppearance.BorderSize = 0;
            this.btn_QLSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLSach.ForeColor = System.Drawing.Color.White;
            this.btn_QLSach.Location = new System.Drawing.Point(0, 100);
            this.btn_QLSach.Name = "btn_QLSach";
            this.btn_QLSach.Size = new System.Drawing.Size(250, 60);
            this.btn_QLSach.TabIndex = 1;
            this.btn_QLSach.Text = "Quản lý sách";
            this.btn_QLSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLSach.UseVisualStyleBackColor = true;
            this.btn_QLSach.Click += new System.EventHandler(this.btn_QLSach_Click);
            // 
            // panel_UserName
            // 
            this.panel_UserName.BackColor = System.Drawing.Color.Maroon;
            this.panel_UserName.Controls.Add(this.lbl_TenND);
            this.panel_UserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_UserName.Location = new System.Drawing.Point(0, 0);
            this.panel_UserName.Name = "panel_UserName";
            this.panel_UserName.Size = new System.Drawing.Size(250, 100);
            this.panel_UserName.TabIndex = 0;
            // 
            // lbl_TenND
            // 
            this.lbl_TenND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_TenND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenND.ForeColor = System.Drawing.Color.White;
            this.lbl_TenND.Location = new System.Drawing.Point(0, 0);
            this.lbl_TenND.Name = "lbl_TenND";
            this.lbl_TenND.Size = new System.Drawing.Size(250, 100);
            this.lbl_TenND.TabIndex = 0;
            this.lbl_TenND.Text = "Tên người dùng";
            this.lbl_TenND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_TitleBar
            // 
            this.panel_TitleBar.BackColor = System.Drawing.Color.Firebrick;
            this.panel_TitleBar.Controls.Add(this.btn_Close);
            this.panel_TitleBar.Controls.Add(this.lbl_Title);
            this.panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleBar.Location = new System.Drawing.Point(250, 0);
            this.panel_TitleBar.Name = "panel_TitleBar";
            this.panel_TitleBar.Size = new System.Drawing.Size(1082, 100);
            this.panel_TitleBar.TabIndex = 2;
            // 
            // btn_Close
            // 
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(0, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(100, 100);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(1082, 100);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Trang chủ";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Content
            // 
            this.panel_Content.BackColor = System.Drawing.Color.MistyRose;
            this.panel_Content.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Content.BackgroundImage")));
            this.panel_Content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(250, 100);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1082, 927);
            this.panel_Content.TabIndex = 3;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1332, 1053);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.panel_TitleBar);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel_Menu.ResumeLayout(false);
            this.panel_UserName.ResumeLayout(false);
            this.panel_TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Quyen;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_TgDangNhap;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_TitleBar;
        private System.Windows.Forms.Panel panel_UserName;
        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.Button btn_QLSach;
        private System.Windows.Forms.Button btn_ThongKeHoaDon;
        private System.Windows.Forms.Button btn_LapHoaDon;
        private System.Windows.Forms.Button btn_QLNhanVien;
        private System.Windows.Forms.Button btn_QLNhaCC;
        private System.Windows.Forms.Button btn_QLNXB;
        private System.Windows.Forms.Button btn_QLLoaiSach;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_ThayDoiMK;
        private System.Windows.Forms.Button btn_TTNguoiDung;
        private System.Windows.Forms.Button btn_ThongKePhieuNhap;
        private System.Windows.Forms.Button btn_LapPhieuNhap;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Close;
        public System.Windows.Forms.Label lbl_TenND;
    }
}