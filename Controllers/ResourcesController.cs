using Microsoft.AspNetCore.Mvc;

namespace PacificSunscapesWebsite.Controllers
{
    public class ResourcesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
