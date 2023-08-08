using Microsoft.AspNetCore.Mvc;
using ProjetSessionHL.Data;
using ProjetSessionHL.Models;
using ProjetSessionHL.ViewModels;

namespace ProjetSessionHL.Controllers
{
    public class EnfantController : Controller
    {
        private readonly ProjetSessionDbContext _baseDeDonnees;

        public EnfantController(ProjetSessionDbContext baseDeDonnees)
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
            IEnumerable<Enfant> donnees = _baseDeDonnees.Enfants;;

            if (criteres.EstJeuxValorant == false)
            {
                donnees = donnees.Where(e => e.IdParent != 1);
            }

            if (criteres.EstJeuxLeagueofLegends == false)
            {
                donnees = donnees.Where(e => e.IdParent != 2);
            }

            if (criteres.EstJeuxCsgo == false)
            {
                donnees = donnees.Where(e => e.IdParent != 3);
            }

            if (criteres.PossedeSite == false)
            {
                donnees = donnees.Where(e => e.PossedeSite == false);
            }
            else
            {
                donnees = donnees.Where(e => e.PossedeSite);
            }


            //for (var i = donnees.Count() - 1; i >= 0; i--)     // Le code individuelle Marche! (Creation)
            //{
            //    var equipe = donnees[i];
            //    if (criteres.Creation != equipe.AnneCreation)
            //    {
            //        if (criteres.Creation == 0)
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            donnees = donnees.Where(e => e.AnneCreation != criteres.Creation);
            //        }
            //    }
            //}

            //for (var i = donnees.Count() - 1; i >= 0; i--)     // Le code individuelle Marche! (Region)
            //{
            //    var equipe = donnees[i];
            //    if (criteres.Region != equipe.Region)
            //    {
            //        if (criteres.Region == "All")
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            donnees.RemoveAt(equipe.Id - 1);
            //        }
            //    }
            //}

            //for (var i = donnees.Count() - 1; i >= 0; i--)      // Le code individuelle Marche! (Nom) *Reste majuscules minuscules*
            //{
            //    var equipe = donnees[i];
            //    if (criteres.Nom != equipe.Nom)
            //    {
            //        if (criteres.Nom == null || criteres.Nom == "")
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            donnees.RemoveAt(equipe.Id - 1);
            //        }
            //    }
            //}

            var model = new PageRechercheViewModel();
            model.Criteres = criteres;
            model.Resultat = donnees.ToList();

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
