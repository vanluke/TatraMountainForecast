using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Interfaces;
using Service;

namespace ServiceTests
{
    [TestClass]
    public class GeolocationServiceTests
    {
        [TestMethod]
        public void When_Getting_UserLocation_Test()
        {
            IGeolocalizationService geolocation = new GeolocalizationService();
            // var dns = Dns.GetHostEntry(Dns.GetHostName()).;
            var publicIp = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
            var result = geolocation.GetCurrentLocalization(publicIp.ToString()).Result;
            Assert.IsNotNull(result);
        }
    }
}
