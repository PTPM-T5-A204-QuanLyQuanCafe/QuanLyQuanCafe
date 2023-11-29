using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL.DTO
{
    public class HangTon
    {
        private string _MAHANG;

        public string MAHANG
        {
            get { return _MAHANG; }
            set { _MAHANG = value; }
        }

        private string _TENHANG;

        public string TENHANG
        {
            get { return _TENHANG; }
            set { _TENHANG = value; }
        }

        private System.Nullable<int> _SOLUONG;

        public System.Nullable<int> SOLUONG
        {
            get { return _SOLUONG; }
            set { _SOLUONG = value; }
        }
    }
}
