using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Sach
    {
        private string sMaSach;
        private string sTenSach;
        private string sMaTheLoai;
        private string sTenTheLoai;
        private string sTacGia;
        private string sMaNXB;
        private string sTenNXB;
        private int iSoLuong;
        private float fDonGiaNhap;
        private float fDonGiaBan;
        public string SMaSach { get { return sMaSach; } set { sMaSach = value; } }
        public string STenSach { get { return sTenSach; } set { sTenSach = value; } }
        public string SMaTheLoai { get { return sMaTheLoai; } set { sMaTheLoai = value; } }
        public string STenTheLoai { get { return sTenTheLoai; } set { sTenTheLoai = value; } }
        public string STacGia { get {  return sTacGia; } set { sTacGia = value; } }
        public string SMaNXB { get {  return sMaNXB; } set { sMaNXB = value; } }
        public string STenNXB { get { return sTenNXB; } set { sTenNXB = value; } }
        public int ISoLuong { get { return iSoLuong; } set {  iSoLuong = value; } }
        public float FDonGiaNhap { get {  return fDonGiaNhap; } set {  fDonGiaNhap = value; } }
        public float FDonGiaBan { get {  return fDonGiaBan; } set { fDonGiaBan = value; } }
    }
}
