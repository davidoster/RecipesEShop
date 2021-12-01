namespace RecipesEShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FullMigrationVE1 : DbMigration
    {
        public override void Up()
        {
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
            
            DropColumn("dbo.Ingredients", "RecipeName");
            DropColumn("dbo.Recipes", "IngredientName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Recipes", "IngredientName", c => c.String());
            AddColumn("dbo.Ingredients", "RecipeName", c => c.String());
            DropForeignKey("dbo.RecipeIngredients", "Ingredient_Name", "dbo.Ingredients");
            DropForeignKey("dbo.RecipeIngredients", "Recipe_Name", "dbo.Recipes");
            DropIndex("dbo.RecipeIngredients", new[] { "Ingredient_Name" });
            DropIndex("dbo.RecipeIngredients", new[] { "Recipe_Name" });
            DropTable("dbo.RecipeIngredients");
        }
    }
}
