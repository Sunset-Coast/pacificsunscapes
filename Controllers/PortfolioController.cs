using Microsoft.AspNetCore.Mvc;

namespace PacificSunscapes3.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
