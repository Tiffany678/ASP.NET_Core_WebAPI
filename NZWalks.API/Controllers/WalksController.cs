using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    public class WalksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
