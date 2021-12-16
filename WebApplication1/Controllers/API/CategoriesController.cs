using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using EntityBuilding.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using WebApplication1.Models;

namespace WebApplication1.Controllers.API
{
    [Authorize]
    public class CategoriesController : ApiController
    {
        private RecipesModel db = new RecipesModel();

        // GET: api/Categories
        [AllowAnonymous]
        public IEnumerable<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        [AllowAnonymous]
        public IHttpActionResult OptionsCategory()
        {
            var x = Request.Headers.Authorization.Parameter;
            var credentials = Encoding.Default.GetString(Convert.FromBase64String(x));
            var creds2 = credentials.Split(':');
            return Ok(creds2);
        }

        // GET: api/Categories/5
        [AllowAnonymous]
        [ResponseType(typeof(Category))]
        public IHttpActionResult GetCategory(string id)
        {
            if (Request.Headers.Authorization != null)
            {
                var x = Encoding.Default.GetString(Convert.FromBase64String(Request.Headers.Authorization.Parameter));
                var y = x.Split(':');
                string email = y[0], password = y[1];

                // how can I login here??????????????
                // Make a method that makes a connection to the Db and asks from the table Users..... about the credentials, if they are ok!!!!
                /// Easy Peasy!!!!

                if (CheckUserCredentials(email, password))
                {
                    if (!CategoryExists(id))
                    {
                        return NotFound();
                    }
                    return Ok(db.Categories.Find(id));
                }
            }
            return BadRequest("Invalid credentials and/or non existent category");
        }

        private bool CheckUserCredentials(string username, string password)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            PasswordHasher passwordHasher = new PasswordHasher();
            var hashedPassword = db.Users.Where(u => u.Email == username).Select(u => u.PasswordHash).FirstOrDefault();
            var result = passwordHasher.VerifyHashedPassword(hashedPassword, password);
            return (result == PasswordVerificationResult.Success);
        }

        // PUT: api/Categories/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCategory(string id, Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != category.Name)
            {
                return BadRequest();
            }

            db.Entry(category).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Categories
        [ResponseType(typeof(Category))]
        public IHttpActionResult PostCategory(Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Categories.Add(category);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (CategoryExists(category.Name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = category.Name }, category);
        }

        // DELETE: api/Categories/5
        [ResponseType(typeof(Category))]
        public IHttpActionResult DeleteCategory(string id)
        {

            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }

            db.Categories.Remove(category);
            db.SaveChanges();

            return Ok(category);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CategoryExists(string id)
        {
            return db.Categories.Count(e => e.Name == id) > 0;
        }

        public int Sum(int a, int b)
        {
            return (a + b);
        }
    }
}
