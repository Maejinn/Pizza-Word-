using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using _20DTH1A_LT_WEB_BaiThuHoach_ThaiThanhDat_2000004681.Models;
namespace test2.Areas.PivatePages.Controllers
{
    public class ThongKeController : Controller
    {
        // GET: PivatePages/ThongKe
        public ActionResult Index()
        {
            TaiKhoan x = (TaiKhoan) Session["TtDangNhap"];
            if (x == null)
                Response.Redirect("~/login");
            return View();
        }
    }
}