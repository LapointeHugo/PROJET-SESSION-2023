using ProjetSessionHL.Models;

namespace ProjetSessionHL.ViewModels
{
    public class PageRechercheViewModel
    {
        public CritereRechercheViewModel Criteres { get; set; }

        public List<Enfant> Resultat { get; set; }
    }
}
