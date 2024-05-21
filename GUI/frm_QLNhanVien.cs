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
    public partial class frm_QLNhanVien : Form
    {
        public frm_QLNhanVien()
        {
            InitializeComponent();
            txt_TimKiem.ForeColor = SystemColors.GrayText;
            txt_TimKiem.Text = "Nhập tên nhân viên cần tìm...";
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            this.txt_TimKiem.Enter += new System.EventHandler(this.txt_TimKiem_Enter);
        }

        private void frm_QLNhanVien_Load(object sender, EventArgs e)
        {
            showCVonCB();
            showDataOnDGV();
            cb_ChucVu.SelectedIndex = -1;
        }
        private void showCVonCB()
        {
            List<DTO_ChucVu> listCV = BUS_ChucVu.getChucVu();
            cb_ChucVu.DataSource = listCV;
            cb_ChucVu.DisplayMember = "STenCV";
            cb_ChucVu.ValueMember = "SMaCV";
        }
        private void showDataOnDGV()
        {
            DTO_NhanVien nv = BUS_NhanVien.checkID(frm_DangNhap.nv.SMaNV);
            string manv = nv.SMaNV;
            List<DTO_NhanVien> listNV = BUS_NhanVien.getAllNhanVien(manv);
            dgv_NV.DataSource = listNV;
            dgv_NV.Columns["SMaNV"].HeaderText = "Mã NV";
            dgv_NV.Columns["SMaNV"].Width = 50;
            dgv_NV.Columns["STenTK"].HeaderText = "Tên tài khoản";
            dgv_NV.Columns["STenTK"].Width = 50;
            dgv_NV.Columns["SHoLot"].HeaderText = "Họ lót";
            dgv_NV.Columns["SHoLot"].Width = 120;
            dgv_NV.Columns["STen"].HeaderText = "Tên";
            dgv_NV.Columns["STen"].Width = 50;
            dgv_NV.Columns["SEmail"].HeaderText = "Email";
            dgv_NV.Columns["SEmail"].Width = 120;
            dgv_NV.Columns["DNgaySinh"].HeaderText = "Ngày sinh";
            dgv_NV.Columns["DNgaySinh"].Width = 80;
            dgv_NV.Columns["SPhai"].HeaderText = "Phái";
            dgv_NV.Columns["SPhai"].Width = 50;
            dgv_NV.Columns["SQueQuan"].HeaderText = "Quê quán";
            dgv_NV.Columns["SqueQuan"].Width = 150;
            dgv_NV.Columns["STenCV"].HeaderText = "Chức vụ";
            dgv_NV.Columns["STenCV"].Width = 120;
            dgv_NV.Columns["SMaCV"].Visible = false;
            dgv_NV.Columns["SMatKhau"].Visible = false;
            dgv_NV.AllowUserToAddRows = false;
            dgv_NV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text.Length == 0)
            {
                txt_TimKiem.Text = "Nhập tên nhân viên cần tìm...";
                txt_TimKiem.ForeColor = SystemColors.GrayText;
            }
        }

        private void txt_TimKiem_Enter(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "Nhập tên nhân viên cần tìm...")
            {
                txt_TimKiem.Text = "";
                txt_TimKiem.ForeColor = SystemColors.WindowText;
            }
        }

        private void dgv_NV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_NV.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgv_NV.SelectedRows[0];
                txt_MaNV.Text = r.Cells["SMaNV"].Value.ToString();
                txt_TenTK.Text = r.Cells["STenTK"].Value.ToString();
                txt_HoLot.Text = r.Cells["SHoLot"].Value.ToString();
                txt_Ten.Text = r.Cells["STen"].Value.ToString();
                txt_Email.Text = r.Cells["SEmail"].Value.ToString();
                txt_QueQuan.Text = r.Cells["SQueQuan"].Value.ToString();
                dtp_NgaySinh.Text = r.Cells["DNgaySinh"].Value.ToString();
                cb_ChucVu.SelectedValue = r.Cells["SMaCV"].Value.ToString();
                if (r.Cells["SPhai"].Value.ToString() == "Nam")
                {
                    rd_Nam.Checked = true;
                }
                else
                {
                    rd_Nu.Checked = true;
                }

                btn_Them.Enabled = false;
                txt_MaNV.Enabled = false;
                txt_TenTK.Enabled=false;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_MaNV.Text) || string.IsNullOrEmpty(txt_TenTK.Text) || string.IsNullOrEmpty(txt_HoLot.Text) || string.IsNullOrEmpty(txt_Ten.Text) || string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrEmpty(txt_QueQuan.Text) || cb_ChucVu.SelectedIndex==-1)
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txt_MaNV.Text.Length > 10)
            {
                MessageBox.Show("Mã nhân viên không được dài quá 10 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (double.TryParse(txt_Ten.Text, out _) || double.TryParse(txt_HoLot.Text, out _))
            {
                MessageBox.Show("Họ lót và tên không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Check.checkNgaySinh(dtp_NgaySinh.Text))
            {
                MessageBox.Show("Ngày sinh không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Check.checkEmail(txt_Email.Text)) 
            {
                MessageBox.Show("Email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (BUS_NhanVien.checkID(txt_MaNV.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (BUS_NhanVien.getTaiKhoan(txt_TenTK.Text) != null)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.SMaNV = txt_MaNV.Text.ToString();
                nv.STenTK = txt_TenTK.Text.ToString();
                nv.SHoLot = txt_HoLot.Text.ToString();
                nv.STen = txt_Ten.Text.ToString();
                nv.SEmail = txt_Email.Text.ToString();
                nv.SQueQuan = txt_QueQuan.Text.ToString();
                nv.DNgaySinh = DateTime.Parse(dtp_NgaySinh.Text.ToString());
                if (rd_Nam.Checked)
                {
                    nv.SPhai = rd_Nam.Text.ToString();
                }
                else
                {
                    nv.SPhai = rd_Nu.Text.ToString();
                }
                nv.SMaCV = cb_ChucVu.SelectedValue.ToString();

                if (BUS_NhanVien.addNV(nv))
                {
                    showDataOnDGV();
                    MessageBox.Show("Đã thêm nhân viên "+txt_HoLot.Text + " "+txt_Ten.Text +".", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNV.Text) || BUS_NhanVien.checkID(txt_MaNV.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên "+txt_HoLot.Text+" "+txt_Ten.Text+"?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    DTO_NhanVien nv = new DTO_NhanVien();
                    nv.SMaNV = txt_MaNV.Text;
                    if (BUS_NhanVien.deleteNV(nv))
                    {
                        showDataOnDGV();
                        MessageBox.Show("Đã xóa nhân viên.", "Thông báo", MessageBoxButtons.OK);
                        btn_Huy_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNV.Text) || BUS_NhanVien.checkID(txt_MaNV.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK);
                return;
            } 
            else
            {
                if (string.IsNullOrEmpty(txt_HoLot.Text) || string.IsNullOrEmpty(txt_Ten.Text) || string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrEmpty(txt_QueQuan.Text) || cb_ChucVu.SelectedIndex == -1)
                {
                    MessageBox.Show("Không được bỏ trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (double.TryParse(txt_Ten.Text, out _) || double.TryParse(txt_HoLot.Text, out _))
                {
                    MessageBox.Show("Họ lót và tên không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Check.checkNgaySinh(dtp_NgaySinh.Text))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Check.checkEmail(txt_Email.Text))
                {
                    MessageBox.Show("Email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DTO_NhanVien nv = new DTO_NhanVien();
                    nv.SMaNV = txt_MaNV.Text.ToString();
                    nv.SHoLot = txt_HoLot.Text.ToString();
                    nv.STen = txt_Ten.Text.ToString();
                    nv.SEmail = txt_Email.Text.ToString();
                    nv.SQueQuan = txt_QueQuan.Text.ToString();
                    nv.DNgaySinh = DateTime.Parse(dtp_NgaySinh.Text.ToString());
                    if (rd_Nam.Checked)
                    {
                        nv.SPhai = rd_Nam.Text.ToString();
                    }
                    else
                    {
                        nv.SPhai = rd_Nu.Text.ToString();
                    }
                    nv.SMaCV = cb_ChucVu.SelectedValue.ToString();

                    if (BUS_NhanVien.updateNV(nv))
                    {
                        showDataOnDGV();
                        MessageBox.Show("Đã cập nhật thông tin nhân viên " + txt_MaNV.Text, "Thông báo", MessageBoxButtons.OK);
                        btn_Them.Enabled = false;
                        btn_Xoa.Enabled = true;
                        btn_Sua.Enabled = true;
                        txt_MaNV.Enabled = false;
                        txt_TenTK.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật thông tin nhân viên " + txt_MaNV.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btn_Them.Enabled = false;
                        btn_Xoa.Enabled = true;
                        btn_Sua.Enabled = true;
                        txt_MaNV.Enabled = false;
                        txt_TenTK.Enabled = false;
                    }
                }
            }
            
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            txt_MaNV.Enabled = true;
            txt_TenTK.Enabled = true;

            txt_MaNV.Text = "";
            txt_TenTK.Text = "";
            txt_HoLot.Text = "";
            txt_Ten.Text = "";
            txt_Email.Text = "";
            txt_QueQuan.Text = "";
            rd_Nam.Checked = true;
            dtp_NgaySinh.Text = DateTime.Now.ToString();
            cb_ChucVu.SelectedIndex = -1;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string ten = txt_TimKiem.Text;
            DTO_NhanVien nv = BUS_NhanVien.checkID(frm_DangNhap.nv.SMaNV);
            string manv = nv.SMaNV;
            if (string.IsNullOrEmpty(ten) || ten == "Nhập tên nhân viên cần tìm...")
            {
                MessageBox.Show("Chưa nhập tên nhân viên cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TimKiem.Focus();
            }
            else
            {
                List<DTO_NhanVien> list_NV = BUS_NhanVien.searchNV(manv, ten);
                if (list_NV == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgv_NV.DataSource = list_NV;
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            showDataOnDGV();
            txt_TimKiem.ForeColor = SystemColors.GrayText;
            txt_TimKiem.Text = "Nhập tên nhân viên cần tìm...";
        }
    }
}
