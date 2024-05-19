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
    public class DAO_ChiTietHoaDon
    {
        static SqlConnection conn;
        public static List<DTO_ChiTietHoaDon> getListCTHD(string mahd)
        {
            string sQuery = "select c. *, h.*, s.* from ChiTietHoaDon c, HoaDon h, Sach s where c.mahd=h.mahd and s.masach=c.masach and c.mahd='"+mahd+"'";
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_ChiTietHoaDon> list_ct = new List<DTO_ChiTietHoaDon> ();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_ChiTietHoaDon ct = new DTO_ChiTietHoaDon();
                ct.SMaHD = dt.Rows[i]["mahd"].ToString();
                ct.SMaSach = dt.Rows[i]["masach"].ToString();
                ct.STenSach = dt.Rows[i]["tensach"].ToString();
                ct.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                ct.FThanhTien = float.Parse(dt.Rows[i]["thanhtien"].ToString());
                list_ct.Add(ct);
            }
            return list_ct;
        }
        public static bool addCTHD(DTO_ChiTietHoaDon ct)
        {
            string sQuery = string.Format(@"insert into ChiTietHoaDon values('{0}', '{1}', '{2}', '{3}')", ct.SMaHD, ct.SMaSach, ct.ISoLuong, ct.FThanhTien);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool updateCTHDsl(DTO_ChiTietHoaDon ct, int sl)
        {
            string sQuery = string.Format(@"update ChiTietHoaDon set soluong='{0}' where mahd='{1}' and masach='{2}'", sl, ct.SMaHD, ct.SMaSach);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool updateCTHDtt(DTO_ChiTietHoaDon ct, float tt)
        {
            string sQuery = string.Format(@"update ChiTietHoaDon set thanhtien='{0}' where mahd='{1}' and masach='{2}'", tt, ct.SMaHD, ct.SMaSach);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool deleteCTHD(DTO_ChiTietHoaDon ct)
        {
            string sQuery = string.Format(@"delete from ChiTietHoaDon where mahd='{0}' and masach='{1}'", ct.SMaHD, ct.SMaSach);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static DTO_ChiTietHoaDon getCTHD(string idHD, string idSach)
        {
            string sQuery = string.Format(@"select c. *, h.*, s.* from ChiTietHoaDon c, HoaDon h, Sach s where c.mahd=h.mahd and s.masach=c.masach and c.mahd='{0}' and c.masach='{1}'", idHD, idSach);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_ChiTietHoaDon ct = new DTO_ChiTietHoaDon();
            ct.SMaHD = dt.Rows[0]["mahd"].ToString();
            ct.SMaSach = dt.Rows[0]["masach"].ToString();
            ct.STenSach = dt.Rows[0]["tensach"].ToString();
            ct.ISoLuong = int.Parse(dt.Rows[0]["soluong"].ToString());
            ct.FThanhTien = float.Parse(dt.Rows[0]["thanhtien"].ToString());
            DataProvider.closeConn(conn);
            return ct;
        }
    }
}
