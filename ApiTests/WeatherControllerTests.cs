using System;
using System.Net.Http;
using Api.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Implementation;
using System.Threading.Tasks;
using System.Web.Http;
using System.Collections.Generic;

namespace ApiTests
{
    [TestClass]
    public class WeatherControllerTests
    {
        //[TestMethod]
        //public async Task When_Getting_Two_Day_by_Location_Forecat()
        //{
        //    var controller = new WeathersController();

        //    controller.Request = new HttpRequestMessage();

        //    controller.Configuration = new HttpConfiguration();

        //    var coord = new Geolocation("50.0566531", "19.9229965");

        //    var fetchData = await controller.Get(coord);

        //    var reality = await fetchData.Content.ReadAsAsync<Weathers>();

        //    Assert.AreNotEqual(null, reality.Weather);
        //}

        [TestMethod]
        public async Task When_Getting_Two_Day_Without_Spec_Location_Forecat()
        {
            var controller = new WeathersController();

            controller.Request = new HttpRequestMessage();

            controller.Configuration = new HttpConfiguration();

            var fetchData = await controller.Get();

            var reality = await fetchData.Content.ReadAsAsync<IEnumerable<Weathers>>();

            Assert.AreNotEqual(null, reality);
        }
    }
}
