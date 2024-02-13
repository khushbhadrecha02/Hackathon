using Microsoft.AspNetCore.Mvc;

namespace Hackathon.Areas.ACC.Controllers
{
    public class ACCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
