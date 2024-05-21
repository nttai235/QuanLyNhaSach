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
    public partial class frm_LapPhieuNhap : Form
    {
        frm_DangNhap frm_DangNhap;
        public static DTO_PhieuNhap mpn;
        public frm_LapPhieuNhap()
        {
            InitializeComponent();
        }

        private void frm_LapPhieuNhap_Load(object sender, EventArgs e)
        {
            showSachonCB();
            showNCConCB();
            cb_MaSach.SelectedIndex = -1;
            cb_NCC.SelectedIndex = -1;
        }

        private void btn_TaoPNMoi_Click(object sender, EventArgs e)
        {
            if (cb_NCC.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgv_CTPN.DataSource = null;

                btn_Luu.Enabled = true;
                btn_Huy.Enabled = true;
                btn_ThemCTPN.Enabled = true;
                btn_XoaCTPN.Enabled = true;
                btn_TaoPNMoi.Enabled = false;
                txt_SoLuong.Enabled = true;

                txt_SoLuong.Text = "";
                txt_MaPN.Text = Check.taoMaHD("PN");
                txt_NgayLap.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                DTO_NhanVien nv = BUS_NhanVien.getTaiKhoan(frm_DangNhap.nv.STenTK);
                txt_MaNVLap.Text = nv.SMaNV.ToString();
                cb_MaSach.SelectedIndex = -1;
                txt_TongTien.Text = "";

                if (BUS_PhieuNhap.checkPN(txt_MaPN.Text) == null)
                {

                    DTO_PhieuNhap pn = new DTO_PhieuNhap();
                    pn.SMaPN = txt_MaPN.Text.ToString();
                    pn.SMaNV = txt_MaNVLap.Text.ToString();
                    pn.SMaNCC = cb_NCC.SelectedValue.ToString();
                    pn.DNgayLap = DateTime.Parse(txt_NgayLap.Text.ToString());
                    pn.FTongTien = 0;
                    if (BUS_PhieuNhap.addPN(pn))
                    {
                        MessageBox.Show("Tạo phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi tạo phiếu nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (dgv_CTPN.Rows.Count <= 0)
            {
                MessageBox.Show("Không có sản phẩm nào trong phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DTO_PhieuNhap pn = new DTO_PhieuNhap();
                pn.SMaPN = txt_MaPN.Text.ToString();
                pn.SMaNCC = cb_NCC.SelectedValue.ToString();
                pn.FTongTien = float.Parse(txt_TongTien.Text.ToString());
                if (BUS_PhieuNhap.updatePN(pn))
                {
                    MessageBox.Show("Đã lưu phiếu nhập.", "Thông báo", MessageBoxButtons.OK);
                    mpn = new DTO_PhieuNhap();
                    mpn = BUS_PhieuNhap.checkPN(txt_MaPN.Text.ToString());
                    btn_Luu.Enabled = false;
                    btn_ThemCTPN.Enabled = false;
                    btn_XoaCTPN.Enabled = false;
                    btn_Huy.Enabled = false;
                    btn_TaoPNMoi.Enabled = true;
                    btn_InPN.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Lưu phiếu nhập không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btn_ThemCTPN_Click(object sender, EventArgs e)
        {
            if (cb_MaSach.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txt_SoLuong.Text))
            {
                MessageBox.Show("Số lượng trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (int.Parse(txt_SoLuong.Text) <= 0 || !int.TryParse(txt_SoLuong.Text, out _))
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                DTO_Sach s = BUS_Sach.checkID(cb_MaSach.SelectedValue.ToString());

                DTO_ChiTietPhieuNhap ct = new DTO_ChiTietPhieuNhap();
                ct.SMaPN = txt_MaPN.Text.ToString();
                ct.SMaSach = cb_MaSach.SelectedValue.ToString();
                ct.ISoLuong = int.Parse(txt_SoLuong.Text.ToString());
                ct.FThanhTien = float.Parse(txt_ThanhTien.Text.ToString());

                DTO_ChiTietPhieuNhap ktct = BUS_ChiTietPhieuNhap.getCTPN(txt_MaPN.Text, cb_MaSach.SelectedValue.ToString());
                if (ktct != null)
                {
                    int sl = ktct.ISoLuong + int.Parse(txt_SoLuong.Text);
                    float tt = ktct.FThanhTien + float.Parse(txt_ThanhTien.Text);
                    if (BUS_ChiTietPhieuNhap.updateCTPNsl(ktct, sl) && BUS_ChiTietPhieuNhap.updateCTPNtt(ktct, tt))
                    {
                        MessageBox.Show("Đã cập nhật số lượng sách vào phiếu nhập.", "Thông báo", MessageBoxButtons.OK);
                        int slcl = s.ISoLuong + int.Parse(txt_SoLuong.Text);
                        BUS_Sach.updateSLSach(s, slcl);
                        showDataOnDGV();
                        float tongtien = 0;
                        List<DTO_ChiTietPhieuNhap> lst_ct = BUS_ChiTietPhieuNhap.getListCTPN(txt_MaPN.Text);
                        for (int i = 0; i < lst_ct.Count; i++)
                        {
                            tongtien += lst_ct[i].FThanhTien;
                        }
                        txt_TongTien.Text = tongtien.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật số lượng sách vào phiếu nhập.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    if (BUS_ChiTietPhieuNhap.addCTPN(ct))
                    {
                        MessageBox.Show("Đã thêm sách vào phiếu nhập.", "Thông báo", MessageBoxButtons.OK);
                        int slcl = s.ISoLuong + int.Parse(txt_SoLuong.Text);
                        BUS_Sach.updateSLSach(s, slcl);
                        showDataOnDGV();
                        float tongtien = 0;
                        List<DTO_ChiTietPhieuNhap> lst_ct = BUS_ChiTietPhieuNhap.getListCTPN(txt_MaPN.Text);
                        for (int i = 0; i < lst_ct.Count; i++)
                        {
                            tongtien += lst_ct[i].FThanhTien;
                        }
                        txt_TongTien.Text = tongtien.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm sách vào phiếu nhập.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btn_XoaCTPN_Click(object sender, EventArgs e)
        {
            if (cb_MaSach.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa sách " + txt_TenSach.Text + " khỏi phiếu nhập?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    DTO_ChiTietPhieuNhap ct = new DTO_ChiTietPhieuNhap();
                    ct.SMaPN = txt_MaPN.Text.ToString();
                    ct.SMaSach = cb_MaSach.SelectedValue.ToString();
                    if (BUS_ChiTietPhieuNhap.deleteCTPN(ct))
                    {
                        showDataOnDGV();
                        MessageBox.Show("Đã xóa sách khỏi phiếu nhập.", "Thông báo", MessageBoxButtons.OK);
                        btn_ThemCTPN.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa sách khỏi phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy phiếu nhập?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                DTO_PhieuNhap pn = new DTO_PhieuNhap();
                pn.SMaPN = txt_MaPN.Text.ToString();
                if (BUS_PhieuNhap.deletePN(pn))
                {
                    MessageBox.Show("Đã hủy phiếu nhập.", "Thông báo", MessageBoxButtons.OK);
                    txt_MaPN.Text = "";
                    txt_NgayLap.Text = "";
                    txt_MaNVLap.Text = "";
                    cb_NCC.SelectedIndex = -1;
                    cb_MaSach.SelectedIndex = -1;
                    txt_SoLuong.Text = "";
                    txt_TongTien.Text = "";
                    dgv_CTPN.DataSource = null;
                    txt_SoLuong.Enabled = false;
                    btn_Luu.Enabled = false;
                    btn_Huy.Enabled = false;
                    btn_ThemCTPN.Enabled = false;
                    btn_XoaCTPN.Enabled = false;
                    btn_TaoPNMoi.Enabled = true;
                    btn_InPN.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Hủy phiếu nhập không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_InPN_Click(object sender, EventArgs e)
        {
            frm_InPhieuNhap frm_InPhieuNhap = new frm_InPhieuNhap();
            frm_InPhieuNhap.ShowDialog();
        }

        private void dgv_CTPN_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_CTPN.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgv_CTPN.SelectedRows[0];
                cb_MaSach.SelectedValue = r.Cells["SMaSach"].Value.ToString();
                txt_SoLuong.Text = r.Cells["ISoLuong"].Value.ToString();

                btn_ThemCTPN.Enabled = false;
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
                    txt_DonGia.Text = s.FDonGiaNhap.ToString();
                    txt_SoLuong.Text = "0";
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
        private void showDataOnDGV()
        {
            List<DTO_ChiTietPhieuNhap> ct = BUS_ChiTietPhieuNhap.getListCTPN(txt_MaPN.Text);
            if (ct != null)
            {
                dgv_CTPN.DataSource = ct;
                dgv_CTPN.Columns["SMaPN"].HeaderText = "Mã phiếu nhập";
                dgv_CTPN.Columns["SMaPN"].Width = 150;
                dgv_CTPN.Columns["SMaSach"].HeaderText = "Mã sách";
                dgv_CTPN.Columns["SMaSach"].Width = 100;
                dgv_CTPN.Columns["STenSach"].HeaderText = "Tên sách";
                dgv_CTPN.Columns["STenSach"].Width = 300;
                dgv_CTPN.Columns["ISoLuong"].HeaderText = "Số lượng";
                dgv_CTPN.Columns["ISoLuong"].Width = 50;
                dgv_CTPN.Columns["FThanhTien"].HeaderText = "Thành tiền";
                dgv_CTPN.Columns["FThanhTien"].Width = 100;
            }
            else
            {
                dgv_CTPN.DataSource = null;
            }
            dgv_CTPN.AllowUserToAddRows = false;
            dgv_CTPN.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void showSachonCB()
        {
            List<DTO_Sach> list_Sach = BUS_Sach.getSach();
            cb_MaSach.DataSource = list_Sach;
            cb_MaSach.DisplayMember = "SMaSach".Trim();
            cb_MaSach.ValueMember = "SMaSach".Trim();
        }
        private void showNCConCB()
        {
            List<DTO_NhaCungCap> list_ncc = BUS_NhaCungCap.getNhaCungCap();
            cb_NCC.DataSource = list_ncc;
            cb_NCC.DisplayMember = "STenNCC";
            cb_NCC.ValueMember = "SMaNCC";
        }
    }
}
