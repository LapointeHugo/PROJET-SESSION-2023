using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetSessionHL.Data;
using ProjetSessionHL.Models;
using System.Linq;

namespace ProjetSessionHL.Controllers
{
    public class GestionEnfantController : Controller
    {
        private readonly ProjetSessionDbContext _baseDeDonnees;

        public GestionEnfantController(ProjetSessionDbContext baseDeDonnees)
        {
            _baseDeDonnees = baseDeDonnees;
        }

        // GET: GestionEnfantController
        [Route("/GestionEnfant/Index")]
        public ActionResult Index()
        {
            List<Enfant> objList = _baseDeDonnees.Enfants.ToList();
            return View(objList);
        }

        // GET: GestionEnfantController/Details/5
        public ActionResult Details(int id)
        {
            var enfantsRecherché = _baseDeDonnees.Enfants.Where(e => e.Id == id).SingleOrDefault();
            if (enfantsRecherché == null)
            {
                return View("NonTrouve");
            }
            else
            {
                return View("Details", enfantsRecherché);
            }
        }

        // GET: GestionEnfantController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GestionEnfantController/Create
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

        // GET: GestionEnfantController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GestionEnfantController/Edit/5
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

        // GET: GestionEnfantController/Delete/5
        public ActionResult Delete(int id)
        {
            var enfantsRecherché = _baseDeDonnees.Enfants.Where(e => e.Id == id).SingleOrDefault();
            if (enfantsRecherché == null)
            {
                return View("NonTrouve");
            }
            else
            {
                return View("Delete", enfantsRecherché);
            }
        }

        // POST: GestionEnfantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var equipe = _baseDeDonnees.Enfants.FirstOrDefault(e => e.Id == id);
                equipe.Parent.Enfants.Remove(equipe);
                _baseDeDonnees.Enfants.Remove(equipe);

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
