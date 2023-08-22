using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetSessionHL.Models;

namespace ProjetSessionHL.ViewModels
{
    public class EnfantVM
    {
        public Enfant Enfant { get; set; }

        public IEnumerable<SelectListItem>? ParentSelectList { get; set; }
    }
}
