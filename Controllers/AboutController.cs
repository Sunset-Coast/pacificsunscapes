using Microsoft.AspNetCore.Mvc;

namespace PacificSunscapesWebsite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
