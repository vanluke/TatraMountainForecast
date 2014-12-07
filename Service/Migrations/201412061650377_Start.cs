namespace Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Start : DbMigration
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
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        RoleId = c.Int(nullable: false),
                        ApplicationRole_Id = c.Int(),
                        ApplicationUser_Id = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Roles", t => t.ApplicationRole_Id)
                .ForeignKey("dbo.Users", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.UserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        UserId = c.Int(nullable: false),
                        ApplicationUser_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ProviderKey)
                .ForeignKey("dbo.Users", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hometown = c.String(),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Weathers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CurrentWeathers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Humidity = c.String(),
                        Pressure = c.String(),
                        Temperature = c.String(),
                        TemperatureUnit = c.String(),
                        Code = c.String(),
                        Comments = c.String(),
                        Weather_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Weathers", t => t.Weather_Id)
                .Index(t => t.Weather_Id);
            
            CreateTable(
                "dbo.Winds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dirrection = c.String(),
                        Speed = c.String(),
                        Unit = c.String(),
                        Degree = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        CurrentWeather_Id = c.Int(),
                        Day_Id = c.Int(),
                        Night_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CurrentWeathers", t => t.CurrentWeather_Id)
                .ForeignKey("dbo.Days", t => t.Day_Id)
                .ForeignKey("dbo.Nights", t => t.Night_Id)
                .Index(t => t.CurrentWeather_Id)
                .Index(t => t.Day_Id)
                .Index(t => t.Night_Id);
            
            CreateTable(
                "dbo.Forecasts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        DayMaxTemperature = c.String(),
                        NightMinTemperature = c.String(),
                        Unit = c.String(),
                        Weather_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Weathers", t => t.Weather_Id)
                .Index(t => t.Weather_Id);
            
            CreateTable(
                "dbo.Days",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Comments = c.String(),
                        Forecast_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Forecasts", t => t.Forecast_Id)
                .Index(t => t.Forecast_Id);
            
            CreateTable(
                "dbo.Nights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Comments = c.String(),
                        Forecast_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Forecasts", t => t.Forecast_Id)
                .Index(t => t.Forecast_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Forecasts", "Weather_Id", "dbo.Weathers");
            DropForeignKey("dbo.Nights", "Forecast_Id", "dbo.Forecasts");
            DropForeignKey("dbo.Winds", "Night_Id", "dbo.Nights");
            DropForeignKey("dbo.Days", "Forecast_Id", "dbo.Forecasts");
            DropForeignKey("dbo.Winds", "Day_Id", "dbo.Days");
            DropForeignKey("dbo.CurrentWeathers", "Weather_Id", "dbo.Weathers");
            DropForeignKey("dbo.Winds", "CurrentWeather_Id", "dbo.CurrentWeathers");
            DropForeignKey("dbo.UserRoles", "ApplicationUser_Id", "dbo.Users");
            DropForeignKey("dbo.Logins", "ApplicationUser_Id", "dbo.Users");
            DropForeignKey("dbo.UserClaims", "ApplicationUser_Id", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "ApplicationRole_Id", "dbo.Roles");
            DropIndex("dbo.Nights", new[] { "Forecast_Id" });
            DropIndex("dbo.Days", new[] { "Forecast_Id" });
            DropIndex("dbo.Forecasts", new[] { "Weather_Id" });
            DropIndex("dbo.Winds", new[] { "Night_Id" });
            DropIndex("dbo.Winds", new[] { "Day_Id" });
            DropIndex("dbo.Winds", new[] { "CurrentWeather_Id" });
            DropIndex("dbo.CurrentWeathers", new[] { "Weather_Id" });
            DropIndex("dbo.Logins", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.UserClaims", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.UserRoles", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.UserRoles", new[] { "ApplicationRole_Id" });
            DropTable("dbo.Nights");
            DropTable("dbo.Days");
            DropTable("dbo.Forecasts");
            DropTable("dbo.Winds");
            DropTable("dbo.CurrentWeathers");
            DropTable("dbo.Weathers");
            DropTable("dbo.Users");
            DropTable("dbo.Logins");
            DropTable("dbo.UserClaims");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Roles");
            DropTable("dbo.CityPossitions");
        }
    }
}
