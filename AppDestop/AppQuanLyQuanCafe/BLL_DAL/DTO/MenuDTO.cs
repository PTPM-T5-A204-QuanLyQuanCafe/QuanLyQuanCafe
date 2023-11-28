using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL.DTO
{
    public class MenuDTO
    {
        private string _MASP;

        public string MASP
        {
            get { return _MASP; }
            set { _MASP = value; }
        }

        private string _TENLOAI;

        public string TENLOAI
        {
            get { return _TENLOAI; }
            set { _TENLOAI = value; }
        }

        private string _TENSP;

        public string TENSP
        {
            get { return _TENSP; }
            set { _TENSP = value; }
        }

        private System.Nullable<int> _SOLUONG;

        public System.Nullable<int> SOLUONG
        {
            get { return _SOLUONG; }
            set { _SOLUONG = value; }
        }

        private string _DVT;

        public string DVT
        {
            get { return _DVT; }
            set { _DVT = value; }
        }

        private System.Nullable<double> _GIA;

        public System.Nullable<double> GIA
        {
            get { return _GIA; }
            set { _GIA = value; }
        }

        private string _ANH;

        public string ANH
        {
            get { return _ANH; }
            set { _ANH = value; }
        }

        private string _TINHTRANG;

        public string TINHTRANG
        {
            get { return _TINHTRANG; }
            set { _TINHTRANG = value; }
        }
		
    }
}
