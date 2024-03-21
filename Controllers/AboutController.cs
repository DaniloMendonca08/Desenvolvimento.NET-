using Microsoft.AspNetCore.Mvc;

namespace Checkpoint1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
