using Microsoft.AspNetCore.Mvc;

namespace PacificSunscapes3.Controllers
{
    public class PlantCareController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
