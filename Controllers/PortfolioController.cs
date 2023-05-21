using Microsoft.AspNetCore.Mvc;

namespace PacificSunscapesWebsite.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
