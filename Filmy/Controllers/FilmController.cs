using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Filmy.Models;
namespace Filmy.Controllers
{
    public class FilmController : Controller
    {
        private static IList<Film> filmies = new List<Film>
        {
            new Film() {Id = 1, Tytul = "Batman", Opis = "opis film1", Ocena = 3},
            new Film() {Id = 2, Tytul = "Nowy poczatek", Opis = "opis film2", Ocena = 5},
            new Film() {Id = 3, Tytul = "Batman2", Opis = "opis film3", Ocena = 3},
        };
        // GET: FilmController
        public ActionResult Index()
        {
            return View(filmies);
        }

        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FilmController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
