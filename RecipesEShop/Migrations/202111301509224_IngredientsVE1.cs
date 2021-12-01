namespace RecipesEShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IngredientsVE1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Description = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ingredients");
        }
    }
}
