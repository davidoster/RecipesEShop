using System;
using System.Data.Entity;
using System.Linq;

namespace EntityBuilding.Models
{
    public class RecipesModel : DbContext
    {
        // Your context has been configured to use a 'RecipesModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EntityBuilding.RecipesModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RecipesModel' 
        // connection string in the application configuration file.
        public RecipesModel()
            : base("name=RecipesModel")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public static RecipesModel Create()
        {
            return new RecipesModel();
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}