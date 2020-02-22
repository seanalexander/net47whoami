using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace net47whoami.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string machine_name = Environment.MachineName;
            this.Response.AppendHeader("x-whoami", machine_name);
            ViewBag.Title = $"{machine_name}";
            return View();
        }
    }
}
