using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt_1.Controllers
{
    public class ArtykulController : Controller
    {
        // GET: Artykul
        public ActionResult ListaArtykulow()
        {
            return View();
        }
        public ActionResult DodajArtykul()
        {
            return View();
        }
        public ActionResult DodajKategorie()
        {
            return View();
        }
        public ActionResult EdytujArtykul()
        {
            return View();
        }
    }
}