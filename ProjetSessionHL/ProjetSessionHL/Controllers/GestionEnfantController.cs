using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetSessionHL.Models;

namespace ProjetSessionHL.Controllers
{
    public class GestionEnfantController : Controller
    {
        private BaseDeDonnees _baseDeDonnees { get; set; }

        public GestionEnfantController(BaseDeDonnees baseDeDonnees)
        {
            _baseDeDonnees = baseDeDonnees;
        }

        // GET: GestionEnfantController
        [Route("/GestionEnfant/Index")]
        public ActionResult Index()
        {
            return View("Index");
        }

        // GET: GestionEnfantController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
