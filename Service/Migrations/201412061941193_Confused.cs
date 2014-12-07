namespace Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Confused : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Winds", "CurrentWeather_Id", "dbo.CurrentWeathers");
            DropForeignKey("dbo.CurrentWeathers", "Weather_Id", "dbo.Weathers");
            DropForeignKey("dbo.Winds", "Day_Id", "dbo.Days");
            DropForeignKey("dbo.Days", "Forecast_Id", "dbo.Forecasts");
            DropForeignKey("dbo.Winds", "Night_Id", "dbo.Nights");
            DropForeignKey("dbo.Nights", "Forecast_Id", "dbo.Forecasts");
            DropForeignKey("dbo.Forecasts", "Weather_Id", "dbo.Weathers");
            DropIndex("dbo.CurrentWeathers", new[] { "Weather_Id" });
            DropIndex("dbo.Winds", new[] { "CurrentWeather_Id" });
            DropIndex("dbo.Winds", new[] { "Day_Id" });
            DropIndex("dbo.Winds", new[] { "Night_Id" });
            DropIndex("dbo.Forecasts", new[] { "Weather_Id" });
            DropIndex("dbo.Days", new[] { "Forecast_Id" });
            DropIndex("dbo.Nights", new[] { "Forecast_Id" });
            DropTable("dbo.CurrentWeathers");
            DropTable("dbo.Winds");
            DropTable("dbo.Forecasts");
            DropTable("dbo.Days");
            DropTable("dbo.Nights");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Nights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Comments = c.String(),
                        Forecast_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Days",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Comments = c.String(),
                        Forecast_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Forecasts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        DayMaxTemperature = c.String(),
                        NightMinTemperature = c.String(),
                        Unit = c.String(),
                        Weather_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
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
                        Weather_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Nights", "Forecast_Id");
            CreateIndex("dbo.Days", "Forecast_Id");
            CreateIndex("dbo.Forecasts", "Weather_Id");
            CreateIndex("dbo.Winds", "Night_Id");
            CreateIndex("dbo.Winds", "Day_Id");
            CreateIndex("dbo.Winds", "CurrentWeather_Id");
            CreateIndex("dbo.CurrentWeathers", "Weather_Id");
            AddForeignKey("dbo.Forecasts", "Weather_Id", "dbo.Weathers", "Id");
            AddForeignKey("dbo.Nights", "Forecast_Id", "dbo.Forecasts", "Id");
            AddForeignKey("dbo.Winds", "Night_Id", "dbo.Nights", "Id");
            AddForeignKey("dbo.Days", "Forecast_Id", "dbo.Forecasts", "Id");
            AddForeignKey("dbo.Winds", "Day_Id", "dbo.Days", "Id");
            AddForeignKey("dbo.CurrentWeathers", "Weather_Id", "dbo.Weathers", "Id");
            AddForeignKey("dbo.Winds", "CurrentWeather_Id", "dbo.CurrentWeathers", "Id");
        }
    }
}
