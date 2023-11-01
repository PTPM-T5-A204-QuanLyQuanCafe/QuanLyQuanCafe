using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebQuanLyQuanCafe.Models;

namespace WebQuanLyQuanCafe.Controllers
{
    public class TaiKhoanController : Controller
    {
        DB_CAFFEDataContext data = new DB_CAFFEDataContext();
        // GET: TaiKhoan
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Sign_in()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sign_in(FormCollection collection)
        {
            var email = collection["email"];
            var matkhau = collection["password"];
            if (string.IsNullOrEmpty(email))
            {
                ViewData["Loi1"] = "Phải nhập email";
            }
            else if (string.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Phải nhập mật khẩu";
            }
            else
            {
                KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(n => n.EMAIL == email && n.PASSKH == matkhau);
                if (kh != null)
                {
                    ViewBag.LoginSuccess= "Login success";
                    ViewBag.thongbao = "Đăng nhập thành công";
                    Session["Taikhoan"] = kh;
                    Session["Ten"] = kh.HOTEN;
                    return RedirectToAction("HienThiMenu","Home");
                }
                else
                    ViewBag.thongbao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            return View();
         
        }
       
        public ActionResult Log_out()
        {
            Session["Taikhoan"] = null;
            return RedirectToAction("Sign_in");
        }
        [HttpGet]
        public ActionResult Sign_up()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Sign_up(string email,string name,string phone,string password,string province,string district, string ward)
        {
            try
            {

                string diachi = province + "-" + district + "-" + ward;
                KHACHHANG kh = new KHACHHANG();
                kh.EMAIL = email;
                kh.HOTEN = name;
                kh.PASSKH = password;
                kh.DIACHI = "Bình Định";
                kh.SDTKH = phone;

                Console.WriteLine(diachi + "-" + name + "-" + email + "-" + password+phone);
             
                data.KHACHHANGs.InsertOnSubmit(kh);
                data.SubmitChanges();
                Session["TrangThaiDK"] = "1";

            }
            catch
            {
             
                return this.Sign_up();
            }
            return RedirectToAction("Sign_in");

        }
      
    }
}