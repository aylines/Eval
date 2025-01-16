using Microsoft.AspNetCore.Mvc;

namespace InstaWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
