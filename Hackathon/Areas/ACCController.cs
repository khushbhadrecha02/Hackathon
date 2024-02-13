using Microsoft.AspNetCore.Mvc;

namespace Hackathon.Areas
{
    public class ACCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
