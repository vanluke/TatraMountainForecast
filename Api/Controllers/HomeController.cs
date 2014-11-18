using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var request = base.Request;
            //HostAddress = request.UserHostName .UserHostAddress;
     
            HostAddress = Dns.GetHostAddresses(Dns.GetHostName());

            return View();
        }

        public static IPAddress[] HostAddress { get; set; }
    }
}
