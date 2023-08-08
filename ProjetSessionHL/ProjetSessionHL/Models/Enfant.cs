using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjetSessionHL.Models
{
    public class Enfant
    {
        [Key]
        public int Id { get; set; }

        public string ImgFile { get; set; }

        [Display(Name = "Nom")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} requis")]
        [MaxLength(30, ErrorMessage = "{1} caracteres maximum!")]
        public string Nom { get; set; }

        [MaxLength(1000, ErrorMessage = "{1} caracteres maximum!")]
        public string Description { get; set; }

        [Display(Name = "Location")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} requis")]
        public string Location { get; set; }

        [Display(Name = "Possède Site")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} requis")]
        public bool PossedeSite { get; set; }

        public string Site { get; set; }

        [Display(Name = "Année Création")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} requis")]
        public int AnneCreation { get; set; }

        [Display(Name = "Région")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} requis")]
        public string Region { get; set; }

        [Display(Name = "Abbréviation")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} requis")]
        [MaxLength(10, ErrorMessage = "{1} caracteres maximum!")]
        public string Abbreviation { get; set; }

        [Display(Name = "Montant Gagnée")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} requis")]
        [Column(TypeName = "decimal(10,2)")]
        [DisplayFormat(DataFormatString = "{0:c2}")]
        public int MontantGagnee { get; set; }


        [ForeignKey("Parent")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} requis")]
        public int IdParent { get; set; }

        public Parent Parent { get; set; }
        
        
    }
}
