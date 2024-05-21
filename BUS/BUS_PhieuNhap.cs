using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PhieuNhap
    {
        public static List<DTO_PhieuNhap> getPN()
        {
            return DAO_PhieuNhap.getPN();
        }
        public static bool addPN(DTO_PhieuNhap pn)
        {
            return DAO_PhieuNhap.addPN(pn);
        }
        public static bool updatePN(DTO_PhieuNhap pn)
        {
            return DAO_PhieuNhap.updatePN(pn);
        }
        public static bool deletePN(DTO_PhieuNhap pn)
        {
            return DAO_PhieuNhap.deletePN(pn);
        }
        public static DTO_PhieuNhap checkPN(string mapn)
        {
            return DAO_PhieuNhap.checkPN(mapn);
        }
        public static List<DTO_PhieuNhap> getPNbyNVnDay(string manv, string ngay)
        {
            return DAO_PhieuNhap.getPNbyNVnDay(manv, ngay);
        }
    }
}
