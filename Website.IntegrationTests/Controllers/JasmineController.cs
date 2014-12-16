using System;
using System.Web.Mvc;

namespace Website.IntegrationTests.Controllers
{
    public class JasmineController : Controller
    {
        public ViewResult Run()
        {
            return View("SpecRunner");
        }
    }
}
