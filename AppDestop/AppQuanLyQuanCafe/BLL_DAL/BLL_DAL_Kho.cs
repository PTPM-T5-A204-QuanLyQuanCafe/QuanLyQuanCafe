using BLL_DAL.DTO;
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
         public string TaoMaHangHoa()
         {
             int soHangHoaHienTai = ql.KHOHANGs.Count() + 1;
             string maHangHoaNhapMoi = string.Format("HH{0:D3}", soHangHoaHienTai);
             while (KiemTraKhoaChinhKhoHang(maHangHoaNhapMoi))
             {
                 soHangHoaHienTai++;
                 maHangHoaNhapMoi = string.Format("HH{0:D3}", soHangHoaHienTai);
             }
             return maHangHoaNhapMoi;
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
        public string TenHang(string mahang)
        {
            KHOHANG k = ql.KHOHANGs.Where(t => t.MAHANG == mahang).FirstOrDefault();
            return k.TENHANG;
        }
        public List<HangTon> TimKiemMaHang(string mahang)
        {
            List<HangTon> hang = ql.KHOHANGs.Where(t => t.MAHANG.Contains(mahang))
                .Select(t => new HangTon
                {
                    MAHANG = t.MAHANG,
                    TENHANG = t.TENHANG,
                    SOLUONG = t.SOLUONG
                }).ToList();
            return hang;
        }
        public List<HangTon> TimKiemTenHang(string tenhang)
        {
            List<HangTon> hang = ql.KHOHANGs.Where(t => t.TENHANG.Contains(tenhang))
                .Select(t => new HangTon
                {
                    MAHANG = t.MAHANG,
                    TENHANG = t.TENHANG,
                    SOLUONG = t.SOLUONG
                }).ToList();
            return hang;
        }
        public List<HangTon> TimKiemSoLuongHang(int soluong)
        {
            List<HangTon> hang = ql.KHOHANGs.Where(t => t.SOLUONG <= soluong)
                .Select(t => new HangTon
                {
                    MAHANG = t.MAHANG,
                    TENHANG = t.TENHANG,
                    SOLUONG = t.SOLUONG
                }).ToList();
            return hang;
        }
        public bool KiemTraKhoaChinhKhoHang(string maHang)
        {
            return ql.KHOHANGs.Any(kh => kh.MAHANG == maHang);
        }

        public bool KiemTraKhoaNgoaiKhoHang(string maHang)
        {
            return ql.CHITIETPHEUNHAPs.Any(ct => ct.MAHANG == maHang) || ql.MENUs.Any(m => m.MASP == maHang);
        }
    }
}
