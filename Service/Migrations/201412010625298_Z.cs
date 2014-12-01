namespace Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Z : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CityPossitions",
                c => new
                    {
                        Location = c.String(nullable: false, maxLength: 128),
                        Latitude = c.String(nullable: false),
                        Longitude = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Location);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CityPossitions");
        }
    }
}
