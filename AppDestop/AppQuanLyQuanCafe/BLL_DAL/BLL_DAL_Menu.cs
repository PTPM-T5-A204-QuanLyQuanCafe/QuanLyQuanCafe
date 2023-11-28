using BLL_DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_Menu
    {
         QL_COFFEDataContext ql = new QL_COFFEDataContext();
         public BLL_DAL_Menu()
        {

        }
        public List<MenuDTO> loadDataMenu()
        {
            List<MenuDTO> lst = ql.MENUs.Select(t => new MenuDTO 
            { 
                MASP = t.MASP,
                TENLOAI = t.TENLOAI,
                TENSP = t.TENSP,
                GIA = t.GIA,
                SOLUONG = t.SOLUONG,
                TINHTRANG = t.TINHTRANG,
                ANH = t.ANH,
                DVT = t.DVT
            }).ToList();
            return lst;
        }
        public List<PHANLOAI> loadDataPhanLoai()
        {
            List<PHANLOAI> lst = ql.PHANLOAIs.Select(t => t).ToList();
            return lst;
        }
        public void themSPMenu(MENU m)
        {
            ql.MENUs.InsertOnSubmit(m);
            ql.SubmitChanges();
        }
        public void xoaSPMenu(string masp)
        {
            MENU m = ql.MENUs.Where(t => t.MASP == masp).FirstOrDefault();
            ql.MENUs.DeleteOnSubmit(m);
            ql.SubmitChanges();
        }
        public void suaSPMenu(string masp, MENU m)
        {
            MENU sp = ql.MENUs.Where(t => t.MASP == masp).FirstOrDefault();
            sp.TENLOAI = m.TENLOAI;
            sp.TENSP = m.TENSP;
            sp.GIA = m.GIA;
            sp.SOLUONG = m.SOLUONG;
            sp.TINHTRANG = m.TINHTRANG;
            sp.ANH = m.ANH;
            sp.DVT = m.DVT;
            ql.SubmitChanges();
        }
    }
}
