using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChucVu
    {
        private string sMaCV;
        private string sTenCV;
        public string SMaCV {  get { return sMaCV; } set { sMaCV = value;} }
        public string STenCV { get { return sTenCV; } set { sTenCV = value;} }
    }
}
