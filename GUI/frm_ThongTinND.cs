using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ThongTinND : Form
    {
        frm_Main frm_Main;
        public frm_ThongTinND()
        {
            InitializeComponent();
        }
        private void frm_ThongTinND_Load(object sender, EventArgs e)
        {
            showInfo();
        }
        public void showInfo()
        {
            DTO_NhanVien nv = BUS_NhanVien.getTaiKhoan(frm_DangNhap.nv.STenTK);
            txt_MaNV.Text = nv.SMaNV.ToString();
            txt_TenTK.Text = nv.STenTK.ToString();
            txt_HoLot.Text = nv.SHoLot.ToString();
            txt_Ten.Text = nv.STen.ToString();
            txt_Email.Text = nv.SEmail.ToString();
            txt_QueQuan.Text = nv.SQueQuan.ToString();
            dtp_NgaySinh.Text = nv.DNgaySinh.ToString();
            if (nv.SPhai.ToString() == "Nam")
            {
                rd_Nam.Checked = true;
            }
            else
            {
                rd_Nu.Checked = true;
            }
            switch (nv.SMaCV)
            {
                case "QL":
                    txt_ChucVu.Text = "Quản lý"; break;
                case "BH":
                    txt_ChucVu.Text = "Nhân viên bán hàng"; break;
                case "KH":
                    txt_ChucVu.Text = "Nhân viên kho"; break;
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            showInfo();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string manv = txt_MaNV.Text.ToString();
            string tentk = txt_TenTK.Text.ToString();
            string holot = txt_HoLot.Text.ToString();
            string ten = txt_Ten.Text.ToString();
            string email = txt_Email.Text.ToString();
            string quequan = txt_QueQuan.Text.ToString();
            DateTime ngaysinh = DateTime.Parse(dtp_NgaySinh.Value.ToString());
            if(string.IsNullOrEmpty(manv) || string.IsNullOrEmpty(tentk) || string.IsNullOrEmpty(holot) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(quequan)) 
            {
                MessageBox.Show("Không được để trống thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else if(double.TryParse(ten, out _) || double.TryParse(holot, out _))
            {
                MessageBox.Show("Họ lót và tên không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!Check.checkNgaySinh(dtp_NgaySinh.Text))
            {
                MessageBox.Show("Ngày sinh không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Check.checkEmail(email))
            {
                MessageBox.Show("Email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.SMaNV = manv;
                nv.STenTK = tentk;
                nv.SHoLot = holot;
                nv.STen = ten;
                nv.SEmail = email;
                nv.SQueQuan = quequan;
                nv.DNgaySinh = ngaysinh;
                if (rd_Nam.Checked)
                {
                    nv.SPhai = rd_Nam.Text.ToString();
                }
                else
                {
                    nv.SPhai = rd_Nu.Text.ToString();
                }
                if (BUS_NhanVien.updateTaiKhoan(nv))
                {
                    showInfo();
                    frm_Main = new frm_Main();
                    frm_Main.lbl_TenND.Text = nv.SHoLot + " " + nv.STen;
                    MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
