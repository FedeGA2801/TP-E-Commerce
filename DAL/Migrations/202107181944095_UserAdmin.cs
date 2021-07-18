namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAdmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuario", "Admin", c => c.Boolean(nullable: false, defaultValue:false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuario", "Admin");
        }
    }
}
