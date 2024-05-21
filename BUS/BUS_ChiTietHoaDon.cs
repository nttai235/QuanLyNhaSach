using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietHoaDon
    {
        public static List<DTO_ChiTietHoaDon> getListCTHD(string mahd)
        {
            return DAO_ChiTietHoaDon.getListCTHD(mahd);
        }
        public static bool addCTHD(DTO_ChiTietHoaDon ct)
        {
            return DAO_ChiTietHoaDon.addCTHD(ct);
        }
        public static bool updateCTHDsl(DTO_ChiTietHoaDon ct, int sl)
        {
            return DAO_ChiTietHoaDon.updateCTHDsl(ct, sl);
        }
        public static bool updateCTHDtt(DTO_ChiTietHoaDon ct, float tt)
        {
            return DAO_ChiTietHoaDon.updateCTHDtt(ct, tt);
        }
        public static bool deleteCTHD(DTO_ChiTietHoaDon ct)
        {
            return DAO_ChiTietHoaDon.deleteCTHD(ct);
        }
        public static DTO_ChiTietHoaDon getCTHD(string idHD, string idSach)
        {
            return DAO_ChiTietHoaDon.getCTHD(idHD, idSach);
        }
    }
}
