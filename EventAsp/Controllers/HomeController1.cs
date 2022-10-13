using Microsoft.AspNetCore.Mvc;

namespace EventAsp.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
