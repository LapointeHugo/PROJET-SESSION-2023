namespace ProjetSessionHL.ViewModels
{
    public class CritereModaleViewModel
    {
        public bool EstJeuxValorant { get; set; }

        public bool EstJeuxLeagueofLegends { get; set; }

        public bool EstJeuxCsgo { get; set; }

        public int Creation { get; set; }

        public string Region { get; set; }

        public string Nom { get; set; }

        public List<string> ChoixRegion = new List<string> { "All", "Europe", "North America", "Korea", "China" };

        public List<string> AnneeCreation = new List<string> { "All",  "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012"
        , "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000" };
    }
}
