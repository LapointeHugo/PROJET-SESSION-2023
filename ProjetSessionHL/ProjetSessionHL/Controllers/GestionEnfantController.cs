using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using ProjetSessionHL.Data;
using ProjetSessionHL.Models;
using System.Linq;

namespace ProjetSessionHL.Controllers
{
    public class GestionEnfantController : Controller
    {
        private readonly ProjetSessionDbContext _baseDeDonnees;
        private readonly ILogger<GestionEnfantController> _logger;
        private readonly IStringLocalizer<GestionEnfantController> _localizer;

        public GestionEnfantController(ProjetSessionDbContext baseDeDonnees, ILogger<GestionEnfantController> logger, IStringLocalizer<GestionEnfantController> localizer)
        {
            _baseDeDonnees = baseDeDonnees;
            _logger = logger;
            _localizer = localizer;
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
        public ActionResult Create(Enfant enfant)
        {
            if (!ModelState.IsValid)
            {
                _baseDeDonnees.Enfants.Add(enfant);
                _baseDeDonnees.SaveChanges();
                TempData["Success"] = $"{enfant.Nom} subjet added";
                return this.RedirectToAction("Index");
            }

            return this.View(enfant);
        }

        // GET: GestionEnfantController/Edit/5
        public ActionResult Edit(int? id)
        {
            var enfant = _baseDeDonnees.Enfants.Where(p => p.Id == id).FirstOrDefault();
            ViewBag.IdParent = _baseDeDonnees.Parents.Count();

            return View(enfant);
        }

        // POST: GestionEnfantController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Enfant enfant)
        {
            var enfants = _baseDeDonnees.Enfants.Where(p => p.Id == id).FirstOrDefault();
            _baseDeDonnees.Enfants.Remove(enfants);
            _baseDeDonnees.Enfants.Add(enfants);
            _baseDeDonnees.SaveChanges();

            return RedirectToAction("Index");
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

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            var cookie = CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture));
            var name = CookieRequestCultureProvider.DefaultCookieName;

            Response.Cookies.Append(name, cookie, new CookieOptions
            {
                Path = "/",
                Expires = DateTimeOffset.UtcNow.AddYears(1),
            });

            return LocalRedirect(returnUrl);
        }
    }
}
