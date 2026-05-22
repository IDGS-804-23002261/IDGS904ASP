using IDGS904ASP.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace IDGS904ASP.Controllers
{
    public class CinepolisController : Controller
    {
        public static List<Cinepolis>
        listaCinepolis = new List<Cinepolis>();


        [HttpGet]
        public ActionResult Cinepolis()
        {
            return View(listaCinepolis);
        }


        [HttpPost]
        public ActionResult Cinepolis(Cinepolis cine)
        {
            cine.Calcular();

            listaCinepolis.Add(cine);

            return View(listaCinepolis);
        }
    }
}