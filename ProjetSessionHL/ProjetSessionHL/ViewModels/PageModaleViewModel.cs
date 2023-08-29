using ProjetSessionHL.Models;

namespace ProjetSessionHL.ViewModels
{
    public class PageModaleViewModel
    {
        public CritereModaleViewModel Criteres { get; set; }

        public List<Enfant> Resultat { get; set; }
    }
}

