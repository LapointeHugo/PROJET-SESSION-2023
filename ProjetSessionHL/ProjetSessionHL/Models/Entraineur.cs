using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetSessionHL.Models
{
    public class Entraineur
    {
        [Key]
        public int Id { get; set; }

        public string ImgFile { get; set; }

        [Display(Name = "Prénom")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} requis")]
        [MaxLength(30, ErrorMessage = "{1} caracteres maximum!")]
        public string FirstName { get; set; }

        [Display(Name = "Nom")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} requis")]
        [MaxLength(30, ErrorMessage = "{1} caracteres maximum!")]
        public string LastName { get; set; }

        [Display(Name = "Adresse Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} requis")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [ForeignKey("Jeux")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} requis")]
        public int IdJeux { get; set; }

        public Jeux Jeux { get; set; }
    }
}
