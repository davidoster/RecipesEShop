﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityBuilding.Models;

namespace RecipesEShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Category c = new Category();
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
    }
}