using Microsoft.AspNetCore.Mvc;
using ProjetSessionHL.Data;
using ProjetSessionHL.Models;

namespace ProjetSessionHL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjetSessionDbContext _baseDeDonnees;

        public HomeController(ProjetSessionDbContext baseDeDonnees)
        {
            _baseDeDonnees = baseDeDonnees;
        }

        public IActionResult Index()
        {
            List<Parent> objList = _baseDeDonnees.Parents.ToList();
            return View(objList);
        }
    }
}
