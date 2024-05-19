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
    public partial class frm_QLSach : Form
    {
        public frm_QLSach()
        {
            InitializeComponent();
            txt_TimKiem.ForeColor = SystemColors.GrayText;
            txt_TimKiem.Text = "Nhập tên sách cần tìm...";
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            this.txt_TimKiem.Enter += new System.EventHandler(this.txt_TimKiem_Enter);
        }

        private void frm_QLSach_Load(object sender, EventArgs e)
        {
            showNXBonCB();
            showTLonCB();
            showDataOnDGV();
            cb_NXB.SelectedIndex = -1;
            cb_TheLoai.SelectedIndex = -1;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaSach.Text) || string.IsNullOrEmpty(txt_TenSach.Text) || string.IsNullOrEmpty(txt_TacGia.Text) || string.IsNullOrEmpty(txt_SoLuong.Text) || string.IsNullOrEmpty(txt_DGNhap.Text) || string.IsNullOrEmpty(txt_DGBan.Text) || cb_NXB.SelectedIndex==-1 || cb_TheLoai.SelectedIndex==-1)
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_MaSach.Text.Length > 20)
            {
                MessageBox.Show("Mã nhân viên không được dài quá 20 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Check.isNumeric(txt_SoLuong.Text) || int.Parse(txt_SoLuong.Text) < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Check.isNumeric(txt_DGNhap.Text) || float.Parse(txt_DGNhap.Text) < 0)
            {
                MessageBox.Show("Đơn giá nhập không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Check.isNumeric(txt_DGBan.Text) || float.Parse(txt_DGBan.Text) < 0)
            {
                MessageBox.Show("Đơn giá bán không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (BUS_Sach.checkID(txt_MaSach.Text) != null)
            {
                MessageBox.Show("Mã sách đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DTO_Sach s = new DTO_Sach();
                s.SMaSach = txt_MaSach.Text.ToString();
                s.STenSach = txt_TenSach.Text.ToString();
                s.STacGia = txt_TacGia.Text.ToString();
                s.ISoLuong = int.Parse(txt_SoLuong.Text.ToString());
                s.FDonGiaNhap = float.Parse(txt_DGNhap.Text.ToString());
                s.FDonGiaBan = float.Parse(txt_DGBan.Text.ToString());
                s.SMaTheLoai = cb_TheLoai.SelectedValue.ToString();
                s.SMaNXB = cb_NXB.SelectedValue.ToString();
                if (BUS_Sach.addSach(s))
                {
                    showDataOnDGV();
                    MessageBox.Show("Đã thêm sách " +  txt_TenSach.Text + ".", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm sách không thành công.", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaSach.Text) || BUS_Sach.checkID(txt_MaSach.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn sách!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa sách "+txt_TenSach.Text+"?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    DTO_Sach s = new DTO_Sach();
                    s.SMaSach = txt_MaSach.Text.ToString();
                    if (BUS_Sach.deleteSach(s))
                    {
                        showDataOnDGV();
                        MessageBox.Show("Đã xóa sách.", "Thông báo", MessageBoxButtons.OK);
                        btn_Huy_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaSach.Text) || BUS_Sach.checkID(txt_MaSach.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn sách!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (string.IsNullOrEmpty(txt_TenSach.Text) || string.IsNullOrEmpty(txt_TacGia.Text) || string.IsNullOrEmpty(txt_SoLuong.Text) || string.IsNullOrEmpty(txt_DGNhap.Text) || string.IsNullOrEmpty(txt_DGBan.Text) || cb_NXB.SelectedIndex == -1 || cb_TheLoai.SelectedIndex == -1)
                {
                    MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Check.isNumeric(txt_SoLuong.Text) || int.Parse(txt_SoLuong.Text) < 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Check.isNumeric(txt_DGNhap.Text) || float.Parse(txt_DGNhap.Text) < 0)
                {
                    MessageBox.Show("Đơn giá nhập không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Check.isNumeric(txt_DGBan.Text) || float.Parse(txt_DGBan.Text) < 0)
                {
                    MessageBox.Show("Đơn gía bán không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DTO_Sach s = new DTO_Sach();
                    s.SMaSach = txt_MaSach.Text.ToString();
                    s.STenSach = txt_TenSach.Text.ToString();
                    s.STacGia = txt_TacGia.Text.ToString();
                    s.ISoLuong = int.Parse(txt_SoLuong.Text.ToString());
                    s.FDonGiaNhap = float.Parse(txt_DGNhap.Text.ToString());
                    s.FDonGiaBan = float.Parse(txt_DGBan.Text.ToString());
                    s.SMaTheLoai = cb_TheLoai.SelectedValue.ToString();
                    s.SMaNXB = cb_NXB.SelectedValue.ToString();

                    if (BUS_Sach.updateSach(s))
                    {
                        showDataOnDGV();
                        MessageBox.Show("Đã cập nhật thông tin sách.", "Thông báo", MessageBoxButtons.OK);
                        btn_Them.Enabled = false;
                        btn_Xoa.Enabled = true;
                        btn_Sua.Enabled = true;
                        txt_MaSach.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin sách không thành công.", "Thông báo", MessageBoxButtons.OK);
                        btn_Them.Enabled = false;
                        btn_Xoa.Enabled = true;
                        btn_Sua.Enabled = true;
                        txt_MaSach.Enabled = false;
                    }
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            txt_MaSach.Enabled = true;

            txt_MaSach.Text = "";
            txt_TenSach.Text = "";
            txt_TacGia.Text = "";
            txt_SoLuong.Text = "";
            txt_DGNhap.Text = "";
            txt_DGBan.Text = "";
            cb_NXB.SelectedIndex = -1;
            cb_TheLoai.SelectedIndex = -1;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tensach = txt_TimKiem.Text;
            if (string.IsNullOrEmpty(tensach) || tensach == "Nhập tên sách cần tìm...")
            {
                MessageBox.Show("Chưa nhập tên sách cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TimKiem.Focus();
            }
            else
            {
                List<DTO_Sach> list_sach = BUS_Sach.searchSach(tensach);
                if (list_sach == null)
                {
                    MessageBox.Show("Không tìm thấy sách cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgv_Sach.DataSource = list_sach;
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            showDataOnDGV();
            txt_TimKiem.ForeColor = SystemColors.GrayText;
            txt_TimKiem.Text = "Nhập tên sách cần tìm...";
        }

        private void txt_TimKiem_Enter(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "Nhập tên sách cần tìm...")
            {
                txt_TimKiem.Text = "";
                txt_TimKiem.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text.Length == 0)
            {
                txt_TimKiem.Text = "Nhập tên sách cần tìm...";
                txt_TimKiem.ForeColor = SystemColors.GrayText;
            }
        }
        private void showTLonCB()
        {
            List<DTO_TheLoai> list_TL = BUS_TheLoai.getTheLoai();
            cb_TheLoai.DataSource = list_TL;
            cb_TheLoai.DisplayMember = "STenTheLoai";
            cb_TheLoai.ValueMember = "SMaTheLoai";
        }
        private void showNXBonCB()
        {
            List<DTO_NXB> list_NXB = BUS_NXB.getNXB();
            cb_NXB.DataSource = list_NXB;
            cb_NXB.DisplayMember = "STenNXB";
            cb_NXB.ValueMember = "SMaNXB";
        }
        private void showDataOnDGV()
        {
            List<DTO_Sach> s = BUS_Sach.getSach();
            dgv_Sach.DataSource = s;
            dgv_Sach.Columns["SMaSach"].HeaderText = "Mã sách";
            dgv_Sach.Columns["SMaSach"].Width = 50;
            dgv_Sach.Columns["STenSach"].HeaderText = "Tên sách";
            dgv_Sach.Columns["STenSach"].Width = 200;
            dgv_Sach.Columns["STenTheLoai"].HeaderText = "Thể loại";
            dgv_Sach.Columns["STenTheLoai"].Width = 150;
            dgv_Sach.Columns["STacGia"].HeaderText = "Tác giả";
            dgv_Sach.Columns["STacGia"].Width = 150;
            dgv_Sach.Columns["STenNXB"].HeaderText = "NXB";
            dgv_Sach.Columns["STenNXB"].Width = 150;
            dgv_Sach.Columns["ISoLuong"].HeaderText = "Số lượng";
            dgv_Sach.Columns["ISoLuong"].Width = 50;
            dgv_Sach.Columns["FDonGiaNhap"].HeaderText = "Đơn giá nhập";
            dgv_Sach.Columns["FDonGiaNhap"].Width = 100;
            dgv_Sach.Columns["FDonGiaBan"].HeaderText = "Đơn giá bán";
            dgv_Sach.Columns["FDonGiaBan"].Width = 100;
            dgv_Sach.Columns["SMaTheLoai"].Visible = false;
            dgv_Sach.Columns["SMaNXB"].Visible = false;
            dgv_Sach.AllowUserToAddRows = false;
            dgv_Sach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgv_Sach_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_Sach.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgv_Sach.SelectedRows[0];
                txt_MaSach.Text = r.Cells["SMaSach"].Value.ToString();
                txt_TenSach.Text = r.Cells["STenSach"].Value.ToString();
                txt_TacGia.Text = r.Cells["STacGia"].Value.ToString();
                txt_SoLuong.Text = r.Cells["ISoLuong"].Value.ToString();
                txt_DGNhap.Text = r.Cells["FDonGiaNhap"].Value.ToString();
                txt_DGBan.Text = r.Cells["FDonGiaBan"].Value.ToString();
                cb_NXB.SelectedValue = r.Cells["SMaNXB"].Value.ToString();
                cb_TheLoai.SelectedValue = r.Cells["SMaTheLoai"].Value.ToString();

                btn_Them.Enabled = false;
                txt_MaSach.Enabled = false;
            }
        }
    }
}
