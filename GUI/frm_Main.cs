using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Main : Form
    {
        private Button currentButton;
        private Form activeForm;
        frm_DangNhap frm_DangNhap;

        public frm_Main()
        {
            InitializeComponent();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.DarkRed;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn_Close.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel_Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Firebrick;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.Anchor = AnchorStyles.None;
            childForm.BackColor = panel_Content.BackColor;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_Content.Controls.Add(childForm);
            this.panel_Content.Tag = childForm;
            childForm.BringToFront();
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Show();
            lbl_Title.Text = childForm.Text;
        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            show_Menu();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            DisableButton();
            lbl_Title.Text = "Trang chủ";
            currentButton = null;
            btn_Close.Visible = false;
        }

        private void btn_QLSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QLSach(), sender);
        }

        private void btn_QLLoaiSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QLLoaiSach(), sender);
        }

        private void btn_QLNXB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QLNXB(), sender);
        }

        private void btn_QLNhaCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QLNhaCC(), sender);
        }

        private void btn_QLNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QLNhanVien(), sender);
        }


        private void btn_LapHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_LapHoaDon(), sender);
        }

        private void btn_BaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_BaoCaoDoanhThu(), sender);
        }

        private void btn_LapPhieuNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_LapPhieuNhap(), sender);
        }

        private void btn_BaoCaoNhapSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_BaoCaoNhapSach(), sender);
        }

        private void btn_TTNguoiDung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ThongTinND(), sender);
        }

        private void btn_ThayDoiMK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ThayDoiMK(), sender);
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                this.Close();
                frm_DangNhap.Show();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                if (activeForm != null)
                    activeForm.Close();
                Application.Exit();
            }
        }
        private void show_Menu()
        {
            btn_Close.Visible = false;
            frm_DangNhap = new frm_DangNhap();
            string cv = frm_DangNhap.nv.SMaCV;
            lbl_TenND.Text = frm_DangNhap.nv.SHoLot + " " +frm_DangNhap.nv.STen;
            toolStripStatusLabel_TgDangNhap.Text = "Thời gian đăng nhập: " + DateTime.Now.ToString();
            switch(cv)
            {
                case "QL":
                    toolStripStatusLabel_Quyen.Text = "Bạn đang đăng nhập với quyền: Quản lý";
                    btn_LapHoaDon.Visible=false;
                    btn_BaoCaoDoanhThu.Visible=false;
                    btn_LapPhieuNhap.Visible=false;
                    btn_BaoCaoNhapSach.Visible=false;
                    break;
                case "BH":
                    toolStripStatusLabel_Quyen.Text = "Bạn đang đăng nhập với quyền: Nhân viên bán hàng";
                    btn_QLSach.Visible=false;
                    btn_QLLoaiSach.Visible=false;
                    btn_QLNXB.Visible=false;
                    btn_QLNhaCC.Visible=false;
                    btn_QLNhanVien.Visible=false;
                    btn_LapPhieuNhap.Visible = false;
                    btn_BaoCaoNhapSach.Visible = false;
                    break;
                case "KH":
                    toolStripStatusLabel_Quyen.Text = "Bạn đang đăng nhập với quyền: Nhân viên kho";
                    btn_QLSach.Visible = false;
                    btn_QLLoaiSach.Visible = false;
                    btn_QLNXB.Visible = false;
                    btn_QLNhaCC.Visible = false;
                    btn_QLNhanVien.Visible = false;
                    btn_LapHoaDon.Visible = false;
                    btn_BaoCaoDoanhThu.Visible = false;
                    break;
            }
        }
    }
}
