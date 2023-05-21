using Microsoft.AspNetCore.Mvc;

namespace PacificSunscapesWebsite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
