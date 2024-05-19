using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        private string sMaHD;
        private string sMaNV;
        private string sTenNV;
        private DateTime dNgayLap;
        private float fTongTien;
        public string SMaHD { get { return sMaHD; } set { sMaHD = value; } }
        public string SMaNV { get { return sMaNV; } set { sMaNV = value; } }
        public string STenNV { get { return sTenNV; } set { sTenNV = value; } }
        public DateTime DNgayLap { get { return dNgayLap; } set { dNgayLap = value; } }
        public float FTongTien { get {  return fTongTien; } set {  fTongTien = value; } }
    }
}
