namespace ProjetSessionHL.ViewModels
{
    public class CritereRechercheViewModel
    { 
        public bool EstJeuxValorant { get; set; }

        public bool EstJeuxLeagueofLegends { get; set; }

        public bool EstJeuxCsgo { get; set; }

        public int Creation { get; set; }

        public string Region { get; set; }

        public bool PossedeSite { get; set; }

        public string Nom { get; set; }

        public List<string> ChoixRegion = new List<string> { "All", "Europe", "North America", "Korea", "China" };
    }
}
