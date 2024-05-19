using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhaCungCap
    {
        public static List<DTO_NhaCungCap> getNhaCungCap()
        {
            return DAO_NhaCungCap.getNhaCungCap();
        }
        public static bool addNhaCungCap(DTO_NhaCungCap ncc)
        {
            return DAO_NhaCungCap.addNhaCungCap(ncc);
        }
        public static bool updateNhaCungCap(DTO_NhaCungCap ncc)
        {
            return DAO_NhaCungCap.updateNhaCungCap(ncc);
        }
        public static bool deleteNhaCungCap(DTO_NhaCungCap ncc)
        {
            return DAO_NhaCungCap.deleteNhaCungCap(ncc);
        }
        public static DTO_NhaCungCap checkID(string id)
        {
            return DAO_NhaCungCap.checkID(id);
        }
        public static List<DTO_NhaCungCap> searchNCC(string ten)
        {
            return DAO_NhaCungCap.searchNCC(ten);
        }
    }
}
