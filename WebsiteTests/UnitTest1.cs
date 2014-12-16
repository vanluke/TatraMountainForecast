using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Website.Controllers;

namespace WebsiteTests
{
    [TestClass]
    public class WebsiteHomeControllerTest
    {
        [TestMethod]
        public void When_Calling_IndexTest()
        {
            controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual(String.Empty, result.ViewName);
        }
        [TestMethod]
        public void When_Calling_WeathersTest()
        {
            controller = new HomeController();
            var result = controller.Weathers() as ViewResult;
            Assert.AreEqual(String.Empty, result.ViewName);
        }
        [TestMethod]
        public void When_Calling_MainTest()
        {
            controller = new HomeController();
            var result = controller.Main() as ViewResult;
            Assert.AreEqual(String.Empty, result.ViewName);
        }
        [TestMethod]
        public void When_Calling_AboutTest()
        {
            controller = new HomeController();
            var result = controller.About() as ViewResult;
            Assert.AreEqual(String.Empty, result.ViewName);
        }
        [TestMethod]
        public void When_Calling_ContactTest()
        {
            controller = new HomeController();
            var result = controller.Contact() as ViewResult;
            Assert.AreEqual(String.Empty, result.ViewName);
        }

        private HomeController controller;
    }
}
