using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Sach
    {
        static SqlConnection conn;
        public static List<DTO_Sach> getSach()
        {
            string sQuery = "select s.*, t.*, n.* from Sach s, TheLoai t, NXB n where s.matheloai = t.matheloai and s.manxb = n.manxb";
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_Sach> list_Sach = new List<DTO_Sach>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Sach s = new DTO_Sach();
                s.SMaSach = dt.Rows[i]["masach"].ToString();
                s.STenSach = dt.Rows[i]["tensach"].ToString();
                s.SMaTheLoai = dt.Rows[i]["matheloai"].ToString();
                s.STenTheLoai = dt.Rows[i]["tentheloai"].ToString();
                s.STacGia = dt.Rows[i]["tacgia"].ToString();
                s.SMaNXB = dt.Rows[i]["manxb"].ToString();
                s.STenNXB = dt.Rows[i]["tennxb"].ToString();
                s.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                s.FDonGiaNhap = float.Parse(dt.Rows[i]["dongianhap"].ToString());
                s.FDonGiaBan = float.Parse(dt.Rows[i]["dongiaban"].ToString());
                list_Sach.Add(s);
            }
            return list_Sach;
        }
        public static bool addSach(DTO_Sach s)
        {
            string sQuery = string.Format(@"insert into Sach values('{0}', N'{1}', '{2}', N'{3}', '{4}', '{5}', '{6}', '{7}')", s.SMaSach, s.STenSach, s.SMaTheLoai, s.STacGia, s.SMaNXB, s.ISoLuong, s.FDonGiaNhap, s.FDonGiaBan);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool updateSach(DTO_Sach s)
        {
            string sQuery = string.Format(@"update Sach set tensach=N'{0}', matheloai='{1}', tacgia='{2}', manxb='{3}', soluong='{4}', dongianhap='{5}', dongiaban='{6}' where masach='{7}'", s.STenSach, s.SMaTheLoai, s.STacGia, s.SMaNXB, s.ISoLuong, s.FDonGiaNhap, s.FDonGiaBan, s.SMaSach);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool deleteSach(DTO_Sach s)
        {
            string sQuery = string.Format(@"delete from Sach where masach='{0}'", s.SMaSach);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static DTO_Sach checkID(string id)
        {
            string sQuery = string.Format(@"select s.*, t.*, n.* from Sach s, TheLoai t, NXB n where s.matheloai = t.matheloai and s.manxb = n.manxb and s.masach = '{0}'", id);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_Sach s = new DTO_Sach();
            s.SMaSach = dt.Rows[0]["masach"].ToString();
            s.STenSach = dt.Rows[0]["tensach"].ToString();
            s.SMaTheLoai = dt.Rows[0]["matheloai"].ToString();
            s.STenTheLoai = dt.Rows[0]["tentheloai"].ToString();
            s.STacGia = dt.Rows[0]["tacgia"].ToString();
            s.SMaNXB = dt.Rows[0]["manxb"].ToString();
            s.STenNXB = dt.Rows[0]["tennxb"].ToString();
            s.ISoLuong = int.Parse(dt.Rows[0]["soluong"].ToString());
            s.FDonGiaNhap = float.Parse(dt.Rows[0]["dongianhap"].ToString());
            s.FDonGiaBan = float.Parse(dt.Rows[0]["dongiaban"].ToString());

            DataProvider.closeConn(conn);
            return s;
        }
        public static List<DTO_Sach> searchSach(string ten)
        {
            string sQuery = string.Format(@"select s.*, t.*, n.* from Sach s, TheLoai t, NXB n where s.matheloai = t.matheloai and s.manxb = n.manxb and s.tensach like '%{0}%'", ten);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_Sach> list_Sach = new List<DTO_Sach>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Sach s = new DTO_Sach();
                s.SMaSach = dt.Rows[i]["masach"].ToString();
                s.STenSach = dt.Rows[i]["tensach"].ToString();
                s.SMaTheLoai = dt.Rows[i]["matheloai"].ToString();
                s.STenTheLoai = dt.Rows[i]["tentheloai"].ToString();
                s.STacGia = dt.Rows[i]["tacgia"].ToString();
                s.SMaNXB = dt.Rows[i]["manxb"].ToString();
                s.STenNXB = dt.Rows[i]["tennxb"].ToString();
                s.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                s.FDonGiaNhap = float.Parse(dt.Rows[i]["dongianhap"].ToString());
                s.FDonGiaBan = float.Parse(dt.Rows[i]["dongiaban"].ToString());
                list_Sach.Add(s);
            }
            DataProvider.closeConn(conn);
            return list_Sach;
        }
        public static List<DTO_Sach> getSachLonHonKhong()
        {
            string sQuery = "select s.*, t.*, n.* from Sach s, TheLoai t, NXB n where s.matheloai = t.matheloai and s.manxb = n.manxb and s.soluong>0";
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_Sach> list_Sach = new List<DTO_Sach>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Sach s = new DTO_Sach();
                s.SMaSach = dt.Rows[i]["masach"].ToString();
                s.STenSach = dt.Rows[i]["tensach"].ToString();
                s.SMaTheLoai = dt.Rows[i]["matheloai"].ToString();
                s.STenTheLoai = dt.Rows[i]["tentheloai"].ToString();
                s.STacGia = dt.Rows[i]["tacgia"].ToString();
                s.SMaNXB = dt.Rows[i]["manxb"].ToString();
                s.STenNXB = dt.Rows[i]["tennxb"].ToString();
                s.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                s.FDonGiaNhap = float.Parse(dt.Rows[i]["dongianhap"].ToString());
                s.FDonGiaBan = float.Parse(dt.Rows[i]["dongiaban"].ToString());
                list_Sach.Add(s);
            }
            return list_Sach;
        }
        public static bool updateSLSach(DTO_Sach s, int sl)
        {
            string sQuery = string.Format(@"update Sach set soluong='{0}' where masach='{1}'", sl, s.SMaSach);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
    }
}
