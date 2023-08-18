using System.ComponentModel.DataAnnotations;

namespace ProjetSessionHL.Models
{
    public class Parent
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        [MaxLength(30, ErrorMessage = "{1} caracteres maximum!")]
        public string Nom { get; set; }

        [Display(Name = "Description")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        [MaxLength(1000, ErrorMessage = "{1} caracteres maximum!")]
        public string Description { get; set; }

        [Display(Name = "Game Image")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public string ImgFile { get; set; }

        [Display(Name = "Team Image")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public string ImgFileEquipe { get; set; }

        [Display(Name = "Courses")]
        public int Courses { get; set; }

        [Display(Name = "Lessons")]
        public int Lessons { get; set; }

        [Display(Name = "Coaches")]
        public int Coaches { get; set; }
        

        public ICollection<Enfant> Enfants { get; set; }
    }
}
