using System;
using System.Net.Http;
using Api.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Web.Http;
using System.Collections.Generic;
using System.Net;
using System.Web.Http.Routing;
using Model.Interfaces;
using Moq;
using Service.Implementation;

namespace ApiTests
{
    [TestClass]
    public class WeatherControllerTests
    {
        [TestMethod]
        public async Task When_Getting_ForecastTest()
        {
            var weatherService = new Mock<IWeatherService>();

            var geolcationService = new Mock<IGeolocalizationService>();

            var currentLocation = await geolcationService.Object.GetCurrentLocalization(Environment.UserDomainName);

            geolcationService.Setup(x => x.GetCurrentLocalization(Environment.UserDomainName))
                .Returns(Task.FromResult(new UserLocation("50.0566531,19.9229965", "Cracow") as IUserLocation));

            var mockdata = new WeatherContainer();

            mockdata.Calctime = 1.1;

            mockdata.Cod = "200";

            mockdata.Forecast = GetWeatherForecast() as IEnumerable<IForecast>;

            weatherService.Setup(x => x.GetAsync()).Returns(Task<IWeatherContainer>.FromResult(mockdata as IWeatherContainer));

            weatherService.Setup(x => x.GetAsync("50.0566531,19.9229965")).Returns(Task<IWeatherContainer>.FromResult(mockdata as IWeatherContainer));

            var controller = new WeathersController(weatherService.Object, geolcationService.Object);

            controller.Request = new HttpRequestMessage();

            controller.Configuration = new HttpConfiguration();


            var fetchData = await controller.Get();

            Assert.AreNotEqual(null, fetchData);
        }

        private static List<Forecast> GetWeatherForecast()
        {
            var fore = new Forecast()
            {
                Clouds = new Clouds() {All = 1},
                Coordinate = new Possition() {Latitude = 51.1, Location = "Cracow", Longitude = 51.1},
                DataReceivingTime = 123,
                Name = "Cracow",
                Rain = new Rain() {Duration = 1},
                Snow = new Snow() {Duration = 1},
                Weather =
                    new List<Weather>() {new Weather() {Description = "", Icon = "", Id = 1, QuickDescription = ""}},
                WeatherDetails =
                    new WeatherDetails()
                    {
                        GroundLevel = 1.1,
                        Humidity = 1.1,
                        MaxTemperature = 12.1,
                        MinTemperature = 12.1,
                        Pressure = 123,
                        SeaLevel = 213.1,
                        Temperature = 12
                    },
                Id = 1,
                Wind = new Wind() {Deg = 1234, Speed = 23}
            };

            return new List<Forecast> { fore };
        }
    }
}
