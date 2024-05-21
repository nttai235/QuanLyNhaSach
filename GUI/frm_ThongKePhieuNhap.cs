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
    public partial class frm_ThongKePhieuNhap : Form
    {
        public frm_ThongKePhieuNhap()
        {
            InitializeComponent();
        }

        private void frm_ThongKePhieuNhap_Load(object sender, EventArgs e)
        {
            List<DTO_NhanVien> lst_NV = BUS_NhanVien.getNhanVienKH();
            cb_NV.DataSource = lst_NV;
            cb_NV.DisplayMember = "SMaNV";
            cb_NV.ValueMember = "SMaNV";

            dTOPhieuNhapBindingSource.DataSource = BUS_PhieuNhap.getPN();
            this.reportViewer1.RefreshReport();
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            if (!Check.checkNgay(dtp_ChonNgay.Text))
            {
                MessageBox.Show("Ngày không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dTOPhieuNhapBindingSource.DataSource = BUS_PhieuNhap.getPNbyNVnDay(cb_NV.SelectedValue.ToString(), dtp_ChonNgay.Text.ToString());
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
