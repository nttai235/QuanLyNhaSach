using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        public static SqlConnection openConn()
        {
            string sConn = @"Data Source = NTTAI\NTTAI; Initial Catalog = QLNhaSach; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sConn);
            conn.Open();
            return conn;
        }

        public static SqlConnection closeConn(SqlConnection conn)
        {
            conn.Close();
            return conn;
        }

        public static DataTable retrieveData(string sQuery, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(sQuery, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool retrieveNonData(string sQuery, SqlConnection conn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sQuery, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
