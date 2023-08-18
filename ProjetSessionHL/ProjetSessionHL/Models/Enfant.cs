using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjetSessionHL.Models
{
    public class Enfant
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Team Logo")]
        public string ImgFile { get; set; }

        [Display(Name = "Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        [MaxLength(30, ErrorMessage = "{1} caracteres maximum!")]
        public string Nom { get; set; }

        [Display(Name = "Description")]
        [MaxLength(1000, ErrorMessage = "{1} caracteres maximum!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public string Description { get; set; }

        [Display(Name = "Location")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public string Location { get; set; }

        [Display(Name = "Has Website")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public bool PossedeSite { get; set; }

        [Display(Name = "Website")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public string Site { get; set; }

        [Display(Name = "Year of Creation")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public int AnneCreation { get; set; }

        [Display(Name = "Region")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public string Region { get; set; }

        [Display(Name = "Abbreviation")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        [MaxLength(10, ErrorMessage = "{1} caracteres maximum!")]
        public string Abbreviation { get; set; }

        [Display(Name = "Winnings")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        [Column(TypeName = "decimal(10,2)")]
        [DisplayFormat(DataFormatString = "{0:c2}")]
        public int MontantGagnee { get; set; }


        [ForeignKey("Parent")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public int IdParent { get; set; }

        public Parent Parent { get; set; }
        
        
    }
}
