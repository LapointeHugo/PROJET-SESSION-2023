using System.ComponentModel;

namespace ProjetSessionHL.Models
{
    public class Enfant
    {
        public int Id { get; set; }

        public int IdParent { get; set; }

        public Parent Parent { get; set; }

        public string ImgFile { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public bool PossedeSite { get; set; }

        public string Site { get; set; }

        public int AnneCreation { get; set; }

        public string Region { get; set; }

        public string Abbreviation { get; set; }

        public int MontantGagnee { get; set; }
    }
}
