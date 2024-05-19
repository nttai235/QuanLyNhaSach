using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_ChucVu
    {
        static SqlConnection conn;
        public static List<DTO_ChucVu> getChucVu()
        {
            string sQuery = "select * from ChucVu";
            conn = DataProvider.openConn();
            DataTable dt = DataProvider.retrieveData(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_ChucVu> list_CV = new List<DTO_ChucVu>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_ChucVu cv = new DTO_ChucVu();
                cv.SMaCV = dt.Rows[i]["macv"].ToString();
                cv.STenCV = dt.Rows[i]["tencv"].ToString();
                list_CV.Add(cv);
            }
            return list_CV;
        }
    }
}
