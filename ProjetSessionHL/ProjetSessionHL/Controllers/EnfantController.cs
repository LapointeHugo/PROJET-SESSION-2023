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

        [Route("/Enfant/Recherche")]
        public IActionResult Recherche()
        {
            var model = new PageRechercheViewModel();
            model.Criteres = new CritereRechercheViewModel();
            model.Criteres.EstJeuxValorant = true;
            model.Criteres.EstJeuxLeagueofLegends = true;
            model.Criteres.EstJeuxCsgo = true;
            model.Resultat = _baseDeDonnees.Enfants.ToList();

            return View("Recherche", model);
        }

        [HttpPost]
        public IActionResult Recherche(CritereRechercheViewModel criteres)
        {
            var model = new PageRechercheViewModel();
            model.Criteres = criteres;
            model.Resultat = _baseDeDonnees.Enfants.ToList();

            return View("Recherche", model);
        }

        [Route("/Enfant/Filtrer")]
        public IActionResult Filtrer(CritereRechercheViewModel criteres)
        {
            IEnumerable<Enfant> donnees = _baseDeDonnees.Enfants;

            

            var model = new PageRechercheViewModel();
            model.Criteres = criteres;
            model.Resultat = donnees.Take(0).ToList();

            return View("Recherche", model);
        }

        [Route("/Enfant/Detail/{id}")]
        [Route("/Enfant/{id}")]
        [Route("/{id}")]
        public IActionResult DetailParID(int id)
        {
            var enfantsRecherché = _baseDeDonnees.Enfants.Where(e => e.Id == id).SingleOrDefault();
            if (enfantsRecherché == null)
            {
                return View("NonTrouve");
            }
            else
            {
                return View("Detail", enfantsRecherché);
            }
        }

        //[Route("/Enfant/Detail/{nom}")]
        //[Route("/Enfant/{nom}")]
        //[Route("/{nom}")]
        //public IActionResult DetailParNom(string nom)
        //{
        //    var enfantsRecherché = _baseDeDonnees.Enfants.Where(e => e.Nom == nom).SingleOrDefault();
        //    if (enfantsRecherché == null)
        //    {
        //        return View("NonTrouve");
        //    }
        //    else
        //    {
        //        return View("Detail", enfantsRecherché);
        //    }
        //}
    }
}
