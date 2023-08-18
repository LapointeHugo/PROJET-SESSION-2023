using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using ProjetSessionHL.Data;
using ProjetSessionHL.Models;

namespace ProjetSessionHL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjetSessionDbContext _baseDeDonnees;
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(ProjetSessionDbContext baseDeDonnees, ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
        {
            _baseDeDonnees = baseDeDonnees;
            _logger = logger;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            List<Parent> objList = _baseDeDonnees.Parents.ToList();
            return View(objList);
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
