namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArregloModelos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderedProduct", "CustomerOrder_Id", "dbo.CustomerOrder");
            DropForeignKey("dbo.Cart", "ProductId", "dbo.Product");
            DropIndex("dbo.Cart", new[] { "ProductId" });
            DropIndex("dbo.OrderedProduct", new[] { "CustomerOrder_Id" });
            AddColumn("dbo.Cart", "CustomerData_Id", c => c.Int());
            AddColumn("dbo.OrderedProduct", "Cart_Id", c => c.Int());
            CreateIndex("dbo.Cart", "CustomerData_Id");
            CreateIndex("dbo.OrderedProduct", "Cart_Id");
            AddForeignKey("dbo.Cart", "CustomerData_Id", "dbo.CustomerOrder", "Id");
            AddForeignKey("dbo.OrderedProduct", "Cart_Id", "dbo.Cart", "Id");
            DropColumn("dbo.Cart", "ProductId");
            DropColumn("dbo.Cart", "Count");
            DropColumn("dbo.OrderedProduct", "CustomerOrder_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderedProduct", "CustomerOrder_Id", c => c.Int());
            AddColumn("dbo.Cart", "Count", c => c.Int(nullable: false));
            AddColumn("dbo.Cart", "ProductId", c => c.Int(nullable: false));
            DropForeignKey("dbo.OrderedProduct", "Cart_Id", "dbo.Cart");
            DropForeignKey("dbo.Cart", "CustomerData_Id", "dbo.CustomerOrder");
            DropIndex("dbo.OrderedProduct", new[] { "Cart_Id" });
            DropIndex("dbo.Cart", new[] { "CustomerData_Id" });
            DropColumn("dbo.OrderedProduct", "Cart_Id");
            DropColumn("dbo.Cart", "CustomerData_Id");
            CreateIndex("dbo.OrderedProduct", "CustomerOrder_Id");
            CreateIndex("dbo.Cart", "ProductId");
            AddForeignKey("dbo.Cart", "ProductId", "dbo.Product", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OrderedProduct", "CustomerOrder_Id", "dbo.CustomerOrder", "Id");
        }
    }
}
