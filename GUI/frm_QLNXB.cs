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
    public partial class frm_QLNXB : Form
    {
        public frm_QLNXB()
        {
            InitializeComponent();
            txt_TimKiem.ForeColor = SystemColors.GrayText;
            txt_TimKiem.Text = "Nhập tên NXB cần tìm...";
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            this.txt_TimKiem.Enter += new System.EventHandler(this.txt_TimKiem_Enter);

        }

        private void frm_QLNXB_Load(object sender, EventArgs e)
        {
            showDataOnDGV();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNXB.Text) || string.IsNullOrEmpty(txt_TenNXB.Text) || string.IsNullOrEmpty(txt_DiaChi.Text) || string.IsNullOrEmpty(txt_SDT.Text))
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txt_MaNXB.Text.Length > 10)
            {
                MessageBox.Show("Mã NXB không được dài quá 10 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Check.isNumeric(txt_SDT.Text) || txt_SDT.Text.Length<10 || txt_SDT.Text.Length>11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (BUS_NXB.checkID(txt_MaNXB.Text) != null)
            {
                MessageBox.Show("Mã NXB đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DTO_NXB nxb = new DTO_NXB();
                nxb.SMaNXB = txt_MaNXB.Text.ToString();
                nxb.STenNXB = txt_TenNXB.Text.ToString();
                nxb.SDiaChi = txt_DiaChi.Text.ToString();
                nxb.SSDT = txt_SDT.Text.ToString().Trim();
                if (BUS_NXB.addNXB(nxb))
                {
                    showDataOnDGV();
                    MessageBox.Show("Đã thêm NXB " + txt_TenNXB.Text + ".", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm NXB không thành công.", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNXB.Text) || BUS_NXB.checkID(txt_MaNXB.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn NXB!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa NXB "+txt_TenNXB.Text+"?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    DTO_NXB nxb = new DTO_NXB();
                    nxb.SMaNXB = txt_MaNXB.Text.ToString();
                    if (BUS_NXB.deleteNXB(nxb))
                    {
                        showDataOnDGV();
                        MessageBox.Show("Đã xóa NXB.", "Thông báo", MessageBoxButtons.OK);
                        btn_Huy_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa NXB không thành công.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNXB.Text) || BUS_NXB.checkID(txt_MaNXB.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn NXB!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (string.IsNullOrEmpty(txt_TenNXB.Text) || string.IsNullOrEmpty(txt_DiaChi.Text) || string.IsNullOrEmpty(txt_SDT.Text))
                {
                    MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Check.isNumeric(txt_SDT.Text) || txt_SDT.Text.Length < 10 || txt_SDT.Text.Length > 11)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DTO_NXB nxb = new DTO_NXB();
                    nxb.SMaNXB = txt_MaNXB.Text.ToString();
                    nxb.STenNXB = txt_TenNXB.Text.ToString();
                    nxb.SDiaChi = txt_DiaChi.Text.ToString();
                    nxb.SSDT = txt_SDT.Text.ToString().Trim();
                    if (BUS_NXB.updateNXB(nxb))
                    {
                        showDataOnDGV();
                        MessageBox.Show("Đã cập nhật thông tin NXB.", "Thông báo", MessageBoxButtons.OK);
                        btn_Them.Enabled = false;
                        btn_Xoa.Enabled = true;
                        btn_Sua.Enabled = true;
                        txt_MaNXB.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật thông tin NXB.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btn_Them.Enabled = false;
                        btn_Xoa.Enabled = true;
                        btn_Sua.Enabled = true;
                        txt_MaNXB.Enabled = false;
                    }
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            txt_MaNXB.Enabled = true;

            txt_MaNXB.Text = "";
            txt_TenNXB.Text = "";
            txt_DiaChi.Text = "";
            txt_SDT.Text = "";
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tennxb = txt_TimKiem.Text;
            if (string.IsNullOrEmpty(tennxb) || tennxb == "Nhập tên NXB cần tìm...")
            {
                MessageBox.Show("Chưa nhập tên NXB cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TimKiem.Focus();
            }
            else
            {
                List<DTO_NXB> list_nxb = BUS_NXB.searchNXB(tennxb);
                if (list_nxb == null)
                {
                    MessageBox.Show("Không tìm thấy NXB cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgv_NXB.DataSource = list_nxb;
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            showDataOnDGV();
            txt_TimKiem.ForeColor = SystemColors.GrayText;
            txt_TimKiem.Text = "Nhập tên NXB cần tìm...";
        }

        private void dgv_NXB_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_NXB.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgv_NXB.SelectedRows[0];
                txt_MaNXB.Text = r.Cells["SMaNXB"].Value.ToString();
                txt_TenNXB.Text = r.Cells["STenNXB"].Value.ToString();
                txt_DiaChi.Text = r.Cells["SDiaChi"].Value.ToString();
                txt_SDT.Text = r.Cells["SSDT"].Value.ToString().Trim();

                btn_Them.Enabled = false;
                txt_MaNXB.Enabled = false;
            }
        }

        private void txt_TimKiem_Enter(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "Nhập tên NXB cần tìm...")
            {
                txt_TimKiem.Text = "";
                txt_TimKiem.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text.Length == 0)
            {
                txt_TimKiem.Text = "Nhập tên NXB cần tìm...";
                txt_TimKiem.ForeColor = SystemColors.GrayText;
            }
        }
        private void showDataOnDGV()
        {
            List<DTO_NXB> nxb = BUS_NXB.getNXB();
            dgv_NXB.DataSource = nxb;
            dgv_NXB.Columns["SMaNXB"].HeaderText = "Mã NXB";
            dgv_NXB.Columns["SMaNXB"].Width = 100;
            dgv_NXB.Columns["STenNXB"].HeaderText = "Tên NXB";
            dgv_NXB.Columns["STenNXB"].Width = 200;
            dgv_NXB.Columns["SDiaChi"].HeaderText = "Địa chỉ";
            dgv_NXB.Columns["SDiaChi"].Width = 300;
            dgv_NXB.Columns["SSDT"].HeaderText = "SDT";
            dgv_NXB.Columns["SSDT"].Width = 150;
            dgv_NXB.AllowUserToAddRows = false;
            dgv_NXB.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
