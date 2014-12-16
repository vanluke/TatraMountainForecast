using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Interfaces;
using Moq;
using Service;
using Service.Implementation;

namespace ServiceTests
{
    [TestClass]
    public class WeatherOfflineServiceTests
    {
        [TestMethod]
        public async Task When_Loading_Data_From_DatabaseTests()
        {
            var list = new WeatherContainer();

            var weather = new Mock<IWeatherService>();

            weather.Setup( x => x.GetAsync("citybox")).Returns(Task<IWeatherContainer>.FromResult(list as IWeatherContainer));

            var result = await weather.Object.GetAsync("citybox");

            Assert.IsNotNull(result);
        }
    }
}
