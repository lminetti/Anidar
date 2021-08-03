using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
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
        
        private AnidarEntities db = new AnidarEntities();

        public ActionResult Inscripciones()
        {
            return View(db.Personas.ToList());
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