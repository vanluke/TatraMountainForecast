namespace Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class X : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ApplicationRoles", newName: "Roles");
            RenameTable(name: "dbo.ApplicationUserRoles", newName: "UserRoles");
            RenameTable(name: "dbo.ApplicationUserClaims", newName: "UserClaims");
            RenameTable(name: "dbo.ApplicationUserLogins", newName: "Logins");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Logins", newName: "ApplicationUserLogins");
            RenameTable(name: "dbo.UserClaims", newName: "ApplicationUserClaims");
            RenameTable(name: "dbo.UserRoles", newName: "ApplicationUserRoles");
            RenameTable(name: "dbo.Roles", newName: "ApplicationRoles");
        }
    }
}
