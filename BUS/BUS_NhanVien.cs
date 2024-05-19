using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhanVien
    {
        public static string getMD5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBulder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBulder.Append(data[i].ToString("x2"));
            }
            return sBulder.ToString();
        }

        public static DTO_NhanVien logIn(string tentk, string matkhau)
        {
            MD5 md5Hash = MD5.Create();
            string mkMH = getMD5Hash(md5Hash, matkhau);
            return DAO_NhanVien.logIn(tentk, mkMH);
        }

        public static bool changePassword(DTO_NhanVien tk, string mkMoi)
        {
            MD5 mD5 = MD5.Create();
            string mkMH = getMD5Hash(mD5, mkMoi);
            tk.SMatKhau = mkMH;
            return DAO_NhanVien.changeMatKhau(tk);
        }
        public static DTO_NhanVien getTaiKhoan(string tentk)
        {
            return DAO_NhanVien.getTaiKhoan(tentk);
        }
        public static bool updateTaiKhoan(DTO_NhanVien nv)
        {
            return DAO_NhanVien.upadateTaiKhoan(nv);
        }
        public static List<DTO_NhanVien> getAllNhanVien(string manv)
        {
            return DAO_NhanVien.getAllNhanVien(manv);
        }
        public static DTO_NhanVien checkID(string id)
        {
            return DAO_NhanVien.checkID(id);
        }
        public static bool addNV(DTO_NhanVien nv)
        {
            return DAO_NhanVien.addNhanVien(nv);
        }
        public static bool updateNV(DTO_NhanVien nv)
        {
            return DAO_NhanVien.updateNhanVien(nv);
        }
        public static bool deleteNV(DTO_NhanVien nv)
        {
            return DAO_NhanVien.deleteNhanVien(nv);
        }
        public static List<DTO_NhanVien> searchNV(string manv, string ten)
        {
            return DAO_NhanVien.searchNV(manv, ten);
        }
    }
}
