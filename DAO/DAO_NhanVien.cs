using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_NhanVien
    {
        static SqlConnection conn;
        public static List<DTO_NhanVien> getAllNhanVien(string manv)
        {
            string sQuery = string.Format(@"select nv.*, cv.* from NhanVien nv, ChucVu cv where nv.macv = cv.macv and nv.manv not in ('{0}')", manv);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_NhanVien> lst_nv = new List<DTO_NhanVien>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.SMaNV = dt.Rows[i]["manv"].ToString();
                nv.STenTK = dt.Rows[i]["tentk"].ToString();
                nv.SMatKhau = dt.Rows[i]["matkhau"].ToString();
                nv.SHoLot = dt.Rows[i]["holot"].ToString();
                nv.STen = dt.Rows[i]["ten"].ToString();
                nv.SEmail = dt.Rows[i]["email"].ToString();
                nv.DNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SPhai = dt.Rows[i]["phai"].ToString();
                nv.SQueQuan = dt.Rows[i]["quequan"].ToString();
                nv.SMaCV = dt.Rows[i]["macv"].ToString();
                nv.STenCV = dt.Rows[i]["tencv"].ToString();
                lst_nv.Add(nv);
            }
            return lst_nv;
        }
        public static DTO_NhanVien getTaiKhoan(string tentk)
        {
            string sQuery = string.Format(@"select nv.*, cv.* from NhanVien nv, ChucVu cv where cv.macv = nv.macv and nv.tentk = '{0}'", tentk);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.SMaNV = dt.Rows[0]["manv"].ToString();
            nv.STenTK = dt.Rows[0]["tentk"].ToString();
            nv.SMatKhau = dt.Rows[0]["matkhau"].ToString();
            nv.SHoLot = dt.Rows[0]["holot"].ToString();
            nv.STen = dt.Rows[0]["ten"].ToString();
            nv.SEmail = dt.Rows[0]["email"].ToString();
            nv.DNgaySinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
            nv.SPhai = dt.Rows[0]["phai"].ToString();
            nv.SQueQuan = dt.Rows[0]["quequan"].ToString();
            nv.SMaCV = dt.Rows[0]["macv"].ToString();
            nv.STenCV = dt.Rows[0]["tencv"].ToString();

            DataProvider.closeConn(conn);
            return nv;
        }
        public static DTO_NhanVien checkID(string id)
        {
            string sQuery = string.Format(@"select nv.*, cv.* from NhanVien nv, ChucVu cv where cv.macv = nv.macv and nv.manv = '{0}'", id);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.SMaNV = dt.Rows[0]["manv"].ToString();
            nv.STenTK = dt.Rows[0]["tentk"].ToString();
            nv.SMatKhau = dt.Rows[0]["matkhau"].ToString();
            nv.SHoLot = dt.Rows[0]["holot"].ToString();
            nv.STen = dt.Rows[0]["ten"].ToString();
            nv.SEmail = dt.Rows[0]["email"].ToString();
            nv.DNgaySinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
            nv.SPhai = dt.Rows[0]["phai"].ToString();
            nv.SQueQuan = dt.Rows[0]["quequan"].ToString();
            nv.SMaCV = dt.Rows[0]["macv"].ToString();
            nv.STenCV = dt.Rows[0]["tencv"].ToString();

            DataProvider.closeConn(conn);
            return nv;
        }
        public static DTO_NhanVien logIn(string tentk, string matkhau)
        {
            string sQuery = string.Format(@"select * from NhanVien where tentk='{0}' and matkhau='{1}'", tentk, matkhau);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.SMaNV = dt.Rows[0]["manv"].ToString();
            nv.STenTK = dt.Rows[0]["tentk"].ToString();
            nv.SMatKhau = dt.Rows[0]["matkhau"].ToString();
            nv.SHoLot = dt.Rows[0]["holot"].ToString();
            nv.STen = dt.Rows[0]["ten"].ToString();
            nv.SEmail = dt.Rows[0]["email"].ToString();
            nv.DNgaySinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
            nv.SPhai = dt.Rows[0]["phai"].ToString();
            nv.SQueQuan = dt.Rows[0]["quequan"].ToString();
            nv.SMaCV = dt.Rows[0]["macv"].ToString();

            DataProvider.closeConn(conn);
            return nv;
        }
        public static bool addNhanVien(DTO_NhanVien nv)
        {
            string sQuery = string.Format(@"insert into NhanVien(manv, tentk, holot, ten, email, ngaysinh, phai, quequan, macv) values(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}')", nv.SMaNV, nv.STenTK, nv.SHoLot, nv.STen,  nv.SEmail, nv.DNgaySinh, nv.SPhai, nv.SQueQuan, nv.SMaCV);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }

        public static bool updateNhanVien(DTO_NhanVien nv)
        {
            string sQuery = string.Format(@"update NhanVien set holot=N'{0}', ten=N'{1}', email=N'{2}', ngaysinh=N'{3}', phai=N'{4}', quequan=N'{5}', macv='{6}' where manv='{7}'", nv.SHoLot, nv.STen, nv.SEmail, nv.DNgaySinh, nv.SPhai, nv.SQueQuan, nv.SMaCV, nv.SMaNV);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }

        public static bool deleteNhanVien(DTO_NhanVien nv)
        {
            string sQuery = string.Format(@"delete from NhanVien where manv='{0}'", nv.SMaNV);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool changeMatKhau(DTO_NhanVien nv)
        {
            string sQuery = string.Format(@"update NhanVien set matkhau='{0}' where tentk='{1}'", nv.SMatKhau, nv.STenTK);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            return kq;
        }
        public static bool upadateTaiKhoan(DTO_NhanVien nv)
        {
            string sQuery = string.Format(@"update NhanVien set holot=N'{0}', ten=N'{1}', email=N'{2}', ngaysinh=N'{3}', phai=N'{4}', quequan=N'{5}' where manv='{6}'", nv.SHoLot, nv.STen, nv.SEmail, nv.DNgaySinh, nv.SPhai, nv.SQueQuan, nv.SMaNV);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static List<DTO_NhanVien> searchNV(string manv, string ten)
        {
            string sQuery = string.Format(@"select nv.*, cv.* from NhanVien nv, ChucVu cv where nv.macv = cv.macv and nv.manv not in ('{0}') and nv.ten like '%{1}%'", manv, ten);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_NhanVien> list_NV = new List<DTO.DTO_NhanVien>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.SMaNV = dt.Rows[i]["manv"].ToString();
                nv.STenTK = dt.Rows[i]["tentk"].ToString();
                nv.SMatKhau = dt.Rows[i]["matkhau"].ToString();
                nv.SHoLot = dt.Rows[i]["holot"].ToString();
                nv.STen = dt.Rows[i]["ten"].ToString();
                nv.SEmail = dt.Rows[i]["email"].ToString();
                nv.DNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SPhai = dt.Rows[i]["phai"].ToString();
                nv.SQueQuan = dt.Rows[i]["quequan"].ToString();
                nv.SMaCV = dt.Rows[0]["macv"].ToString();
                nv.STenCV = dt.Rows[i]["tencv"].ToString();
                list_NV.Add(nv);
            }
            DataProvider.closeConn(conn);
            return list_NV;
        }
    }
}
