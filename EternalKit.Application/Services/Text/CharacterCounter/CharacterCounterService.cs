using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EternalKit.Application.Dto;
using EternalKit.Domain.Entities;

namespace EternalKit.Application.Services.Text.CharacterCounter
{
    public class CharacterCounterService : ICharacterCounterService
    {
        public ResultDto<long> Execute(string text, bool countSpace, bool countPunctuationCharacters)
        {
            if (!countPunctuationCharacters)
            {
                foreach (var punctuation in Punctuation.PunctuationCharacters)
                {
                    if (text.Contains(punctuation))
                        text = text.Replace(punctuation, "");
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
