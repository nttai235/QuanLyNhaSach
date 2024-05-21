using BUS;
using DTO;
using Microsoft.Reporting.WinForms;
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
    public partial class frm_ThongKeHoaDon : Form
    {
        public frm_ThongKeHoaDon()
        {
            InitializeComponent();
        }

        private void frm_BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            List<DTO_NhanVien> lst_NV = BUS_NhanVien.getNhanVienBH();
            cb_NV.DataSource = lst_NV;
            cb_NV.DisplayMember = "SMaNV";
            cb_NV.ValueMember = "SMaNV";

            dTOHoaDonBindingSource.DataSource = BUS_HoaDon.getHD();
            this.reportViewer1.RefreshReport();
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            if(!Check.checkNgay(dtp_ChonNgay.Text))
            {
                MessageBox.Show("Ngày không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                dTOHoaDonBindingSource.DataSource = BUS_HoaDon.getHDbyNVnDay(cb_NV.SelectedValue.ToString(), dtp_ChonNgay.Text);
                this.reportViewer1.RefreshReport();
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            dTOHoaDonBindingSource.DataSource = BUS_HoaDon.getHD();
            this.reportViewer1.RefreshReport();
        }
    }
}
