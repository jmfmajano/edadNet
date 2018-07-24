using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class edadController : Controller
    {
        // GET: edad
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int edad)
        {
            return View();
        }
    }
}