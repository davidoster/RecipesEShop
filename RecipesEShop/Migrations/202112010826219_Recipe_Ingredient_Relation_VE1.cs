namespace RecipesEShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Recipe_Ingredient_Relation_VE1 : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Recipes",
            //    c => new
            //        {
            //            Name = c.String(nullable: false, maxLength: 128),
            //            Description = c.String(),
            //        })
            //    .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.Recipes");
        }
    }
}
