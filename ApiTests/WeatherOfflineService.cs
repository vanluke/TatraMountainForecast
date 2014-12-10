//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Model.Implementation;
//using Model.Interfaces;
//using Moq;
//using Service;

//namespace ApiTests
//{
//    [TestClass]
//    public class WeatherOfflineService
//    {
//        [TestMethod]
//        public void When_Getting_WeatherTest()
//        {
//            var db = new ApplicationContext();

//            var data = db.Weathers.ToList();

//            Assert.IsTrue(data.Count > 1);
//        }

//        [TestMethod]
//        public void When_Update_WeatherTest()
//        {
//            var toBeChanged = new Weather();

//            var service = new Mock<IWeatherService>();

//            service.Setup(c => c.UpdateAsync(toBeChanged));

//            service.Verify();
//        }
//        [TestMethod]
//        public void When_Get_One_WeatherTest()
//        {
//            var city = "Warsaw";

//            var service = new Mock<IWeatherService>();

//            service.Setup(c => c.GetAsync(city)).ReturnsAsync(new Weather("Warsaw", new List<CurrentWeather>(), new List<Forecast>()));

//            service.Verify();
//        }
//        [TestMethod]
//        public void When_Delete_WeatherTest()
//        {
//            var city = "Warsaw";

//            var service = new Mock<IWeatherService>();

//            service.Setup(c => c.DeleteAsync(city));

//            service.Verify();
//        }
//    }
//}
