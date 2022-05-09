using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EternalKit.Application.Dto;

namespace EternalKit.Application.Services.Text.LineCounter
{
    public class LineCounterService:ILineCounterService
    {
        public ResultDto<long> Execute(string text)
        {
            return new ResultDto<long>
            {
                IsSuccess = true,
                Message = "عملیات با موفقیت انجام شد.",
                Data = text.Split('\n').Length
            };
        }
    }
}
