using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Anidar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddOrEdit()
        {
            ViewBag.Message = "Inscribir.";

            return View();
        }

        public ActionResult Inscripciones()
        {
            ViewBag.Message = "Inscripciones.";

            return View();
        }
    }
}