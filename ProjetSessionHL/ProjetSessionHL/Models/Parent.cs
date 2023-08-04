using System.ComponentModel.DataAnnotations;

namespace ProjetSessionHL.Models
{
    public class Parent
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nom")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nom requis")]
        [MaxLength(30, ErrorMessage = "{1} caracteres maximum!")]
        public string Nom { get; set; }

        [Display(Name = "Description")]
        [Required]
        [MaxLength(200, ErrorMessage = "{1} caracteres maximum!")]
        public string Description { get; set; }

        public string ImgFile { get; set; }

        public string ImgFileEquipe { get; set; }

        public int Courses { get; set; }

        public int Lessons { get; set; }

        public int Coaches { get; set; }
        

        public ICollection<Enfant> Enfants { get; set; }
    }
}
