namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregoTotalCarrito : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cart", "TotalPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cart", "TotalPrice");
        }
    }
}
