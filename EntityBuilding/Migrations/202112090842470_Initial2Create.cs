namespace EntityBuilding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Description = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Description = c.String(nullable: false, maxLength: 150),
                        CategoryName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Name)
                .ForeignKey("dbo.Categories", t => t.CategoryName)
                .Index(t => t.CategoryName);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.RecipeIngredients",
                c => new
                    {
                        Recipe_Name = c.String(nullable: false, maxLength: 128),
                        Ingredient_Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Recipe_Name, t.Ingredient_Name })
                .ForeignKey("dbo.Recipes", t => t.Recipe_Name, cascadeDelete: true)
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_Name, cascadeDelete: true)
                .Index(t => t.Recipe_Name)
                .Index(t => t.Ingredient_Name);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RecipeIngredients", "Ingredient_Name", "dbo.Ingredients");
            DropForeignKey("dbo.RecipeIngredients", "Recipe_Name", "dbo.Recipes");
            DropForeignKey("dbo.Ingredients", "CategoryName", "dbo.Categories");
            DropIndex("dbo.RecipeIngredients", new[] { "Ingredient_Name" });
            DropIndex("dbo.RecipeIngredients", new[] { "Recipe_Name" });
            DropIndex("dbo.Ingredients", new[] { "CategoryName" });
            DropTable("dbo.RecipeIngredients");
            DropTable("dbo.Recipes");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Categories");
        }
    }
}
