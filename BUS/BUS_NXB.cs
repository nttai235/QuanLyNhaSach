using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NXB
    {
        public static List<DTO_NXB> getNXB()
        {
            return DAO_NXB.getNXB();
        }
        public static bool addNXB(DTO_NXB nxb)
        {
            return DAO_NXB.addNXB(nxb);
        }
        public static bool updateNXB(DTO_NXB nxb)
        {
            return DAO_NXB.updateNXB(nxb);
        }
        public static bool deleteNXB(DTO_NXB nxb)
        {
            return DAO_NXB.deleteNXB(nxb);
        }
        public static DTO_NXB checkID(string id)
        {
            return DAO_NXB.checkID(id);
        }
        public static List<DTO_NXB> searchNXB(string ten)
        {
            return DAO_NXB.searchNXB(ten);
        }
    }
}
