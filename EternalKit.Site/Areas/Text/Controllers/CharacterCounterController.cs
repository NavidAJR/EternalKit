using EternalKit.Application.Services.Text;
using EternalKit.Application.Services.Text.CharacterCounter;
using EternalKit.Application.Services.Text.LineCounter;
using EternalKit.Application.Services.Text.WordCounter;
using Microsoft.AspNetCore.Mvc;

namespace EternalKit.Site.Areas.Text.Controllers
{
    [Area("Text")]
    public class CharacterCounterController : Controller
    {
        private readonly ICharacterCounterService _characterCounterService;
        private readonly IWordCounterService _wordCounterService;
        private readonly ILineCounterService _lineCounterService;

        public CharacterCounterController(ICharacterCounterService characterCounterService, IWordCounterService wordCounterService, ILineCounterService lineCounterService)
        {
            _characterCounterService = characterCounterService;
            _wordCounterService = wordCounterService;
            _lineCounterService = lineCounterService;
        }


        public IActionResult Index()
        {
            return View(new CharacterCounterDto());
        }

        [HttpPost]
        public IActionResult Index(CharacterCounterDto input)
        {
            input.CharactersCount = _characterCounterService.Execute(input.Text, input.CountSpace, input.CountPunctuationCharacters).Data;
            input.WordsCount = _wordCounterService.Execute(input.Text, input.CountPunctuationCharacters).Data;
            input.LinesCount = _lineCounterService.Execute(input.Text).Data;

            return View(input);
        }
    }
}
