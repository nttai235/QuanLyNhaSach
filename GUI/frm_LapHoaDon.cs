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
    public partial class frm_LapHoaDon : Form
    {
        frm_DangNhap frm_DangNhap;
        public static DTO_HoaDon mhd;
        public frm_LapHoaDon()
        {
            InitializeComponent();
        }

        private void frm_LapHoaDon_Load(object sender, EventArgs e)
        {
            showSachonCB();
            cb_MaSach.SelectedIndex = -1;
        }

        private void btn_TaoHDMoi_Click(object sender, EventArgs e)
        {
            dgv_CTHD.DataSource = null;

            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            btn_ThemCTHD.Enabled = true;
            btn_XoaCTHD.Enabled = true;
            btn_TaoHDMoi.Enabled = false;
            txt_SoLuong.Enabled = true;

            txt_SoLuong.Text = "";
            txt_MaHD.Text = Check.taoMaHD("HD");
            txt_NgayLap.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            DTO_NhanVien nv = BUS_NhanVien.getTaiKhoan(frm_DangNhap.nv.STenTK);
            txt_MaNVLap.Text = nv.SMaNV.ToString();
            txt_NVLap.Text = nv.SHoLot.ToString() + " " + nv.STen.ToString();
            cb_MaSach.SelectedIndex = -1;
            txt_TongTien.Text = "";

            if (BUS_HoaDon.checkHD(txt_MaHD.Text) == null)
            {
                DTO_HoaDon hd = new DTO_HoaDon();
                hd.SMaHD = txt_MaHD.Text.ToString();
                hd.SMaNV = txt_MaNVLap.Text.ToString();
                hd.DNgayLap = DateTime.Parse(txt_NgayLap.Text.ToString());
                hd.FTongTien = 0;
                if (BUS_HoaDon.addHD(hd))
                {
                    MessageBox.Show("Tạo hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Lỗi tạo hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (dgv_CTHD.Rows.Count <= 0)
            {
                MessageBox.Show("Không có sản phẩm nào trong hoá đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DTO_HoaDon hd = new DTO_HoaDon();
                hd.SMaHD = txt_MaHD.Text.ToString();
                hd.FTongTien = float.Parse(txt_TongTien.Text.ToString());
                if (BUS_HoaDon.updateHD(hd))
                {
                    MessageBox.Show("Đã lưu hoá đơn.", "Thông báo", MessageBoxButtons.OK);
                    mhd = new DTO_HoaDon();
                    mhd = BUS_HoaDon.checkHD(txt_MaHD.Text.ToString());
                    btn_Luu.Enabled = false;
                    btn_ThemCTHD.Enabled = false;
                    btn_XoaCTHD.Enabled = false;
                    btn_Huy.Enabled = false;
                    btn_TaoHDMoi.Enabled = true;
                    btn_InHD.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Lưu hoá đơn không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                DTO_HoaDon hd = new DTO_HoaDon();
                hd.SMaHD = txt_MaHD.Text.ToString();
                if (BUS_HoaDon.deleteHD(hd))
                {
                    MessageBox.Show("Đã hủy hóa đơn.", "Thông báo", MessageBoxButtons.OK);
                    txt_MaHD.Text = "";
                    txt_NgayLap.Text = "";
                    txt_MaNVLap.Text = "";
                    txt_NVLap.Text = "";
                    cb_MaSach.SelectedIndex = -1;
                    txt_SoLuong.Text = "";
                    txt_TongTien.Text = "";
                    dgv_CTHD.DataSource = null;
                    txt_SoLuong.Enabled = false;
                    btn_Luu.Enabled = false;
                    btn_Huy.Enabled = false;
                    btn_ThemCTHD.Enabled = false;
                    btn_XoaCTHD.Enabled = false;
                    btn_TaoHDMoi.Enabled = true;
                    btn_InHD.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Hủy hoá đơn không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_ThemCTHD_Click(object sender, EventArgs e)
        {
            if (cb_MaSach.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txt_SoLuong.Text))
            {
                MessageBox.Show("Số lượng trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(int.Parse(txt_SoLuong.Text) <= 0 || !int.TryParse(txt_SoLuong.Text, out _))
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DTO_Sach s = BUS_Sach.checkID(cb_MaSach.SelectedValue.ToString());
                if (s.ISoLuong < int.Parse(txt_SoLuong.Text))
                {
                    MessageBox.Show("Số lượng sách không đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DTO_ChiTietHoaDon ct = new DTO_ChiTietHoaDon();
                ct.SMaHD = txt_MaHD.Text.ToString();
                ct.SMaSach = cb_MaSach.SelectedValue.ToString();
                ct.ISoLuong = int.Parse(txt_SoLuong.Text.ToString());
                ct.FThanhTien = float.Parse(txt_ThanhTien.Text.ToString());

                DTO_ChiTietHoaDon ktct = BUS_ChiTietHoaDon.getCTHD(txt_MaHD.Text, cb_MaSach.SelectedValue.ToString());
                if (ktct != null)
                {
                    int sl = ktct.ISoLuong + int.Parse(txt_SoLuong.Text);
                    float tt = ktct.FThanhTien + float.Parse(txt_ThanhTien.Text);
                    if (BUS_ChiTietHoaDon.updateCTHDsl(ktct, sl) && BUS_ChiTietHoaDon.updateCTHDtt(ktct, tt))
                    {
                        MessageBox.Show("Đã cập nhật số lượng sách vào hóa đơn.", "Thông báo", MessageBoxButtons.OK);
                        int slcl = s.ISoLuong - int.Parse(txt_SoLuong.Text);
                        BUS_Sach.updateSLSach(s, slcl);
                        showDataOnDGV();
                        float tongtien = 0;
                        List<DTO_ChiTietHoaDon> lst_ct = BUS_ChiTietHoaDon.getListCTHD(txt_MaHD.Text);
                        for (int i = 0; i < lst_ct.Count; i++)
                        {
                            tongtien += lst_ct[i].FThanhTien;
                        }
                        txt_TongTien.Text = tongtien.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật số lượng sách vào hóa đơn.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    if (BUS_ChiTietHoaDon.addCTHD(ct))
                    {
                        MessageBox.Show("Đã thêm sách vào hóa đơn.", "Thông báo", MessageBoxButtons.OK);
                        int slcl = s.ISoLuong - int.Parse(txt_SoLuong.Text);
                        BUS_Sach.updateSLSach(s, slcl);
                        showDataOnDGV();
                        float tongtien = 0;
                        List<DTO_ChiTietHoaDon> lst_ct = BUS_ChiTietHoaDon.getListCTHD(txt_MaHD.Text);
                        for (int i = 0; i < lst_ct.Count; i++)
                        {
                            tongtien += lst_ct[i].FThanhTien;
                        }
                        txt_TongTien.Text = tongtien.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm sách vào hóa đơn.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btn_XoaCTHD_Click(object sender, EventArgs e)
        {
            if (cb_MaSach.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa sách " + txt_TenSach.Text + " khỏi hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    DTO_ChiTietHoaDon ct = new DTO_ChiTietHoaDon();
                    ct.SMaHD = txt_MaHD.Text.ToString();
                    ct.SMaSach = cb_MaSach.SelectedValue.ToString();
                    if (BUS_ChiTietHoaDon.deleteCTHD(ct))
                    {
                        showDataOnDGV();
                        MessageBox.Show("Đã xóa sách khỏi hóa đơn.", "Thông báo", MessageBoxButtons.OK);
                        btn_ThemCTHD.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa sách khỏi hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txt_SoLuong.Text == "")
            {
                txt_ThanhTien.Text = "0";
            }
            else
            {
                txt_ThanhTien.Text = (float.Parse(txt_SoLuong.Text) * float.Parse(txt_DonGia.Text)).ToString();
            }
        }

        private void cb_MaSach_TextChanged(object sender, EventArgs e)
        {
            if (cb_MaSach.Text == "")
            {
                txt_TenSach.Text = "";
                txt_DonGia.Text = "";
            }
            else
            {
                DTO_Sach s = BUS_Sach.checkID(cb_MaSach.Text.ToString());
                if (s != null)
                {
                    txt_TenSach.Text = s.STenSach.ToString();
                    txt_DonGia.Text = s.FDonGiaBan.ToString();
                    txt_SoLuong.Text = "0";
                }
            }
        }
        private void showSachonCB()
        {
            List<DTO_Sach> list_Sach = BUS_Sach.getSachLonHonKhong();
            cb_MaSach.DataSource = list_Sach;
            cb_MaSach.DisplayMember = "SMaSach".Trim();
            cb_MaSach.ValueMember = "SMaSach".Trim();
        }
        
        private void showDataOnDGV()
        {
            List<DTO_ChiTietHoaDon> ct = BUS_ChiTietHoaDon.getListCTHD(txt_MaHD.Text);
            if(ct != null)
            {
                dgv_CTHD.DataSource = ct;
                dgv_CTHD.Columns["SMaHD"].HeaderText = "Mã hóa đơn";
                dgv_CTHD.Columns["SMaHD"].Width = 150;
                dgv_CTHD.Columns["SMaSach"].HeaderText = "Mã sách";
                dgv_CTHD.Columns["SMaSach"].Width = 100;
                dgv_CTHD.Columns["STenSach"].HeaderText = "Tên sách";
                dgv_CTHD.Columns["STenSach"].Width = 300;
                dgv_CTHD.Columns["ISoLuong"].HeaderText = "Số lượng";
                dgv_CTHD.Columns["ISoLuong"].Width = 50;
                dgv_CTHD.Columns["FThanhTien"].HeaderText = "Thành tiền";
                dgv_CTHD.Columns["FThanhTien"].Width = 100;
            }
            else
            {
                dgv_CTHD.DataSource = null;
            }
            dgv_CTHD.AllowUserToAddRows = false;
            dgv_CTHD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgv_CTHD_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_CTHD.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgv_CTHD.SelectedRows[0];
                cb_MaSach.SelectedValue = r.Cells["SMaSach"].Value.ToString();
                txt_SoLuong.Text = r.Cells["ISoLuong"].Value.ToString();

                btn_ThemCTHD.Enabled = false;
            }
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            frm_InHoaDon frm_InHoaDon = new frm_InHoaDon();
            frm_InHoaDon.ShowDialog();
        }
    }
}
