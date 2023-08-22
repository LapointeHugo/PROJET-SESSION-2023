using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetSessionHL.Models
{
    public class Tournoi
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        [MaxLength(30, ErrorMessage = "MaxCaractersValidation")]
        public string Name { get; set; }

        [Display(Name = "Location")]
        [MaxLength(100, ErrorMessage = "{1} caracteres maximum!")]
        public string Location { get; set; }

        [Display(Name = "Prize Pool")]
        public float PrizePool { get; set; }

        public ICollection<Joueur> Joueurs { get; set; }
    }
}
