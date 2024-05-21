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
    public class DAO_ChiTietPhieuNhap
    {
        static SqlConnection conn;
        public static List<DTO_ChiTietPhieuNhap> getListCTPN(string mapn)
        {
            string sQuery = "select c. *, p.*, s.* from ChiTietPhieuNhap c, PhieuNhap p, Sach s where c.maphieu=p.maphieu and s.masach=c.masach and c.maphieu='" + mapn + "'";
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_ChiTietPhieuNhap> list_ct = new List<DTO_ChiTietPhieuNhap>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_ChiTietPhieuNhap ct = new DTO_ChiTietPhieuNhap();
                ct.SMaPN = dt.Rows[i]["maphieu"].ToString();
                ct.SMaSach = dt.Rows[i]["masach"].ToString();
                ct.STenSach = dt.Rows[i]["tensach"].ToString();
                ct.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                ct.FThanhTien = float.Parse(dt.Rows[i]["thanhtien"].ToString());
                list_ct.Add(ct);
            }
            return list_ct;
        }
        public static bool addCTPN(DTO_ChiTietPhieuNhap ct)
        {
            string sQuery = string.Format(@"insert into ChiTietPhieuNhap values('{0}', '{1}', '{2}', '{3}')", ct.SMaPN, ct.SMaSach, ct.ISoLuong, ct.FThanhTien);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool updateCTPNsl(DTO_ChiTietPhieuNhap ct, int sl)
        {
            string sQuery = string.Format(@"update ChiTietPhieuNhap set soluong='{0}' where maphieu='{1}' and masach='{2}'", sl, ct.SMaPN, ct.SMaSach);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool updateCTPNtt(DTO_ChiTietPhieuNhap ct, float tt)
        {
            string sQuery = string.Format(@"update ChiTietPhieuNhap set thanhtien='{0}' where maphieu='{1}' and masach='{2}'", tt, ct.SMaPN, ct.SMaSach);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool deleteCTPN(DTO_ChiTietPhieuNhap ct)
        {
            string sQuery = string.Format(@"delete from ChiTietPhieuNhap where maphieu='{0}' and masach='{1}'", ct.SMaPN, ct.SMaSach);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static DTO_ChiTietPhieuNhap getCTPN(string idPN, string idSach)
        {
            string sQuery = string.Format(@"select c. *, p.*, s.* from ChiTietPhieuNhap c, PhieuNhap p, Sach s where c.maphieu=p.maphieu and s.masach=c.masach and c.maphieu='{0}' and c.masach='{1}'", idPN, idSach);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_ChiTietPhieuNhap ct = new DTO_ChiTietPhieuNhap();
            ct.SMaPN = dt.Rows[0]["maphieu"].ToString();
            ct.SMaSach = dt.Rows[0]["masach"].ToString();
            ct.STenSach = dt.Rows[0]["tensach"].ToString();
            ct.ISoLuong = int.Parse(dt.Rows[0]["soluong"].ToString());
            ct.FThanhTien = float.Parse(dt.Rows[0]["thanhtien"].ToString());
            DataProvider.closeConn(conn);
            return ct;
        }
    }
}
