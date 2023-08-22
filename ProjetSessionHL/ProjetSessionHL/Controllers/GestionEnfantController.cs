using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using ProjetSessionHL.Data;
using ProjetSessionHL.Models;
using ProjetSessionHL.Services;
using ProjetSessionHL.ViewModels;
using System.Linq;

namespace ProjetSessionHL.Controllers
{
    public class GestionEnfantController : Controller
    {
        private readonly ProjetSessionDbContext _baseDeDonnees;
        private readonly ILogger<GestionEnfantController> _logger;
        private readonly IStringLocalizer<GestionEnfantController> _localizer;
        private IParentService _serviceParent { get; set; }

        public GestionEnfantController(ProjetSessionDbContext baseDeDonnees, ILogger<GestionEnfantController> logger, IStringLocalizer<GestionEnfantController> localizer, IParentService serviceParent)
        {
            _baseDeDonnees = baseDeDonnees;
            _logger = logger;
            _localizer = localizer;
            _serviceParent = serviceParent;
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
                _logger.LogInformation("Team with id number {0} (" + enfant.Nom + ") has been created", enfant.Id);
                return this.RedirectToAction("Index");
            }

            return this.View(enfant);
        }

        // GET: GestionEnfantController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            EnfantVM enfantVM = new EnfantVM();
            enfantVM.Enfant = _baseDeDonnees.Enfants.Find(id);
            enfantVM.ParentSelectList = _baseDeDonnees.Parents.Select(p => new SelectListItem
            {
                Text = p.Nom,
                Value = p.Id.ToString()
            }).OrderBy(p => p.Text);

            return View(enfantVM);
        }

        // POST: GestionEnfantController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EnfantVM enfantVM)
        {
            if (!ModelState.IsValid)
            {
                _baseDeDonnees.Enfants.Update(enfantVM.Enfant);
                _baseDeDonnees.SaveChanges();
                _logger.LogInformation("Team with id number {0} (" + enfantVM.Enfant.Nom + ") has been edited", id);
                return RedirectToAction("Index");
            }
            
            enfantVM.ParentSelectList = _baseDeDonnees.Parents.Select(t => new SelectListItem
            {
                Text = t.Nom,
                Value = t.Id.ToString()
            }).OrderBy(t => t.Text);

            return View(enfantVM);
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
