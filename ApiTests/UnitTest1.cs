using System;
using System.Web.Mvc;
using Api.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiTests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void When_Calling_IndexTests()
        {
            var controller = new HomeController();

            var result = controller.Index() as ViewResult;

            Assert.AreEqual(String.Empty, result.ViewName);
        }
    }
}
