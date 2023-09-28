using Microsoft.AspNetCore.Mvc;

namespace JavierB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        
        public IActionResult Kundeservice()
        {
            return View();
        }
    }
}
