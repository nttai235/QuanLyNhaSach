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
    public partial class frm_DangNhap : Form
    {
        frm_Main frmMain;
        public static DTO_NhanVien nv;
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string tentk = txt_TenTK.Text.ToString();
            string mk = txt_MatKhau.Text.ToString();
            nv = new DTO_NhanVien();
            nv = BUS_NhanVien.logIn(tentk, mk);
            if (string.IsNullOrEmpty(tentk) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (nv != null)
                {
                    this.Hide();
                    frmMain = new frm_Main();
                    frmMain.Show();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác.", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ckb_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_HienThiMK.Checked)
            {
                txt_MatKhau.PasswordChar = (char)0;
            }
            else
            {
                txt_MatKhau.PasswordChar = '•';
            }
        }

        private void txt_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_DangNhap_Click(sender, e);
            }
        }
    }
}
