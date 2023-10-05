using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
