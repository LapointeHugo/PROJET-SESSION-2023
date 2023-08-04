using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetSessionHL.Models
{
    public class Jeux
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


        public ICollection<Entraineur> Entraineurs { get; set; }
    }
}
