using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using ProjetSessionHL.Data;
using ProjetSessionHL.Models;
using ProjetSessionHL.ViewModels;

namespace ProjetSessionHL.Controllers
{
    public class ParentController : Controller
    {
        private readonly ProjetSessionDbContext _baseDeDonnees;
        private readonly ILogger<ParentController> _logger;
        private readonly IStringLocalizer<ParentController> _localizer;

        public ParentController(ProjetSessionDbContext baseDeDonnees, ILogger<ParentController> logger, IStringLocalizer<ParentController> localizer)
        {
            _baseDeDonnees = baseDeDonnees;
            _logger = logger;
            _localizer = localizer;
        }

        // GET: ParentController
        [Route("/Parent/Index")]
        public ActionResult Index()
        {
            List<Parent> objList = _baseDeDonnees.Parents.ToList();
            return View(objList);
        }

        // GET: ParentController/Details/5
        public ActionResult Details(int id)
        {
            var parentsRecherché = _baseDeDonnees.Parents.Where(e => e.Id == id).SingleOrDefault();
            if (parentsRecherché == null)
            {
                return View("NonTrouve");
            }
            else
            {
                return View("Details", parentsRecherché);
            }
        }

        // GET: ParentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Parent parent)
        {
            if (!ModelState.IsValid)
            {
                _baseDeDonnees.Parents.Add(parent);
                _baseDeDonnees.SaveChanges();
                TempData["Success"] = $"{parent.Nom} subjet added";
                return this.RedirectToAction("Index");
            }

            return this.View(parent);
        }

        // GET: ParentController/Edit/5
        public ActionResult Edit(int? id)
        {
            var parent = _baseDeDonnees.Parents.Where(p => p.Id == id).FirstOrDefault();

            return View(parent);
        }

        // POST: ParentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Parent parent)
        {                       
            var parents = _baseDeDonnees.Parents.Where(p => p.Id == id).FirstOrDefault();
            _baseDeDonnees.Parents.Remove(parents);
            _baseDeDonnees.Parents.Add(parent);
            _baseDeDonnees.SaveChanges();

            return RedirectToAction("Index");          
        }

        // GET: ParentController/Delete/5
        public ActionResult Delete(int id)
        {
            var parent = _baseDeDonnees.Parents.Where(p => p.Id == id).FirstOrDefault();

            return View(parent);
        }

        // POST: ParentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var parent = _baseDeDonnees.Parents.Where(p => p.Id == id).FirstOrDefault();
            _baseDeDonnees.Parents.Remove(parent);
            _baseDeDonnees.SaveChanges();
            return RedirectToAction("Index"); 
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
