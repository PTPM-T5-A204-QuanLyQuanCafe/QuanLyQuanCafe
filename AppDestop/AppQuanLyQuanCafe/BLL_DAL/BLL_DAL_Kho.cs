using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_Kho
    {
         QL_COFFEDataContext ql = new QL_COFFEDataContext();
         public BLL_DAL_Kho()
        {

        }
        public List<KHOHANG> loadDataKhoHang()
        {
            List<KHOHANG> lst = ql.KHOHANGs.Select(t => t).ToList();
            return lst;
        }
        public void themKhoHang(KHOHANG k)
        {
            ql.KHOHANGs.InsertOnSubmit(k);
            ql.SubmitChanges();
        }
        public void xoaKhoHang(string mahang)
        {
            KHOHANG k = ql.KHOHANGs.Where(t => t.MAHANG == mahang).FirstOrDefault();
            ql.KHOHANGs.DeleteOnSubmit(k);
            ql.SubmitChanges();
        }
        public void suaKhoHang(string mahang, KHOHANG k)
        {
            KHOHANG hang = ql.KHOHANGs.Where(t => t.MAHANG == mahang).FirstOrDefault();
            hang.TENHANG = k.TENHANG;
            hang.DVT = k.DVT;
            hang.GIA = k.GIA;
            hang.SOLUONG = k.SOLUONG;
            hang.TINHTRANG = k.TINHTRANG;
            ql.SubmitChanges();
        }

    }
}
