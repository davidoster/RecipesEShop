namespace RecipesEShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Category_Ingredient_Relation_VE1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ingredients", "RecipeName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ingredients", "RecipeName");
        }
    }
}
