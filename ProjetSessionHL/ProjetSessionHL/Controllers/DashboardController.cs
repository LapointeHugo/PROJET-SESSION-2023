using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using ProjetSessionHL.Data;
using ProjetSessionHL.Models;

namespace ProjetSessionHL.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ProjetSessionDbContext _baseDeDonnees;

        public DashboardController(ProjetSessionDbContext baseDeDonnees)
        {
            _baseDeDonnees = baseDeDonnees;
        }

        public IActionResult Admin()
        {
            List<StatistiquesDonnees> objList = _baseDeDonnees.StatistiquesDonnees.ToList();
            return View(objList);
        }

        public IActionResult Coach()
        {
            List<StatistiquesDonnees> objList = _baseDeDonnees.StatistiquesDonnees.ToList();
            return View(objList);
        }
    }
}
