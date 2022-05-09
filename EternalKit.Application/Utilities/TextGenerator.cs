using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EternalKit.Domain.Entities;

namespace EternalKit.Application.Utilities
{
    public static class TextGenerator
    {
        public static string GenerateLengthConvertResultText(decimal fromValue, decimal fromUnitValue, decimal result, decimal toUnitValue, int digitsAfterDecimalPoint = 3)
        {
            var fromUnitText = LengthConversionFactor.LengthUnits.FirstOrDefault(u => u.Value == fromUnitValue).Key;
            var toUnitText = LengthConversionFactor.LengthUnits.FirstOrDefault(u => u.Value == toUnitValue).Key;

            return
                @$"<p>مقدار <span class=""text-primary"">{fromValue} {fromUnitText}</span> برابر با <span class=""text-success"">{result.Separate(digitsAfterDecimalPoint)} {toUnitText}</span> است</p>";
        }
    }
}
