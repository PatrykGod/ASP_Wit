using Projekt_1.Models;
using Projekt_1.ViewModel;
using System.Linq;
using System.Web.Mvc;

namespace Projekt_1.Controllers
{
    public class BibliotekaController : Controller
    {
        private ApplicationDbContext _context;
        public BibliotekaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult DodajWydanie()
        {
            return View();
        }
        public ActionResult DodajKsiazke()
        {
            return View();
        }
        public ActionResult DodajWydawnictwo()
        {
            return View();
        }
        public ActionResult ListaPozycji()
        {
            var lista = _context.Autorzies.ToList();

            return View(lista);
        }
        public ActionResult DodajAutora(AutorzyViewModel nowyAutor)
        {
            var Autor = _context.Autorzies.ToList();

            var viewModel = new AutorzyViewModel
            {
                Autorzies = Autor
            };
            return View("DodajAutora", viewModel);
        }
        public ActionResult CreateAutor(Autorzy autorzy) {
            _context.Autorzies.Add(autorzy);
            _context.SaveChanges();
            return RedirectToAction("Index", "Panel");


        }
    }
}