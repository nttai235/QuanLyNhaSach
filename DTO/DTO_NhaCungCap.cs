using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaCungCap
    {
        private string sMaNCC;
        private string sTenNCC;
        private string sDiaChi;
        private string sSDT;
        public string SMaNCC { get { return sMaNCC; } set { sMaNCC = value; } }
        public string STenNCC { get { return sTenNCC; } set { sTenNCC = value; } }
        public string SDiaChi { get { return sDiaChi; } set { sDiaChi = value; } }
        public string SSDT { get { return sSDT; } set { sSDT = value; } }
    }
}
