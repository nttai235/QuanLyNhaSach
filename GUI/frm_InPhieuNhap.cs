using BUS;
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
    public partial class frm_InPhieuNhap : Form
    {
        frm_LapPhieuNhap frm_LapPhieuNhap;
        public frm_InPhieuNhap()
        {
            InitializeComponent();
        }

        private void frm_InPhieuNhap_Load(object sender, EventArgs e)
        {
            frm_LapPhieuNhap = new frm_LapPhieuNhap();
            dTOChiTietPhieuNhapBindingSource.DataSource = BUS_ChiTietPhieuNhap.getListCTPN(frm_LapPhieuNhap.mpn.SMaPN);

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("ReportParameter_pnMaPN", frm_LapPhieuNhap.mpn.SMaPN));
            reportParameters.Add(new ReportParameter("ReportParameter_pnNhanVien", frm_LapPhieuNhap.mpn.SMaNV));
            reportParameters.Add(new ReportParameter("ReportParameter_pnNgayLap", frm_LapPhieuNhap.mpn.DNgayLap.ToString()));
            reportParameters.Add(new ReportParameter("ReportParameter_pnNhaCungCap", frm_LapPhieuNhap.mpn.STenNCC));
            reportParameters.Add(new ReportParameter("ReportParameter_pnTongTien", frm_LapPhieuNhap.mpn.FTongTien.ToString()));
            reportViewer1.LocalReport.SetParameters(reportParameters);

            this.reportViewer1.RefreshReport();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
