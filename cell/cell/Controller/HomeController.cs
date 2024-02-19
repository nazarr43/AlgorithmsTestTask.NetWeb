using Microsoft.AspNetCore.Mvc;

namespace cell.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
