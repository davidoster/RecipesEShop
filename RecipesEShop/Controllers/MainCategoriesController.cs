using RecipesEShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecipesEShop.Controllers
{
    public class MainCategoriesController: Controller
    {
        public ActionResult Index()
        {
            if(!Request.IsAuthenticated) return RedirectToAction("PublicCategories");
            return RedirectToAction("PrivateCategories");
        }

        public ViewResult PublicCategories()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return View(db.Categories.ToList());
        }

        public ActionResult PrivateCategories()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            if (!Request.IsAuthenticated) return RedirectToAction("PublicCategories");
            else
                return View(db.Categories.ToList());
        }

        public ActionResult New()
        {
            Category c = new Category() { Name = "AAAA", Description = "AAAA" };
            return View(c);
        }

        public bool CheckCategoryExistence(string category)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var result = db.Categories.Where(item => item.Name == category).FirstOrDefault();
            if(result != null)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}