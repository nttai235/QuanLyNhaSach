using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TheLoai
    {
        public static List<DTO_TheLoai> getTheLoai()
        {
            return DAO_TheLoai.getTheLoai();
        }
        public static bool addTheLoai(DTO_TheLoai tl)
        {
            return DAO_TheLoai.addTheLoai(tl);
        }
        public static bool updateTheLoai(DTO_TheLoai tl)
        {
            return DAO_TheLoai.updateTheLoai(tl);
        }
        public static bool deleteTheLoai(DTO_TheLoai tl)
        {
            return DAO_TheLoai.deleteTheLoai(tl);
        }
        public static DTO_TheLoai checkID(string id)
        {
            return DAO_TheLoai.checkID(id);
        }
        public static List<DTO_TheLoai> searchTheLoai(string ten)
        {
            return DAO_TheLoai.searchTheLoai(ten);
        }
    }
}
