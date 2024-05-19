using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChucVu
    {
        public static List<DTO_ChucVu> getChucVu()
        {
            return DAO_ChucVu.getChucVu();
        }
    }
}
