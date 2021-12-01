namespace RecipesEShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoriesVE : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
