using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Admin.Controllers
{
    public class Settings : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
