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