using Microsoft.AspNetCore.Mvc;
using ProjetSessionHL.Data;
using ProjetSessionHL.Models;
using ProjetSessionHL.ViewModels;

namespace ProjetSessionHL.Controllers
{
    public class ParentController : Controller
    {
        private readonly ProjetSessionDbContext _baseDeDonnees;

        public ParentController(ProjetSessionDbContext baseDeDonnees)
        {
            _baseDeDonnees = baseDeDonnees;
        }

        // GET: ParentController
        [Route("/Parent/Index")]
        public ActionResult Index()
        {
            //List<Parent> objList = _baseDeDonnees.Parents.ToList();
            return View();
        }

        // GET: ParentController/Details/5
        public ActionResult Details(int id)
        {
            //var parentsRecherché = _baseDeDonnees.Parents.Where(e => e.Id == id).SingleOrDefault();
            //if (parentsRecherché == null)
            //{
            //    return View("NonTrouve");
            //}
            //else
            //{
            //    return View("Details", parentsRecherché);
            //}
            return View();
        }

        // GET: ParentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParentController/Create
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

        // GET: ParentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ParentController/Edit/5
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

        // GET: ParentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ParentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            return View();
        }
    }
}
