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
    public class DAO_NhaCungCap
    {
        static SqlConnection conn;
        public static List<DTO_NhaCungCap> getNhaCungCap()
        {
            string sQuery = "select * from NhaCungCap";
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_NhaCungCap> list_NCC = new List<DTO_NhaCungCap>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_NhaCungCap ncc = new DTO_NhaCungCap();
                ncc.SMaNCC = dt.Rows[i]["mancc"].ToString();
                ncc.STenNCC = dt.Rows[i]["tenncc"].ToString();
                ncc.SDiaChi = dt.Rows[i]["diachi"].ToString();
                ncc.SSDT = dt.Rows[i]["sdt"].ToString();
                list_NCC.Add(ncc);
            }
            return list_NCC;
        }
        public static bool addNhaCungCap(DTO_NhaCungCap ncc)
        {
            string sQuery = string.Format(@"insert into NhaCungCap values('{0}', N'{1}', N'{2}', '{3}')", ncc.SMaNCC, ncc.STenNCC, ncc.SDiaChi, ncc.SSDT);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool updateNhaCungCap(DTO_NhaCungCap ncc)
        {
            string sQuery = string.Format(@"update NhaCungCap set tenncc=N'{0}', diachi=N'{1}', sdt='{2}' where mancc='{3}'", ncc.STenNCC, ncc.SDiaChi, ncc.SSDT, ncc.SMaNCC);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool deleteNhaCungCap(DTO_NhaCungCap ncc)
        {
            string sQuery = string.Format(@"delete from NhaCungCap where mancc='{0}'", ncc.SMaNCC);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static DTO_NhaCungCap checkID(string id)
        {
            string sQuery = string.Format(@"select * from NhaCungCap where mancc = '{0}'", id);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_NhaCungCap ncc = new DTO_NhaCungCap();
            ncc.SMaNCC = dt.Rows[0]["mancc"].ToString();
            ncc.STenNCC = dt.Rows[0]["tenncc"].ToString();
            ncc.SDiaChi = dt.Rows[0]["diachi"].ToString();
            ncc.SSDT = dt.Rows[0]["sdt"].ToString();

            DataProvider.closeConn(conn);
            return ncc;
        }
        public static List<DTO_NhaCungCap> searchNCC(string ten)
        {
            string sQuery = string.Format(@"select * from NhaCungCap where tenncc like '%{0}%'", ten);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_NhaCungCap> list_NCC = new List<DTO_NhaCungCap>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_NhaCungCap ncc = new DTO_NhaCungCap();
                ncc.SMaNCC = dt.Rows[i]["mancc"].ToString();
                ncc.STenNCC = dt.Rows[i]["tenncc"].ToString();
                ncc.SDiaChi = dt.Rows[i]["diachi"].ToString();
                ncc.SSDT = dt.Rows[i]["sdt"].ToString();
                list_NCC.Add(ncc);
            }
            DataProvider.closeConn(conn);
            return list_NCC;
        }
    }
}
