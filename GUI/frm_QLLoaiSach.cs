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
    public partial class frm_QLLoaiSach : Form
    {
        public frm_QLLoaiSach()
        {
            InitializeComponent();
            txt_TimKiem.ForeColor = SystemColors.GrayText;
            txt_TimKiem.Text = "Nhập tên thể loại cần tìm...";
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            this.txt_TimKiem.Enter += new System.EventHandler(this.txt_TimKiem_Enter);
        }

        private void frm_QLLoaiSach_Load(object sender, EventArgs e)
        {
            showDataOnDGV();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_MaTheLoai.Text) || string.IsNullOrEmpty(txt_TenTheLoai.Text))
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_MaTheLoai.Text.Length > 10)
            {
                MessageBox.Show("Mã thể loại không được dài quá 10 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Check.isNumeric(txt_TenTheLoai.Text))
            {
                MessageBox.Show("Tên thể loại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (BUS_TheLoai.checkID(txt_MaTheLoai.Text) != null)
            {
                MessageBox.Show("Mã thể loại đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DTO_TheLoai tl = new DTO_TheLoai();
                tl.SMaTheLoai = txt_MaTheLoai.Text.ToString();
                tl.STenTheLoai = txt_TenTheLoai.Text.ToString();
                if (BUS_TheLoai.addTheLoai(tl))
                {
                    showDataOnDGV();
                    MessageBox.Show("Đã thêm thể loại " + txt_TenTheLoai.Text + ".", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm thể loại không thành công.", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaTheLoai.Text) || BUS_TheLoai.checkID(txt_MaTheLoai.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn thể loại!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thể loại " + txt_TenTheLoai.Text + "?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    DTO_TheLoai tl = new DTO_TheLoai();
                    tl.SMaTheLoai = txt_MaTheLoai.Text.ToString();
                    if (BUS_TheLoai.deleteTheLoai(tl))
                    {
                        showDataOnDGV();
                        MessageBox.Show("Đã xóa thể loại.", "Thông báo", MessageBoxButtons.OK);
                        btn_Huy_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thể loại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaTheLoai.Text) || BUS_TheLoai.checkID(txt_MaTheLoai.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn thể loại!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (string.IsNullOrEmpty(txt_TenTheLoai.Text))
                {
                    MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Check.isNumeric(txt_TenTheLoai.Text))
                {
                    MessageBox.Show("Tên thể loại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DTO_TheLoai tl = new DTO_TheLoai();
                    tl.SMaTheLoai = txt_MaTheLoai.Text.ToString();
                    tl.STenTheLoai = txt_TenTheLoai.Text.ToString();
                    if (BUS_TheLoai.updateTheLoai(tl))
                    {
                        showDataOnDGV();
                        MessageBox.Show("Đã cập nhật thông tin thể loại.", "Thông báo", MessageBoxButtons.OK);
                        btn_Them.Enabled = false;
                        btn_Xoa.Enabled = true;
                        btn_Sua.Enabled = true;
                        txt_MaTheLoai.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin thể loại không thành công.", "Thông báo", MessageBoxButtons.OK);
                        btn_Them.Enabled = false;
                        btn_Xoa.Enabled = true;
                        btn_Sua.Enabled = true;
                        txt_MaTheLoai.Enabled = false;
                    }
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            txt_MaTheLoai.Enabled = true;

            txt_MaTheLoai.Text = "";
            txt_TenTheLoai.Text = "";
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tentheloai = txt_TimKiem.Text;
            if (string.IsNullOrEmpty(tentheloai) || tentheloai == "Nhập tên thể loại cần tìm...")
            {
                MessageBox.Show("Chưa nhập tên thể loại cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TimKiem.Focus();
            }
            else
            {
                List<DTO_TheLoai> list_tl = BUS_TheLoai.searchTheLoai(tentheloai);
                if (list_tl == null)
                {
                    MessageBox.Show("Không tìm thấy thể loại cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgv_TheLoai.DataSource = list_tl;
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            showDataOnDGV();
            txt_TimKiem.ForeColor = SystemColors.GrayText;
            txt_TimKiem.Text = "Nhập tên thể loại cần tìm...";
        }

        private void dgv_TheLoai_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_TheLoai.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgv_TheLoai.SelectedRows[0];
                txt_MaTheLoai.Text = r.Cells["SMaTheLoai"].Value.ToString();
                txt_TenTheLoai.Text = r.Cells["STenTheLoai"].Value.ToString();

                btn_Them.Enabled = false;
                txt_MaTheLoai.Enabled = false;
            }
        }

        private void txt_TimKiem_Enter(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "Nhập tên thể loại cần tìm...")
            {
                txt_TimKiem.Text = "";
                txt_TimKiem.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text.Length == 0)
            {
                txt_TimKiem.Text = "Nhập tên thể loại cần tìm...";
                txt_TimKiem.ForeColor = SystemColors.GrayText;
            }
        }
        private void showDataOnDGV()
        {
            List<DTO_TheLoai> tl = BUS_TheLoai.getTheLoai();
            dgv_TheLoai.DataSource = tl;
            dgv_TheLoai.Columns["SMaTheLoai"].HeaderText = "Mã thể loại";
            dgv_TheLoai.Columns["SMaTheLoai"].Width = 200;
            dgv_TheLoai.Columns["STenTheLoai"].HeaderText = "Tên thể loại";
            dgv_TheLoai.Columns["STenTheLoai"].Width = 300;
            dgv_TheLoai.AllowUserToAddRows = false;
            dgv_TheLoai.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
