namespace Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WeatherTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WeatherContainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        All = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Weathers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Weathers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.WeatherContainers");
        }
    }
}
