using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL.DTO
{
    public class NhanVienDTO
    {
        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        private string _MAQ;

        public string MAQ
        {
            get { return _MAQ; }
            set { _MAQ = value; }
        }

        private string _HOTEN;

        public string HOTEN
        {
            get { return _HOTEN; }
            set { _HOTEN = value; }
        }

        private string _GIOITINH;

        public string GIOITINH
        {
            get { return _GIOITINH; }
            set { _GIOITINH = value; }
        }

        private System.Nullable<System.DateTime> _NGAYSINH;

        public System.Nullable<System.DateTime> NGAYSINH
        {
            get { return _NGAYSINH; }
            set { _NGAYSINH = value; }
        }

        private string _DIACHI;

        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }

        private string _EMAIL;

        public string EMAIL
        {
            get { return _EMAIL; }
            set { _EMAIL = value; }
        }

        private string _PASSNV;

        public string PASSNV
        {
            get { return _PASSNV; }
            set { _PASSNV = value; }
        }

        private string _TINHTRANG;

        public string TINHTRANG
        {
            get { return _TINHTRANG; }
            set { _TINHTRANG = value; }
        }
    }
}
