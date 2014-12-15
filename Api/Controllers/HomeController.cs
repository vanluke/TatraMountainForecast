using System.Net;
using System.Web.Mvc;

namespace Api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
     
            HostAddress = Dns.GetHostAddresses(Dns.GetHostName());
            return View();
        }

        public static IPAddress[] HostAddress { get; set; }
    }
}
