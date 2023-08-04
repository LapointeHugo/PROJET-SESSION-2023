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
            IEnumerable<Enfant> donneesOrigine = _baseDeDonnees.Enfants;
            var donnees = donneesOrigine.ToList();

            //for (var i = donnees.Count() - 1; i >= 0; i--)      // Le code individuelle Marche! (EstValorant)
            //{
            //    var equipe = donnees[i];

            //    if (criteres.EstJeuxValorant == false && equipe.IdParent == 1)
            //    {
            //        donnees.RemoveAt(equipe.Id - 1);
            //    }
            //}

            //for (var i = donnees.Count() - 1; i >= 0; i--)      // Le code individuelle Marche! (EstLeagueofLegends)
            //{
            //    var equipe = donnees[i];

            //    if (criteres.EstJeuxLeagueofLegends == false && equipe.IdParent == 2)
            //    {
            //        donnees.RemoveAt(equipe.Id - 1);
            //    }
            //}

            //for (var i = donnees.Count() - 1; i >= 0; i--)      // Le code individuelle Marche! (EstCsgo)
            //{
            //    var equipe = donnees[i];

            //    if (criteres.EstJeuxCsgo == false && equipe.IdParent == 3)
            //    {
            //        donnees.RemoveAt(equipe.Id - 1);
            //    }
            //}

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
            //            donnees.RemoveAt(equipe.Id - 1);
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

            //for (var i = donnees.Count() - 1; i >= 0; i--)      // Le code individuelle Marche! (PossedeSite) 
            //{
            //    var equipe = donnees[i];
            //    if (criteres.PossedeSite != equipe.PossedeSite)
            //    {
            //        donnees.RemoveAt(equipe.Id - 1);
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
