namespace RecipesEShop.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RecipesEShop.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "RecipesEShop.Models.ApplicationDbContext";
        }

        protected override void Seed(RecipesEShop.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Categories.AddOrUpdate(new Models.Category() { Name = "Dairy", Description = "Dairy Products (milk, yogurt, cheese)" });
            context.Categories.AddOrUpdate(new Models.Category() { Name = "Meat", Description = "Meat Products" });
            context.Categories.AddOrUpdate(new Models.Category() { Name = "Vegetables", Description = "Vegetable Products" });
            context.Categories.AddOrUpdate(new Models.Category() { Name = "Fruits", Description = "Fruits Products" });
        }
    }
}
