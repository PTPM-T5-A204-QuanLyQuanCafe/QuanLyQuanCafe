using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL.DTO
{
    public class ChiTietPhieuNhapDTO
    {
        private string _MAPHIEU;

        public string MAPHIEU
        {
            get { return _MAPHIEU; }
            set { _MAPHIEU = value; }
        }

        private string _MAHANG;

        public string MAHANG
        {
            get { return _MAHANG; }
            set { _MAHANG = value; }
        }

        private System.Nullable<double> _GIA;

        public System.Nullable<double> GIA
        {
            get { return _GIA; }
            set { _GIA = value; }
        }

        private System.Nullable<int> _SOLUONG;

        public System.Nullable<int> SOLUONG
        {
            get { return _SOLUONG; }
            set { _SOLUONG = value; }
        }
    }
}
