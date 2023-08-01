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

            var enfantsDeLaBD = _baseDeDonnees.Enfants.Where(e => enfantsIDs.Contains(e.Id)).ToList();

            return View(_baseDeDonnees.Enfants.Take(3).ToList());
        }

        public IActionResult AjouterUnEnfant(int id)
        {
            var enfantsIDs = HttpContext.Session.Get<List<int>>("enfantsIDs");
            if (enfantsIDs == null)
            {
                enfantsIDs = new List<int>();
            }

            foreach (var item in enfantsIDs)
            {
                if (id != item.Id)
                {
                    enfantsIDs.Add(id);
                }
            }

            //Sauvegarder la liste modifier dans la session
           
            return View("Index");
        }

        public IActionResult SupprimerUnEnfant(int id)
        {
            var enfantsIDs = HttpContext.Session.Get<List<int>>("enfantsIDs");
            if (enfantsIDs == null)
            {
                enfantsIDs = new List<int>();
            }

            foreach (var item in enfantsIDs)
            {
                if (id == item.Id)
                {
                    enfantsIDs.Remove(id);
                }
            }

            //Sauvegarder la liste modifier dans la session

            return View("Index");   
        }
    }
}
