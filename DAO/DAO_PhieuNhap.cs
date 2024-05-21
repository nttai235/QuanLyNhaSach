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
    public class DAO_PhieuNhap
    {
        static SqlConnection conn;
        public static List<DTO_PhieuNhap> getPN()
        {
            string sQuery = "select p.*, n.*, c.* from PhieuNhap p, NhanVien n, NhaCungCap c where p.manv=n.manv and c.mancc=p.mancc";
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_PhieuNhap> list_pn = new List<DTO_PhieuNhap>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_PhieuNhap pn = new DTO_PhieuNhap();
                pn.SMaPN = dt.Rows[i]["maphieu"].ToString();
                pn.SMaNV = dt.Rows[i]["manv"].ToString();
                pn.SMaNCC = dt.Rows[i]["mancc"].ToString();
                pn.STenNCC = dt.Rows[i]["tenncc"].ToString();
                pn.DNgayLap = DateTime.Parse(dt.Rows[i]["ngaylap"].ToString());
                pn.FTongTien = float.Parse(dt.Rows[i]["tongtien"].ToString());
                list_pn.Add(pn);
            }
            return list_pn;
        }
        public static bool addPN(DTO_PhieuNhap pn)
        {
            string sQuery = string.Format(@"insert into PhieuNhap(maphieu, manv, mancc, ngaylap, tongtien) values('{0}', '{1}', '{2}', '{3}', '{4}')", pn.SMaPN, pn.SMaNV, pn.SMaNCC, pn.DNgayLap, pn.FTongTien);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool updatePN(DTO_PhieuNhap pn)
        {
            string sQuery = string.Format(@"update PhieuNhap set tongtien='{0}' where maphieu='{1}'", pn.FTongTien, pn.SMaPN);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool deletePN(DTO_PhieuNhap pn)
        {
            string sQuery = string.Format(@"delete from PhieuNhap where maphieu='{0}'", pn.SMaPN);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static DTO_PhieuNhap checkPN(string mapn)
        {
            string sQuery = string.Format(@"select * from PhieuNhap where maphieu='{0}'", mapn);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_PhieuNhap pn = new DTO_PhieuNhap();
            pn.SMaPN = dt.Rows[0]["maphieu"].ToString();
            pn.SMaNV = dt.Rows[0]["manv"].ToString();
            pn.SMaNCC = dt.Rows[0]["mancc"].ToString();
            pn.DNgayLap = DateTime.Parse(dt.Rows[0]["ngaylap"].ToString());
            pn.FTongTien = float.Parse(dt.Rows[0]["tongtien"].ToString());
            return pn;
        }
        public static List<DTO_PhieuNhap> getPNbyNVnDay(string manv, string ngaylap)
        {
            string sQuery = string.Format(@"select p.*, n.*, c.* from PhieuNhap p, NhanVien n, NhaCungCap c where p.manv=n.manv and p.mancc=c.mancc and p.manv='{0}' and p.ngaylap='{1}'", manv, ngaylap);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_PhieuNhap> list_pn = new List<DTO_PhieuNhap>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_PhieuNhap pn = new DTO_PhieuNhap();
                pn.SMaPN = dt.Rows[i]["maphieu"].ToString();
                pn.SMaNV = dt.Rows[i]["manv"].ToString();
                pn.SMaNCC = dt.Rows[i]["mancc"].ToString();
                pn.STenNCC = dt.Rows[i]["tenncc"].ToString();
                pn.DNgayLap = DateTime.Parse(dt.Rows[i]["ngaylap"].ToString());
                pn.FTongTien = float.Parse(dt.Rows[i]["tongtien"].ToString());
                list_pn.Add(pn);
            }
            return list_pn;
        }
    }
}
