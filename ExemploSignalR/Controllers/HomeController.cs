using Microsoft.AspNetCore.Mvc;

namespace ExemploSignalR.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
