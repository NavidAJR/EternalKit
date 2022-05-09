using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EternalKit.Application.Dto;

namespace EternalKit.Application.Services.Text.CharacterCounter
{
    public class CharacterCounterService : ICharacterCounterService
    {
        private readonly string[] _punctuationCharacters = new string[]
        {
            ".", "?", "!", ",", ":", ";", "-", "{", "}", "[", "]", "(", ")", "\"", "..."
        };

        public ResultDto<long> Execute(string text, bool countSpace, bool countPunctuationCharacters)
        {
            if (!countPunctuationCharacters)
            {
                foreach (var punctuation in _punctuationCharacters)
                {
                    if (text.Contains(punctuation))
                        text = text.Replace(punctuation, " ");
                }
            }


            if (countSpace)
                return new ResultDto<long>()
                {
                    IsSuccess = true,
                    Message = "عملیات با موفقیت انجام شد.",
                    Data = text.ToCharArray().Length
                };


            return new ResultDto<long>()
            {
                IsSuccess = true,
                Message = "عملیات با موفقیت انجام شد.",
                Data = text.Replace(" ", "").ToCharArray().Length
            };
        }
    }
}
