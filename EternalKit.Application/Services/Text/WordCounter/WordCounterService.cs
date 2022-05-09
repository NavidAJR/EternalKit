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
        public ResultDto<int> Execute(string text)
        {
            var words = text.Split(' ');
            return new ResultDto<int>()
            {
                IsSuccess = true,
                Message = "عملیات با موفقیت انجام شد.",
                Data = words.Length
            };
        }
    }
}
