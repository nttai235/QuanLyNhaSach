using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Sach
    {
        public static List<DTO_Sach> getSach()
        {
            return DAO_Sach.getSach();
        }
        public static List<DTO_Sach> getSachLonHonKhong()
        {
            return DAO_Sach.getSachLonHonKhong();
        }
        public static DTO_Sach checkID(string sachID)
        {
            return DAO_Sach.checkID(sachID);
        }
        public static List<DTO_Sach> searchSach(string ten)
        {
            return DAO_Sach.searchSach(ten);
        }
        public static bool addSach(DTO_Sach s)
        {
            return DAO_Sach.addSach(s);
        }
        public static bool deleteSach(DTO_Sach s)
        {
            return DAO_Sach.deleteSach(s);
        }
        public static bool updateSach(DTO_Sach s)
        {
            return DAO_Sach.updateSach(s);
        }
        public static bool updateSLSach(DTO_Sach s, int sl)
        {
            return DAO_Sach.updateSLSach(s, sl);
        }
    }
}
