using Microsoft.AspNetCore.Mvc;

namespace PacificSunscapes3.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
