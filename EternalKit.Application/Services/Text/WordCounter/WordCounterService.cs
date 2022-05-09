using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EternalKit.Application.Dto;
using EternalKit.Application.Services.Convert.Length;

namespace EternalKit.Application.Services.Text.WordCounter
{
    public class WordCounterService:IWordCounterService
    {
        private string[] _punctuationCharacters = new string[]
        {
            ".", "?", "!", ",", ":", ";", "-", "{", "}", "[", "]", "(", ")", "\"", "..."
        };

        public ResultDto<int> Execute(string text, bool countPunctuationCharacters)
        {

            if (!countPunctuationCharacters)
            {
                foreach (var punctuation in _punctuationCharacters)
                {
                    if (text.Contains(punctuation))
                        text = text.Replace(punctuation, " ");
                }
            }


            var words = text.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            return new ResultDto<int>()
            {
                IsSuccess = true,
                Message = "عملیات با موفقیت انجام شد.",
                Data = words.Length
            };
        }
    }
}
