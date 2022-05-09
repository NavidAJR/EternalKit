using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EternalKit.Application.Services.Text
{
    public class TextInfoDto
    {
        [Required(ErrorMessage = "لطفا متن را وارد کنید")]
        public string Text { get; set; }

        public long CharactersCount { get; set; }

        public long WordsCount { get; set; }

        public long LinesCount { get; set; }
    }
}
