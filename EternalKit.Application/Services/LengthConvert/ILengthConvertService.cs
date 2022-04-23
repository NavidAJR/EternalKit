﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EternalKit.Application.Dto;

namespace EternalKit.Application.Services.LengthConvert
{
    public interface ILengthConvertService
    {
        ResultDto<decimal> Execute(LengthConvertDto input);
    }
}
