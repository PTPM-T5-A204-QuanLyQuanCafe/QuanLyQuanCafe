using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebQuanLyQuanCafe.Models;

namespace WebQuanLyQuanCafe.Controllers
{
    public class HomeController : Controller
    {
        DB_CAFFEDataContext data = new DB_CAFFEDataContext();
        public ActionResult HienThiMenu()
        {
            var load = (from item in data.MENUs select item).ToList();
            return View(load);
        }
      
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Blog()
        {
            var ct = from item in data.CONTENTs select item;
            return View(ct.ToList());
        }
    }
}