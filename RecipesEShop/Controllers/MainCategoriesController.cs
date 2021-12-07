using RecipesEShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecipesEShop.Controllers
{
    public class MainCategoriesController : Controller
    {
        public ActionResult Index()
        {
            if (!Request.IsAuthenticated) return RedirectToAction("PublicCategories");
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

        [HttpPost]
        public ActionResult New(Category c)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Categories.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public bool CheckCategoryExistence(string category)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var result = db.Categories.Where(item => item.Name == category).FirstOrDefault();
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ActionResult Delete(string key)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var c = db.Categories.Find(key);
            db.Categories.Remove(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Edit - Update
        public ViewResult Edit(string key)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var c = db.Categories.Find(key);
            return View(c);
        }

        [HttpPost]
        public ActionResult Edit(CategoryDTO c)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var targetCategory = db.Categories.Find(c.oldId);
            //targetCategory.Name = c.Name; --- DO NOT CHANGE THE PK or you will DIE!!!!
            targetCategory.Description = c.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}