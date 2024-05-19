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
    public partial class frm_QLNhaCC : Form
    {
        public frm_QLNhaCC()
        {
            InitializeComponent();
            txt_TimKiem.ForeColor = SystemColors.GrayText;
            txt_TimKiem.Text = "Nhập tên nhà cung cấp cần tìm...";
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            this.txt_TimKiem.Enter += new System.EventHandler(this.txt_TimKiem_Enter);
        }

        private void frm_QLNhaCC_Load(object sender, EventArgs e)
        {
            showDataOnDGV();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNCC.Text) || string.IsNullOrEmpty(txt_TenNCC.Text) || string.IsNullOrEmpty(txt_DiaChi.Text) || string.IsNullOrEmpty(txt_SDT.Text))
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_MaNCC.Text.Length > 10)
            {
                MessageBox.Show("Mã nhà cung cấp không được dài quá 10 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Check.isNumeric(txt_SDT.Text) || txt_SDT.Text.Length < 10 || txt_SDT.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (BUS_NhaCungCap.checkID(txt_MaNCC.Text) != null)
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DTO_NhaCungCap ncc = new DTO_NhaCungCap();
                ncc.SMaNCC = txt_MaNCC.Text.ToString();
                ncc.STenNCC = txt_TenNCC.Text.ToString();
                ncc.SDiaChi = txt_DiaChi.Text.ToString();
                ncc.SSDT = txt_SDT.Text.ToString().Trim();
                if (BUS_NhaCungCap.addNhaCungCap(ncc))
                {
                    showDataOnDGV();
                    MessageBox.Show("Đã thêm nhà cung cấp " + txt_TenNCC.Text + ".", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp không thành công.", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNCC.Text) || BUS_NhaCungCap.checkID(txt_MaNCC.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhà cung cấp "+txt_TenNCC.Text+"?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dr == DialogResult.OK)
                {
                    DTO_NhaCungCap ncc = new DTO_NhaCungCap();
                    ncc.SMaNCC = txt_MaNCC.Text.ToString();
                    if (BUS_NhaCungCap.deleteNhaCungCap(ncc))
                    {
                        showDataOnDGV();
                        MessageBox.Show("Đã xóa nhà cung cấp.", "Thông báo", MessageBoxButtons.OK);
                        btn_Huy_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhà cung cấp không thành công.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNCC.Text) || BUS_NhaCungCap.checkID(txt_MaNCC.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (string.IsNullOrEmpty(txt_TenNCC.Text) || string.IsNullOrEmpty(txt_DiaChi.Text) || string.IsNullOrEmpty(txt_SDT.Text))
                {
                    MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Check.isNumeric(txt_SDT.Text) || txt_SDT.Text.Length < 10 || txt_SDT.Text.Length > 11)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DTO_NhaCungCap ncc = new DTO_NhaCungCap();
                    ncc.SMaNCC = txt_MaNCC.Text.ToString();
                    ncc.STenNCC = txt_TenNCC.Text.ToString();
                    ncc.SDiaChi = txt_DiaChi.Text.ToString();
                    ncc.SSDT = txt_SDT.Text.ToString().Trim();
                    if (BUS_NhaCungCap.updateNhaCungCap(ncc))
                    {
                        showDataOnDGV();
                        MessageBox.Show("Đã cập nhật thông tin nhà cung cấp.", "Thông báo", MessageBoxButtons.OK);
                        btn_Them.Enabled = false;
                        btn_Xoa.Enabled = true;
                        btn_Sua.Enabled = true;
                        txt_MaNCC.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật thông tin nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btn_Them.Enabled = false;
                        btn_Xoa.Enabled = true;
                        btn_Sua.Enabled = true;
                        txt_MaNCC.Enabled = false;
                    }
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            txt_MaNCC.Enabled = true;

            txt_MaNCC.Text = "";
            txt_TenNCC.Text = "";
            txt_DiaChi.Text = "";
            txt_SDT.Text = "";
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tenncc = txt_TimKiem.Text;
            if (string.IsNullOrEmpty(tenncc) || tenncc == "Nhập tên nhà cung cấp cần tìm...")
            {
                MessageBox.Show("Chưa nhập tên nhà cung cấp cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TimKiem.Focus();
            }
            else
            {
                List<DTO_NhaCungCap> list_ncc = BUS_NhaCungCap.searchNCC(tenncc);
                if (list_ncc == null)
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgv_NCC.DataSource = list_ncc;
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            showDataOnDGV();
            txt_TimKiem.ForeColor = SystemColors.GrayText;
            txt_TimKiem.Text = "Nhập tên nhà cung cấp cần tìm...";
        }

        private void dgv_NCC_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_NCC.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgv_NCC.SelectedRows[0];
                txt_MaNCC.Text = r.Cells["SMaNCC"].Value.ToString();
                txt_TenNCC.Text = r.Cells["STenNCC"].Value.ToString();
                txt_DiaChi.Text = r.Cells["SDiaChi"].Value.ToString();
                txt_SDT.Text = r.Cells["SSDT"].Value.ToString().Trim();

                btn_Them.Enabled = false;
                txt_MaNCC.Enabled = false;
            }
        }

        private void txt_TimKiem_Enter(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "Nhập tên nhà cung cấp cần tìm...")
            {
                txt_TimKiem.Text = "";
                txt_TimKiem.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text.Length == 0)
            {
                txt_TimKiem.Text = "Nhập tên nhà cung cấp cần tìm...";
                txt_TimKiem.ForeColor = SystemColors.GrayText;
            }
        }
        private void showDataOnDGV()
        {
            List<DTO_NhaCungCap> ncc = BUS_NhaCungCap.getNhaCungCap();
            dgv_NCC.DataSource = ncc;
            dgv_NCC.Columns["SMaNCC"].HeaderText = "Mã NCC";
            dgv_NCC.Columns["SMaNCC"].Width = 100;
            dgv_NCC.Columns["STenNCC"].HeaderText = "Tên NCC";
            dgv_NCC.Columns["STenNCC"].Width = 200;
            dgv_NCC.Columns["SDiaChi"].HeaderText = "Địa chỉ";
            dgv_NCC.Columns["SDiaChi"].Width = 300;
            dgv_NCC.Columns["SSDT"].HeaderText = "SDT";
            dgv_NCC.Columns["SSDT"].Width = 150;
            dgv_NCC.AllowUserToAddRows = false;
            dgv_NCC.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
