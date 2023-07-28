using Microsoft.AspNetCore.Mvc;
using ProjetSessionHL.Models;
using ProjetSessionHL.ViewModels;

namespace ProjetSessionHL.Controllers
{
    public class EnfantController : Controller
    {
        private BaseDeDonnees _baseDeDonnees { get; set; }

        public EnfantController(BaseDeDonnees baseDeDonnees)
        {
            _baseDeDonnees = baseDeDonnees;
        }

        public IActionResult Recherche()
        {
            var model = new PageRechercheViewModel();
            model.Criteres = new CritereRechercheViewModel();
            model.Criteres.EstJeuxValorant = true;
            model.Criteres.EstJeuxLeagueofLegends = true;
            model.Criteres.EstJeuxCsgo = true;
            model.Resultat = _baseDeDonnees.Enfants.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Recherche(CritereRechercheViewModel criteres)
        {
            var model = new PageRechercheViewModel();
            model.Criteres = criteres;
            model.Resultat = _baseDeDonnees.Enfants.ToList();

            return View(model);
        }

        //[Route("/Enfant/Detail/{id}")]
        //[Route("/Enfant/{id}")]
        //[Route("/{id}")]
        public IActionResult DetailParID(int id)
        {
            var enfantsRecherché = _baseDeDonnees.Enfants.Where(e => e.Id == id).SingleOrDefault();
            if (enfantsRecherché == null)
            {
                return View("NonTrouve");
            }
            else
            {
                return View(enfantsRecherché);
            }
        }

        //[Route("/Enfant/Detail/{string}")]
        //[Route("/Enfant/{string}")]
        //[Route("/{string}")]
        public IActionResult DetailParNom(string nom)
        {
            var enfantsRecherché = _baseDeDonnees.Enfants.Where(e => e.Nom == nom).SingleOrDefault();
            if (enfantsRecherché == null)
            {
                return View("NonTrouve");
            }
            else
            {
                return View(enfantsRecherché);
            }
        }
    }
}
