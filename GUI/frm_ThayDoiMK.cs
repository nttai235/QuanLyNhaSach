using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ThayDoiMK : Form
    {
        DTO_NhanVien nv;
        public frm_ThayDoiMK()
        {
            InitializeComponent();
        }

        private void ckb_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_HienThiMK.Checked)
            {
                txt_MKCu.PasswordChar = (char)0;
                txt_MKMoi.PasswordChar = (char)0;
                txt_XNMK.PasswordChar = (char)0;
            }
            else
            {
                txt_MKCu.PasswordChar = '•';
                txt_MKMoi.PasswordChar = '•';
                txt_XNMK.PasswordChar = '•';
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_MKCu.Text = "";
            txt_MKMoi.Text = "";
            txt_XNMK.Text = "";
        }

        private void btn_ThayDoi_Click(object sender, EventArgs e)
        {
            string mkcu = txt_MKCu.Text;
            string mkmoi = txt_MKMoi.Text;
            string mkxn = txt_XNMK.Text;
            if(string.IsNullOrEmpty(mkcu) || string.IsNullOrEmpty(mkmoi) || string.IsNullOrEmpty(mkxn))
            {
                MessageBox.Show("Không được để trống thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nv = new DTO_NhanVien();
                nv = BUS_NhanVien.logIn(frm_DangNhap.nv.STenTK, mkcu);
                if(nv == null )
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    nv.SMatKhau = mkmoi;
                    if(BUS_NhanVien.changePassword(nv, mkmoi))
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                        txt_MKCu.Text = "";
                        txt_MKMoi.Text = "";
                        txt_XNMK.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi mật khẩu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
