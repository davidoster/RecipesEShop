namespace RecipesEShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoriesVE5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Description", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Description", c => c.String(nullable: false, maxLength: 250));
        }
    }
}
