namespace ProductManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pro_app : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                {
                    CategoryID = c.Int(nullable: false, identity: true),
                    CategoryName = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.CategoryID);



            CreateTable(
                "dbo.Products",
                c => new
                {
                    ProductID = c.Int(nullable: false, identity: true),
                    ProductName = c.String(nullable: false, maxLength: 50),
                    ProductPrice = c.Int(nullable: false),
                    CategoryID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ProductID);
                


        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
