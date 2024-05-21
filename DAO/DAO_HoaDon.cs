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
    public class DAO_HoaDon
    {
        static SqlConnection conn;
        public static List<DTO_HoaDon> getHD()
        {
            string sQuery = "select * from HoaDon";
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_HoaDon> list_hd = new List<DTO_HoaDon>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_HoaDon hd = new DTO_HoaDon();
                hd.SMaHD = dt.Rows[i]["mahd"].ToString();
                hd.SMaNV = dt.Rows[i]["manv"].ToString();
                hd.DNgayLap = DateTime.Parse(dt.Rows[i]["ngaylap"].ToString());
                hd.FTongTien = float.Parse(dt.Rows[i]["tongtien"].ToString());
                list_hd.Add(hd);
            }
            return list_hd;
        }
        public static bool addHD(DTO_HoaDon hd)
        {
            string sQuery = string.Format(@"insert into HoaDon values('{0}', '{1}', '{2}', '{3}')", hd.SMaHD, hd.SMaNV, hd.DNgayLap, hd.FTongTien);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool updateHD(DTO_HoaDon hd)
        {
            string sQuery = string.Format(@"update HoaDon set tongtien='{0}' where mahd='{1}'", hd.FTongTien, hd.SMaHD);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool deleteHD(DTO_HoaDon hd)
        {
            string sQuery = string.Format(@"delete from HoaDon where mahd='{0}'", hd.SMaHD);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static DTO_HoaDon checkHD(string mahd)
        {
            string sQuery = string.Format(@"select * from HoaDon where mahd='{0}'", mahd);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_HoaDon hd = new DTO_HoaDon();
            hd.SMaHD = dt.Rows[0]["mahd"].ToString();
            hd.SMaNV = dt.Rows[0]["manv"].ToString();
            hd.DNgayLap = DateTime.Parse(dt.Rows[0]["ngaylap"].ToString());
            hd.FTongTien = float.Parse(dt.Rows[0]["tongtien"].ToString());
            return hd;
        }
        public static List<DTO_HoaDon> getHDbyNV(string manv)
        {
            string sQuery = string.Format(@"select h.*, n.* from HoaDon h, NhanVien n where h.manv=n.manv and h.manv='{0}'", manv);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_HoaDon> list_hd = new List<DTO_HoaDon>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_HoaDon hd = new DTO_HoaDon();
                hd.SMaHD = dt.Rows[i]["mahd"].ToString();
                hd.SMaNV = dt.Rows[i]["manv"].ToString();
                hd.STenNV = dt.Rows[i]["ten"].ToString();
                hd.DNgayLap = DateTime.Parse(dt.Rows[i]["ngaylap"].ToString());
                hd.FTongTien = float.Parse(dt.Rows[i]["tongtien"].ToString());
                list_hd.Add(hd);
            }
            return list_hd;
        }
        public static List<DTO_HoaDon> getHDbyNVnDay(string manv, string ngay)
        {
            string sQuery = string.Format(@"select h.*, n.* from HoaDon h, NhanVien n where h.manv=n.manv and h.manv='{0}' and h.ngaylap='{1}'",manv, ngay);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_HoaDon> list_hd = new List<DTO_HoaDon>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_HoaDon hd = new DTO_HoaDon();
                hd.SMaHD = dt.Rows[i]["mahd"].ToString();
                hd.SMaNV = dt.Rows[i]["manv"].ToString();
                hd.DNgayLap = DateTime.Parse(dt.Rows[i]["ngaylap"].ToString());
                hd.FTongTien = float.Parse(dt.Rows[i]["tongtien"].ToString());
                list_hd.Add(hd);
            }
            return list_hd;
        }
    }
}
