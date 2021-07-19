namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImagenCategoria : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "ProductImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Category", "ProductImage");
        }
    }
}
