using RecipesEShop.Models;
using RecipesEShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecipesEShop.Controllers
{
    public class Categories2Controller:Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            ViewBag.Title = "Categories2";
            ViewBag.Koukou = new Category() { Name = "AAAA" };
            ViewBag.KoukouNumber = 24;
            ViewBag.Koukou = 1;
            ViewData.Add("staticCategory", new Category() { Name="AAAA" });
            ViewBag.CategoriesCount = db.Categories.Count();
            return View(db.Categories.ToList());
        }

        public ViewResult Delete(string Id)
        {
            CategoryRepository repository = new CategoryRepository();
            int result = repository.Delete(Id);
            return View("Index");
        }
    }
}