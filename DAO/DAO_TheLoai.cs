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
    public class DAO_TheLoai
    {
        static SqlConnection conn;
        public static List<DTO_TheLoai> getTheLoai()
        {
            string sQuery = "select * from TheLoai";
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_TheLoai> list_TL = new List<DTO_TheLoai>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_TheLoai tl = new DTO_TheLoai();
                tl.SMaTheLoai = dt.Rows[i]["matheloai"].ToString();
                tl.STenTheLoai = dt.Rows[i]["tentheloai"].ToString();
                list_TL.Add(tl);
            }
            return list_TL;
        }
        public static bool addTheLoai(DTO_TheLoai tl)
        {
            string sQuery = string.Format(@"insert into TheLoai values('{0}', N'{1}')", tl.SMaTheLoai, tl.STenTheLoai);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool updateTheLoai(DTO_TheLoai tl)
        {
            string sQuery = string.Format(@"update TheLoai set tentheloai=N'{0}' where matheloai='{1}'", tl.STenTheLoai, tl.SMaTheLoai);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static bool deleteTheLoai(DTO_TheLoai tl)
        {
            string sQuery = string.Format(@"delete from TheLoai where matheloai='{0}'", tl.SMaTheLoai);
            conn = DataProvider.openConn();
            bool kq = DataProvider.retrieveNonData(sQuery, conn);
            DataProvider.closeConn(conn);
            return kq;
        }
        public static DTO_TheLoai checkID(string id)
        {
            string sQuery = string.Format(@"select * from TheLoai where matheloai = '{0}'", id);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_TheLoai tl = new DTO_TheLoai();
            tl.SMaTheLoai = dt.Rows[0]["matheloai"].ToString();
            tl.STenTheLoai = dt.Rows[0]["tentheloai"].ToString();

            DataProvider.closeConn(conn);
            return tl;
        }
        public static List<DTO_TheLoai> searchTheLoai(string ten)
        {
            string sQuery = string.Format(@"select * from TheLoai where tentheloai like '%{0}%'", ten);
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_TheLoai> list_tl = new List<DTO_TheLoai>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_TheLoai tl = new DTO_TheLoai();
                tl.SMaTheLoai = dt.Rows[i]["matheloai"].ToString();
                tl.STenTheLoai = dt.Rows[i]["tentheloai"].ToString();
                list_tl.Add(tl);
            }
            DataProvider.closeConn(conn);
            return list_tl;
        }
    }
}
