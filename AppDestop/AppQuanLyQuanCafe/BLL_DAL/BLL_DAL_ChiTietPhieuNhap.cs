using BLL_DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_ChiTietPhieuNhap
    {
        QL_COFFEDataContext ql = new QL_COFFEDataContext();
        public BLL_DAL_ChiTietPhieuNhap()
        {

        }

        public List<ChiTietPhieuNhapDTO> loadCTPNTheoMa(string maphieu)
        {
            List<ChiTietPhieuNhapDTO> lst = ql.CHITIETPHEUNHAPs.Where(k => k.MAPHIEU == maphieu).Select(t => new ChiTietPhieuNhapDTO
                {
                    MAPHIEU = t.MAPHIEU,
                    MAHANG = t.MAHANG,
                    GIA = t.GIA,
                    SOLUONG = t.SOLUONG
                }).ToList();
            return lst;
        }
        public List<CHITIETPHEUNHAP> loadDataCTPN()
        {
            List<CHITIETPHEUNHAP> lst = ql.CHITIETPHEUNHAPs.Select(t => t).ToList();
            return lst;
        }
        public void themChiTietPhieuNhap(CHITIETPHEUNHAP ct)
        {
            ql.CHITIETPHEUNHAPs.InsertOnSubmit(ct);
            ql.SubmitChanges();
        }
        public void xoaChiTietPhieuNhap(string maphieu,string mahang)
        {
            CHITIETPHEUNHAP ct = ql.CHITIETPHEUNHAPs.Where(t => t.MAPHIEU == maphieu && t.MAHANG == mahang).FirstOrDefault();
            ql.CHITIETPHEUNHAPs.DeleteOnSubmit(ct);
            ql.SubmitChanges();
        }
        public void suaChiTietPhieuNhap(string maphieu, string mahang, CHITIETPHEUNHAP p)
        {
            CHITIETPHEUNHAP ct = ql.CHITIETPHEUNHAPs.Where(t => t.MAPHIEU == maphieu && t.MAHANG == mahang).FirstOrDefault();
            ct.SOLUONG = p.SOLUONG;
            ct.GIA = p.GIA;
            ql.SubmitChanges();
        }
        public bool KTTonTaiCTPN(string maphieu, string mahang)
        {
            CHITIETPHEUNHAP ct = ql.CHITIETPHEUNHAPs.Where(t => t.MAPHIEU == maphieu && t.MAHANG == mahang).FirstOrDefault();
            if (ct != null)
                return true;
            else
                return false;
        }
    }
}
