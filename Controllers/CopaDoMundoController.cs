using Microsoft.AspNetCore.Mvc;

namespace Checkpoint1.Controllers
{
    public class CopaDoMundoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
