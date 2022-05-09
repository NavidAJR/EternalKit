using Microsoft.AspNetCore.Mvc;

namespace EternalKit.Site.Areas.Text.Controllers
{
    [Area("Text")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
