using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_PhieuNhap
    {
        QL_COFFEDataContext ql = new QL_COFFEDataContext();
        public BLL_DAL_PhieuNhap()
        {

        }
        public string TaoMaPhieuNhap()
        {
            int soPhieuNhapHienTai = ql.PHIEUNHAPs.Count() + 1;
            string maPhieuNhapMoi = string.Format("PN{0:D3}", soPhieuNhapHienTai);
            return maPhieuNhapMoi;
        }
        public List<PHIEUNHAP> loadDataPhieuNhap()
        {
            List<PHIEUNHAP> lst = ql.PHIEUNHAPs.Select(t => t).ToList();
            return lst;
        }
        public void themPhieuNhap(PHIEUNHAP pn)
        {
            ql.PHIEUNHAPs.InsertOnSubmit(pn);
            ql.SubmitChanges();
        }
        public void suaPhieuNhap(string map, PHIEUNHAP p)
        {
            PHIEUNHAP pn = ql.PHIEUNHAPs.Where(t => t.MAPHIEU == map).FirstOrDefault();
            pn.SDT = p.SDT;
            pn.SODIENTHOAINCC = p.SODIENTHOAINCC;
            pn.NGAYLAP = p.NGAYLAP;
            pn.TONGTIEN = p.TONGTIEN;
            pn.TINHTRANG = p.TINHTRANG;
            ql.SubmitChanges();
        }
        public bool KTTonTaiPN(string maphieu)
        {
            return ql.PHIEUNHAPs.Any(t => t.MAPHIEU == maphieu);
        }
        public void luuTongTien(string maphieu, float tongtien)
        {
            PHIEUNHAP pn = ql.PHIEUNHAPs.Where(t => t.MAPHIEU == maphieu).FirstOrDefault();
            pn.TONGTIEN = tongtien;
            ql.SubmitChanges();
        }
    }
}
