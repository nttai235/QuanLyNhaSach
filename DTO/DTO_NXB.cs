using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NXB
    {
        private string sMaNXB;
        private string sTenNXB;
        private string sDiaChi;
        private string sSDT;
        public string SMaNXB {  get { return sMaNXB; } set { sMaNXB = value; } }
        public string STenNXB { get {  return sTenNXB; } set { sTenNXB = value; } }
        public string SDiaChi { get { return sDiaChi; } set { sDiaChi = value; } }
        public string SSDT { get {  return sSDT; } set { sSDT = value; } }
    }
}
