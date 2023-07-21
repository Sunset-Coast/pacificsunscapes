using Microsoft.AspNetCore.Mvc;

namespace PacificSunscapes3.Controllers
{
    public class ResourcesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
