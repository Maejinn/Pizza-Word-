﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Pizza
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}