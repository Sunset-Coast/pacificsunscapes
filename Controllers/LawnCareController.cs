using Microsoft.AspNetCore.Mvc;

namespace PacificSunscapes3.Controllers
{
    public class LawnCareController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
