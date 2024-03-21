using Microsoft.AspNetCore.Mvc;

namespace Checkpoint1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
