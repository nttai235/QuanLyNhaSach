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
    public partial class frm_InHoaDon : Form
    {
        frm_LapHoaDon frm_LapHoaDon;
        public frm_InHoaDon()
        {
            InitializeComponent();
        }

        private void frm_InHoaDon_Load(object sender, EventArgs e)
        {
            frm_LapHoaDon = new frm_LapHoaDon();
            dTOChiTietHoaDonBindingSource.DataSource = BUS_ChiTietHoaDon.getListCTHD(frm_LapHoaDon.mhd.SMaHD);

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("ReportParameter_hdMaHD", frm_LapHoaDon.mhd.SMaHD));
            reportParameters.Add(new ReportParameter("ReportParameter_hdNhanVien", frm_LapHoaDon.mhd.SMaNV));
            reportParameters.Add(new ReportParameter("ReportParameter_hdNgayLap", frm_LapHoaDon.mhd.DNgayLap.ToString()));
            reportParameters.Add(new ReportParameter("ReportParameter_hdTongTien", frm_LapHoaDon.mhd.FTongTien.ToString()));
            reportViewer1.LocalReport.SetParameters(reportParameters);

            this.reportViewer1.RefreshReport();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
