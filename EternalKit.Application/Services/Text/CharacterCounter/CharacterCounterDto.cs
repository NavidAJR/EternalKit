using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EternalKit.Application.Services.Text.CharacterCounter
{
    public class CharacterCounterDto : TextInfoDto
    {
        public bool CountSpace { get; set; }
        public bool CountPunctuationCharacters { get; set; }
    }
}
