using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIDonjonEtDragon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Armes()
        {
            ViewBag.Message = "La liste des armes";

            return View();
        }

        public ActionResult Armures()
        {
            ViewBag.Message = "La liste des armures";

            return View();
        }

        public ActionResult Sorts()
        {
            ViewBag.Message = "La liste des sorts";

            return View();
        }
    }
}