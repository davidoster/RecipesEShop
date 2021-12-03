using RecipesEShop.Models;
using RecipesEShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        // GET: Categories/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryRepository repository = new CategoryRepository();
            if (repository.Delete(id) == 0)
            {

                return View("DefaultIndex");
            }
            //Category category = db.Categories.Find(id);
            //if (category == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(category);
            return View();
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            //Category category = db.Categories.Find(id);
            //db.Categories.Remove(category);
            //db.SaveChanges();
            //CategoryRepository repository = new CategoryRepository();
            //repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}