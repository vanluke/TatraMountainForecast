namespace Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Y : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ApplicationUsers", newName: "Users");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Users", newName: "ApplicationUsers");
        }
    }
}
