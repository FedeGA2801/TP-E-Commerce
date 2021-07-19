namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregoStock : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "AvailableStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "AvailableStock");
        }
    }
}
