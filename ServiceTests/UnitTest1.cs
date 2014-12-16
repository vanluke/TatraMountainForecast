using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Interfaces;
using Moq;
using Service.Implementation;

namespace ServiceTests
{
    [TestClass]
    public class WeatherServiceTests
    {
        [TestMethod]
        public async Task When_Getting_Remote_DataTests()
        {
            var mockedService = new Mock<IWeatherService>();

            var data = new WeatherContainer();

            mockedService.Setup(x => x.GetAsync()).Returns(Task<IWeatherContainer>.FromResult(data as IWeatherContainer));

            var result = await mockedService.Object.GetAsync();

            Assert.IsNotNull(result);
        }
    }
}
