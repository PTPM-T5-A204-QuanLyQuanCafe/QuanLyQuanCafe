using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebQuanLyQuanCafe.Models;

namespace WebQuanLyQuanCafe.Controllers
{
    public class OrderController : Controller
    {
        DB_CAFFEDataContext data = new DB_CAFFEDataContext();
        // GET: Order
        [HttpGet]
        public ActionResult Order_Table()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Order_Table(string gioden,string songuoi)
        {
            DateTime GioDen = DateTime.Parse(gioden);
            int SoNguoi = int.Parse(songuoi);
            if (Session["Taikhoan"] == null)
            {
                ViewBag.thongbao = "You are not logged in";
                return RedirectToAction("Sign_in", "TaiKhoan");
            }
            else
            {
                List<DonDat> lstGH = layDonDat();
                KHACHHANG kh = (KHACHHANG)Session["Taikhoan"];
                DonDat sp = lstGH.Find(n => n.Sdt==kh.SDTKH);
                if (sp == null)
                {
                    sp = new DonDat(kh.SDTKH,GioDen,SoNguoi);
                    lstGH.Add(sp);
                    return RedirectToAction("HienThiMenu", "Home");
                }
                else
                {
                    return RedirectToAction("HienThiMenu", "Home");
                }
            }

            return RedirectToAction("HienThiMenu", "Home");
        }
        public List<DonDat> layDonDat()
        {
            List<DonDat> lstGH = Session["DonDat"] as List<DonDat>;
            if (lstGH == null)
            {
                lstGH = new List<DonDat>();
                Session["DonDat"] = lstGH;
            }
            return lstGH;
        }
       
        public ActionResult DS_DonDat()
        {
            List<DonDat> lstGH = layDonDat();
            if (lstGH.Count == 0)
            {
                ViewBag.thongbao = "0";
            }

            return View(lstGH);
            
        }
        public ActionResult XacNhan()
        {
            PHIEUDATBAN ddh = new PHIEUDATBAN();
            KHACHHANG kh = (KHACHHANG)Session["Taikhoan"];
            List<DonDat> gh = layDonDat();
            foreach(var item in gh)
            {
                ddh.MAPHIEUDAT = item.Maphieudat;
                ddh.SDTKH =item.Sdt;
                ddh.NGAYLAP = item.Ngaylap;
                ddh.GIODEN = item.Gioden;
                ddh.SONGUOI = item.Songuoi;
                ddh.TINHTRANG = "Chờ duyệt";
                data.PHIEUDATBANs.InsertOnSubmit(ddh);
                data.SubmitChanges();

            }    
          
            Session["DonDat"] = null;
            return RedirectToAction("DS_DonDat");
         
         
        }
        public ActionResult DS_LSDat()
        {
            if (Session["Taikhoan"] != null)
            {
                KHACHHANG kh = (KHACHHANG)Session["Taikhoan"];
                var ds = from item in data.PHIEUDATBANs where item.SDTKH == kh.SDTKH select item;
                return View(ds.ToList());
            }
            else
            {
                return RedirectToAction("HienThiMenu", "Home");
            }
        }
    }
}