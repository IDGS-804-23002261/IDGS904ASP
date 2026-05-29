using IDGS904ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904ASP.Controllers
{
    public class ResistenciaController : Controller
    {
        public static List<Resistencia>
        listaResistencias = new List<Resistencia>();


        [HttpGet]
        public ActionResult Resistencia()
        {
            return View(listaResistencias);
        }


        [HttpPost]
        public ActionResult Resistencia(Resistencia res)
        {
            res.Calcular();

            listaResistencias.Clear();
            listaResistencias.Add(res);

            return View(listaResistencias);
        }
    }
}