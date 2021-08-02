using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Anidar.Models;

namespace Anidar.Controllers
{
    public class PersonasController : Controller
    {
        [HttpGet]
        public ActionResult AddOrEdit(int id=0)
        {
            Persona personaModel = new Persona();
            return View(personaModel);
        }

        [HttpPost]
        public ActionResult AddOrEdit(Persona personaModel)
        {
            using (AnidarEntities dbModel = new AnidarEntities())
            {
                dbModel.Personas.Add(personaModel);
                dbModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Ingreso correcto.";
            return View("AddOrEdit", new Persona());

        }
    }
}