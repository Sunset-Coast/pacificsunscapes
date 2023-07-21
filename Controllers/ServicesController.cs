using Microsoft.AspNetCore.Mvc;

namespace PacificSunscapes3.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
