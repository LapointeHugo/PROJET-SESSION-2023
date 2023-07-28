namespace ProjetSessionHL.Models
{
    public class Parent
    {
        public int Id { get; set; }

        public List<Enfant> Enfants { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }

        public string ImgFile { get; set; }

        public int Courses { get; set; }

        public int Lessons { get; set; }

        public int Coaches { get; set; }
    }
}
