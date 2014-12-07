namespace Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeClarification : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Weathers");
            AlterColumn("dbo.Weathers", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Weathers", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Weathers");
            AlterColumn("dbo.Weathers", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Weathers", "Id");
        }
    }
}
