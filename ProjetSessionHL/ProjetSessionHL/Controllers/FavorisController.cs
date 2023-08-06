using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetSessionHL.Models;
using System.Collections.Generic;

namespace ProjetSessionHL.Controllers
{
    public class FavorisController : Controller
    {
        private BaseDeDonnees _baseDeDonnees { get; set; }

        public FavorisController(BaseDeDonnees baseDeDonnees)
        {
            _baseDeDonnees = baseDeDonnees;
        }

        public IActionResult Index()
        {
            var enfantsIDs = HttpContext.Session.Get<List<int>>("enfantsIDs");
            if (enfantsIDs == null)
            {
                enfantsIDs = new List<int>();
            }

            var enfantsDeLaBD = _baseDeDonnees.Enfants.ToList();

            return View(enfantsDeLaBD);
        }

        public IActionResult AjouterUnEnfant(int id)
        {
            var enfantsIDs = HttpContext.Session.Get<List<int>>("enfantsIDs");
            if (enfantsIDs == null)
            {
                enfantsIDs = new List<int>();
            }

            int score = 0;
            for (int i = 0; i < enfantsIDs.Count; i++)
            {
                if (enfantsIDs[i] == id)
                {
                    score++;
                }
            }

            if (score == 0) 
            { 
                enfantsIDs.Add(id);
            }



            return View("Index");
        }

        public IActionResult SupprimerUnEnfant(int id)
        {
            var enfantsIDs = HttpContext.Session.Get<List<int>>("enfantsIDs");
            if (enfantsIDs == null)
            {
                enfantsIDs = new List<int>();
            }

            for (int i = 0; i < enfantsIDs.Count; i++)
            {
                if (id == enfantsIDs[i])
                {
                    enfantsIDs.Remove(id);
                }
            }

            //Sauvegarder la liste modifier dans la session

            return View("Index");   
        }
    }
}
