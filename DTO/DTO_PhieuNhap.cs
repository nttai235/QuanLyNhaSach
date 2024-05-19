using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuNhap
    {
        private string sMaPN;
        private string sMaNV;
        private string sMaNCC;
        private string sTenNCC;
        private DateTime dNgayLap;
        private float fTongTien;
        public string SMaPN { get { return sMaPN; } set { sMaPN = value; } }
        public string SMaNV { get { return sMaNV; } set { sMaNV = value; } }
        public string SMaNCC { get { return sMaNCC; } set { sMaNCC = value; } }
        public string STenNCC { get { return sTenNCC; } set { sTenNCC = value; } }
        public DateTime DNgayLap { get { return dNgayLap; } set { dNgayLap = value; } }
        public float FTongTien { get {  return fTongTien; } set {  fTongTien = value; } }
    }
}
