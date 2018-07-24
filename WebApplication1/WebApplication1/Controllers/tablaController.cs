using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class tablaController : Controller
    {
        // GET: edad
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int txttabla)
        {
            //var tabla = new operaciones();
            //var modelo = tabla.tablaMultiplicar(txttabla);
            ViewBag.tabla = txttabla;
            return View("Resultados");
        }
    }
}