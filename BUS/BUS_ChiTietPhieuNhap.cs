using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietPhieuNhap
    {
        public static List<DTO_ChiTietPhieuNhap> getListCTPN(string mapn)
        {
            return DAO_ChiTietPhieuNhap.getListCTPN(mapn);
        }
        public static bool addCTPN(DTO_ChiTietPhieuNhap ct)
        {
            return DAO_ChiTietPhieuNhap.addCTPN(ct);
        }
        public static bool updateCTPNsl(DTO_ChiTietPhieuNhap ct, int sl)
        {
            return DAO_ChiTietPhieuNhap.updateCTPNsl(ct, sl);
        }
        public static bool updateCTPNtt(DTO_ChiTietPhieuNhap ct, float tt)
        {
            return DAO_ChiTietPhieuNhap.updateCTPNtt(ct, tt);
        }
        public static bool deleteCTPN(DTO_ChiTietPhieuNhap ct)
        {
            return DAO_ChiTietPhieuNhap.deleteCTPN(ct);
        }
        public static DTO_ChiTietPhieuNhap getCTPN(string idPN, string idSach)
        {
            return DAO_ChiTietPhieuNhap.getCTPN(idPN, idSach);
        }
    }
}
