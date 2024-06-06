using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using _20DTH1A_LT_WEB_BaiThuHoach_ThaiThanhDat_2000004681.Models;

namespace _20DTH1A_LT_WEB_BaiThuHoach_ThaiThanhDat_2000004681.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string tk, string password)
        {
            TaiKhoan ttdn = new PizzaWorldConnect().TaiKhoans.Where(x => x.taiKhoan1.Equals(tk.ToLower().Trim()) && x.matKhau.Equals(password)).First<TaiKhoan>();
            bool dieukien = ttdn !=null && ttdn.taiKhoan1.Equals(tk.ToLower().Trim()) && ttdn.matKhau.Equals(password);
            if (dieukien)
            {
                Session["TtDangNhap"] = ttdn;
                return RedirectToAction("Index", "ThongKe", new { area = "PivatePages" });

            }
            return View();
        }
    }
}