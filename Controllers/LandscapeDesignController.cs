using Microsoft.AspNetCore.Mvc;

namespace PacificSunscapes3.Controllers
{
    public class LandscapeDesignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
