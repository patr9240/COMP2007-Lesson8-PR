﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_Lesson8_PR.Controllers
{
    public class HomeController : Controller
    {

        //GET: /Home/Index or /
        public ActionResult Index()
        {
            return View();
        }

        //GET: /Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //GET: /Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}