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
            return View(filmies.FirstOrDefault(x=> x.Id == id));
        }

        // GET: FilmController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            film.Id = filmies.Count + 1;
            filmies.Add(film);
            return RedirectToAction("Index");
        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(filmies.FirstOrDefault(x => x.Id == id));
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Film film)
        {
            Film film1 = filmies.FirstOrDefault(x  => x.Id == id);
            film1.Tytul = film.Tytul;
            film1.Opis = film.Opis;
            film1.Ocena = film.Ocena;
            return RedirectToAction("Index");
        }

        // GET: FilmController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(filmies.FirstOrDefault(x => x.Id == id));
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {


            Film film1 = filmies.FirstOrDefault(x => x.Id == id);
            filmies.Remove(film1);

            return RedirectToAction("Index");
        }
    }
}
