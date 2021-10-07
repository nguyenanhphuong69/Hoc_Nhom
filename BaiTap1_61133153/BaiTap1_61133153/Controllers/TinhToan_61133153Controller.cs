﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap1_61133153.Models;

namespace BaiTap1_61133153.Controllers
{
    public class TinhToan_61133153Controller : Controller
    {
        // GET: TinhToan_61133153
        public ActionResult UseRequest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseRequest(string pt)
        {
            double a = double.Parse(Request["a"]);//Chuyển đổi chuỗi sang số thực
            double b = double.Parse(Request["b"]);
            pt = Request["pt"].ToString();
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = a / b; break;
            }
            return View();
        }
        public ActionResult UseModel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseModel(PTModel cal)
        {
            switch (cal.pt)
                {
                    case "+": ViewBag.KQ = cal.a + cal.b; break;
                    case "-": ViewBag.KQ = cal.a - cal.b; break;
                    case "*": ViewBag.KQ = cal.a* cal.b; break;
                    case "/":
                        if (cal.b == 0) ViewBag.KQ = "Không chia được cho 0";
                            else ViewBag.KQ = cal.a / cal.b; break;
                }
            return View();
         }

    }
}