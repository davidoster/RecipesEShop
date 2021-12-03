using RecipesEShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipesEShop.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public int Delete(string Id)
        {
            int result = 0;
            ApplicationDbContext context = new ApplicationDbContext();
            var db = context.Categories;
            var category = db.Find(Id);
            if(category != null)
            {
                db.Remove(category);
                context.SaveChanges();
                result = 1;
            }
            
            return (result);
        }

        public ICollection<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(string Id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Category category)
        {
            throw new NotImplementedException();
        }

        public int InsertMany(ICollection<Category> Categories)
        {
            throw new NotImplementedException();
        }

        public int Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}