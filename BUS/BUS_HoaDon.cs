using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HoaDon
    {
        public static List<DTO_HoaDon> getHD()
        {
            return DAO_HoaDon.getHD();
        }
        public static bool addHD(DTO_HoaDon hd)
        {
            return DAO_HoaDon.addHD(hd);
        }
        public static bool updateHD(DTO_HoaDon hd)
        {
            return DAO_HoaDon.updateHD(hd);
        }
        public static bool deleteHD(DTO_HoaDon hd)
        {
            return DAO_HoaDon.deleteHD(hd);
        }
        public static DTO_HoaDon checkHD(string mahd)
        {
            return DAO_HoaDon.checkHD(mahd);
        }
    }
}
