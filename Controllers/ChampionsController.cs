using Microsoft.AspNetCore.Mvc;

namespace Checkpoint1.Controllers
{
    public class ChampionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
