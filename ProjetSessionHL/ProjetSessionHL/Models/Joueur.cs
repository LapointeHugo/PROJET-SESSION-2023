using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetSessionHL.Models
{
    public class Joueur
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        [MaxLength(30, ErrorMessage = "MaxCaractersValidation")]
        public string Name { get; set; }

        [Display(Name = "Game")]
        [MaxLength(100, ErrorMessage = "{1} caracteres maximum!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public string Game { get; set; }

        [Display(Name = "Age")]
        [Range(16,50)]
        public int Age { get; set; }

        public ICollection<Tournoi> Tournois { get; set; }
    }
}
