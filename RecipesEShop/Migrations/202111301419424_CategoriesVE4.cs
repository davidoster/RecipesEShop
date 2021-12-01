namespace RecipesEShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoriesVE4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Description", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Description", c => c.String(maxLength: 250));
        }
    }
}
