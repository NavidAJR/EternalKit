using EternalKit.Application.Services.LengthConvert;
using EternalKit.Application.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace EternalKit.Site.Areas.Convert.Controllers
{
    [Area("Convert")]
    public class LengthController : Controller
    {
        private readonly ILengthConvertService _lengthConvertService;

        public LengthController(ILengthConvertService lengthConvertService)
        {
            _lengthConvertService = lengthConvertService;
        }


        public IActionResult Index()
        {
            return View(new LengthConvertDto());
        }

        [HttpPost]
        public IActionResult Index(LengthConvertDto input)
        {
            input.Result = _lengthConvertService.Execute(input).Data;
            return View(input);
        }
    }
}
