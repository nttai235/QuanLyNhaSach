using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TheLoai
    {
        private string sMaTheLoai;
        private string sTenTheLoai;
        public string SMaTheLoai {  get { return sMaTheLoai; } set { sMaTheLoai = value;} }
        public string STenTheLoai { get { return sTenTheLoai; } set { sTenTheLoai = value;} }
    }
}
