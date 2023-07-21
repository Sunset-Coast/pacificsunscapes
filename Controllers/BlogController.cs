using Microsoft.AspNetCore.Mvc;

namespace PacificSunscapes3.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
