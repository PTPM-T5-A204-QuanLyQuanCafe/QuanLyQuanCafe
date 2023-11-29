using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_Ban
    {
        QL_COFFEDataContext ql = new QL_COFFEDataContext();
        public BLL_DAL_Ban()
        {

        }
        public List<BAN> loadDataBan()
        {
            List<BAN> lst = ql.BANs.Select(t => t).ToList();
            return lst;
        }
        public void themBan(BAN b)
        {
            ql.BANs.InsertOnSubmit(b);
            ql.SubmitChanges();
        }
        public void xoaBan(string tenban)
        {
            BAN b = ql.BANs.Where(t => t.TENBAN == tenban).FirstOrDefault();
            ql.BANs.DeleteOnSubmit(b);
            ql.SubmitChanges();
        }
        public void suaBan(string tenban, BAN b)
        {
            BAN ban = ql.BANs.Where(t => t.TENBAN == tenban).FirstOrDefault();
            ban.SLMAX = b.SLMAX;
            ban.TINHTRANG = b.TINHTRANG;
            ql.SubmitChanges();
        }
        public bool KiemTraKhoaChinhBan(string tenBan)
        {
            return ql.BANs.Any(b => b.TENBAN == tenBan);
        }

        public bool KiemTraKhoaNgoaiBan(string tenBan)
        {
            return ql.CHITIETPHIEUDATs.Any(ct => ct.TENBAN == tenBan);
        }
    }
}
