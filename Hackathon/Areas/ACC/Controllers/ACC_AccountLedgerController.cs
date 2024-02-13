using Microsoft.AspNetCore.Mvc;

namespace Hackathon.Areas.ACC.Controllers
{
    public class ACC_AccountLedgerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
