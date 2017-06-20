using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace przelewy24_mvc.Controllers
{
    public class HomeController : Controller
    {
            public async System.Threading.Tasks.Task<ActionResult> Index()
        {
            ViewData["lang"] = new lang.Lang();
            Przelewy24.Przelewy24 przelewy24 = new Przelewy24.Przelewy24("44214", "44214", "123456789");
            var testConnectionResult = await przelewy24.TestConnection();
            ViewData["testConnectionResult"] = testConnectionResult;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}