﻿using Microsoft.AspNetCore.Mvc;

namespace EternalKit.Site.Areas.Convert.Controllers
{
    [Area("Convert")]
    public class LengthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
