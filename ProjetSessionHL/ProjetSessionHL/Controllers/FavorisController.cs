using Microsoft.AspNetCore.Mvc;

namespace ProjetSessionHL.Controllers
{
    public class FavorisController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
