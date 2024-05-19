using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        private string sMaNV;
        private string sTenTK;
        private string sMatKhau;
        private string sHoLot;
        private string sTen;
        private string sEmail;
        private DateTime dNgaySinh;
        private string sPhai;
        private string sQueQuan;
        private string sMaCV;
        private string sTenCV;
        public string SMaNV { get {  return sMaNV; } set {  sMaNV = value; } }
        public string STenTK { get { return sTenTK; } set { sTenTK = value; } }
        public string SMatKhau { get { return sMatKhau; } set { sMatKhau = value; } }
        public string SHoLot {  get { return sHoLot; } set { sHoLot = value; } }
        public string STen { get {  return sTen; } set { sTen = value; } }
        public string SEmail { get { return sEmail; } set { sEmail = value; } }
        public DateTime DNgaySinh { get {  return dNgaySinh; } set {  dNgaySinh = value; } }
        public string SPhai { get {  return sPhai; } set { sPhai = value; } }
        public string SQueQuan { get {  return sQueQuan; } set { sQueQuan = value; } }
        public string SMaCV { get {  return sMaCV; } set { sMaCV = value; } }
        public string STenCV { get { return sTenCV; } set { sTenCV = value; } }
    }
}
