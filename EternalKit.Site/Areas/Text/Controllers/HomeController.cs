using Microsoft.AspNetCore.Mvc;

namespace EternalKit.Site.Areas.Text.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
