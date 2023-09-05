using ProjetSessionHL.Models;
using ProjetSessionHL.ViewModels;

namespace ProjetSession_Tests
{
    internal class EnfantVM<T> : EnfantVM
    {
        public bool IsCreate { get; set; }
        public int Id { get; set; }
        public Enfant Entity { get; set; }
        public object SelectLists { get; set; }
    }
}