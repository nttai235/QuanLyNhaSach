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
    public class DAO_NXB
    {
        static SqlConnection conn;
        public static List<DTO_NXB> getNXB()
        {
            string sQuery = "select * from NXB";
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_NXB> list_NXB = new List<DTO_NXB>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_NXB nxb = new DTO_NXB();
                nxb.SMaNXB = dt.Rows[i]["manxb"].ToString();
                nxb.STenNXB = dt.Rows[i]["tennxb"].ToString();
                nxb.SDiaChi = dt.Rows[i]["diachi"].ToString();
                nxb.SSDT = dt.Rows[i]["sdt"].ToString();
                list_NXB.Add(nxb);
            }
            return list_NXB;
        }
        public static bool addNXB(DTO_NXB nxb)
        {
            string sQuery = string.Format(@"insert into NXB values('{0}', N'{1}', N'{2}', '{3}')", nxb.SMaNXB, nxb.STenNXB, nxb.SDiaChi, nxb.SSDT);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool updateNXB(DTO_NXB nxb)
        {
            string sQuery = string.Format(@"update NXB set tennxb=N'{0}', diachi=N'{1}', sdt='{2}' where manxb='{3}'", nxb.STenNXB, nxb.SDiaChi, nxb.SSDT, nxb.SMaNXB);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool deleteNXB(DTO_NXB nxb)
        {
            string sQuery = string.Format(@"delete from NXB where manxb='{0}'", nxb.SMaNXB);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static DTO_NXB checkID(string id)
        {
            string sQuery = string.Format(@"select * from NXB where manxb = '{0}'", id);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_NXB nxb = new DTO_NXB();
            nxb.SMaNXB = dt.Rows[0]["manxb"].ToString();
            nxb.STenNXB = dt.Rows[0]["tennxb"].ToString();
            nxb.SDiaChi = dt.Rows[0]["diachi"].ToString();
            nxb.SSDT = dt.Rows[0]["sdt"].ToString();

            DataProvider.closeConn(conn);
            return nxb;
        }
        public static List<DTO_NXB> searchNXB(string ten)
        {
            string sQuery = string.Format(@"select * from NXB where tennxb like '%{0}%'", ten);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_NXB> list_NXB = new List<DTO_NXB>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_NXB nxb = new DTO_NXB();
                nxb.SMaNXB = dt.Rows[i]["manxb"].ToString();
                nxb.STenNXB = dt.Rows[i]["tennxb"].ToString();
                nxb.SDiaChi = dt.Rows[i]["diachi"].ToString();
                nxb.SSDT = dt.Rows[i]["sdt"].ToString();
                list_NXB.Add(nxb);
            }
            DataProvider.closeConn(conn);
            return list_NXB;
        }
    }
}
