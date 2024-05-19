using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHoaDon
    {
        private string sMaHD;
        private string sMaSach;
        private string sTenSach;
        private int iSoLuong;
        private float fThanhTien;
        public string SMaHD {  get { return sMaHD; } set {  sMaHD = value; } }
        public string SMaSach { get {  return sMaSach; } set { sMaSach = value; } }
        public string STenSach { get { return sTenSach; } set { sTenSach = value; } }
        public int ISoLuong { get {  return iSoLuong; } set {  iSoLuong = value; } }
        public float FThanhTien { get {  return fThanhTien; } set {  fThanhTien = value; } }
    }
}
