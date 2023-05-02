namespace ProductManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_foreignkey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CategoryId_CategoryId", c => c.Int());
            AlterColumn("dbo.Categories", "CategoryId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Products", "ProductId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Categories");
            AddPrimaryKey("dbo.Categories", "CategoryId");
            DropPrimaryKey("dbo.Products");
            AddPrimaryKey("dbo.Products", "ProductId");
            CreateIndex("dbo.Products", "CategoryId_CategoryId");
            AddForeignKey("dbo.Products", "CategoryId_CategoryId", "dbo.Categories", "CategoryId");
            DropColumn("dbo.Products", "CategoryID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CategoryID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Products", "CategoryId_CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId_CategoryId" });
            DropPrimaryKey("dbo.Products");
            AddPrimaryKey("dbo.Products", "ProductID");
            DropPrimaryKey("dbo.Categories");
            AddPrimaryKey("dbo.Categories", "CategoryID");
            AlterColumn("dbo.Products", "ProductId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Categories", "CategoryId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Products", "CategoryId_CategoryId");
        }
    }
}
