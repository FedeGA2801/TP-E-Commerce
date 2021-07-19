namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregoCantidadAProducto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "Amount");
        }
    }
}
