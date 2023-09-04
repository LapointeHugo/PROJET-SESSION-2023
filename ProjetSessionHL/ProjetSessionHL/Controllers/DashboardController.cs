using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using ProjetSessionHL.Data;
using ProjetSessionHL.Models;
using ProjetSessionHL.Utility;

namespace ProjetSessionHL.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ProjetSessionDbContext _baseDeDonnees;

        public DashboardController(ProjetSessionDbContext baseDeDonnees)
        {
            _baseDeDonnees = baseDeDonnees;
        }

        [Authorize(Roles = AppConstants.AdminRole)]
        public IActionResult Admin()
        {
            List<StatistiquesDonnees> objList = _baseDeDonnees.StatistiquesDonnees.ToList();
            return View(objList);
        }

        [Authorize(Roles = AppConstants.AdminRole)]
        [Authorize(Roles = AppConstants.CoachRole)]
        public IActionResult Coach()
        {
            List<StatistiquesDonnees> objList = _baseDeDonnees.StatistiquesDonnees.ToList();
            return View(objList);
        }
    }
}
