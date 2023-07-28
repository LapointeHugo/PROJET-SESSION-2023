using Microsoft.AspNetCore.Mvc;
using ProjetSessionHL.Models;

namespace ProjetSessionHL.Controllers
{
    public class HomeController : Controller
    {
        private BaseDeDonnees _baseDeDonnees { get; set; }

        public HomeController(BaseDeDonnees baseDeDonnees)
        {
            _baseDeDonnees = baseDeDonnees;
        }

        public IActionResult Index()
        {
            return View(_baseDeDonnees.Parents.ToList());
        }
    }
}
