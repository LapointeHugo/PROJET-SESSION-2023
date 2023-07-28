using Microsoft.AspNetCore.Mvc;

namespace ProjetSessionHL.Controllers
{
    public class EnfantController : Controller
    {
        public IActionResult Recherche()
        {
            return View("Recherche");
        }

        public IActionResult Detail()
        {
            return View("Detail");
        }
    }
}
