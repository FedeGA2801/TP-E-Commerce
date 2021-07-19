namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrijoOrdered : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderedProduct", "Cart_Id", "dbo.Cart");
            DropIndex("dbo.OrderedProduct", new[] { "Cart_Id" });
            RenameColumn(table: "dbo.OrderedProduct", name: "Cart_Id", newName: "CartID");
            AlterColumn("dbo.OrderedProduct", "CartID", c => c.Int(nullable: false));
            CreateIndex("dbo.OrderedProduct", "CartID");
            AddForeignKey("dbo.OrderedProduct", "CartID", "dbo.Cart", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderedProduct", "CartID", "dbo.Cart");
            DropIndex("dbo.OrderedProduct", new[] { "CartID" });
            AlterColumn("dbo.OrderedProduct", "CartID", c => c.Int());
            RenameColumn(table: "dbo.OrderedProduct", name: "CartID", newName: "Cart_Id");
            CreateIndex("dbo.OrderedProduct", "Cart_Id");
            AddForeignKey("dbo.OrderedProduct", "Cart_Id", "dbo.Cart", "Id");
        }
    }
}
