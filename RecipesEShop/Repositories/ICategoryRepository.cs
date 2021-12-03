using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesEShop.Models;

namespace RecipesEShop.Repositories
{
    interface ICategoryRepository
    {
        ICollection<Category> GetAll();
        Category GetById(string Id); // Find()
        //Category Find(DateTime CreationDate);
        int Insert(Category category);
        int InsertMany(ICollection<Category> Categories);
        /*Fruits, Fruits products
         1. Find 'Fruits', change description to 'Fruit Products like apple, oranges'
         2. Find 'Fruits', change 'Fruits' to 'Super Fruits'
         3. Find 'Fruits', change 'Fruits to Super Fruits' and description to 'Super Fruits products...'
        */
        int Update(Category category);
        int Delete(string Id);
    }
}
