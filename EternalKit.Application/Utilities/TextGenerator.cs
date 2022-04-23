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
        public static string ConvertResultTextGenerator(decimal fromValue, decimal fromUnitValue, decimal result, decimal toUnitValue, int digitsAfterDecimalPoint)
        {
            var fromUnitText = LengthConversionFactor.LengthUnits.FirstOrDefault(u => u.Value == fromUnitValue).Key;
            var toUnitText = LengthConversionFactor.LengthUnits.FirstOrDefault(u => u.Value == toUnitValue).Key;

            return
                @$"<p>مقدار <span class=""text-primary"">{fromValue} {fromUnitText}</span> برابر با <span class=""text-success"">{result.DigitSeparatorWithDecimalPoint(digitsAfterDecimalPoint)} {toUnitText}</span> است</p>";
        }


        public static string DigitSeparatorWithDecimalPoint(this decimal input, int digitsAfterDecimalPoint)
        {
            if (!input.ToString().Contains('.'))
                return input.ToString("##,###");


            var inputString = input.ToString();
            var beforeDecimalPoint = inputString.Split('.')[0];
            var afterDecimalPoint = inputString.Split('.')[1];


            var separatedDigits = "";
            var separatorIndex = 0;
            foreach (var digit in beforeDecimalPoint.ToCharArray())
            {
                if (separatorIndex == 3)
                {
                    separatedDigits += ",";
                    separatorIndex = 0;
                }
                separatedDigits += digit;
                separatorIndex++;
            }


            if (afterDecimalPoint.Length >= digitsAfterDecimalPoint)
                return separatedDigits + "." + afterDecimalPoint.Substring(0, digitsAfterDecimalPoint);

            return separatedDigits + "." + afterDecimalPoint.Substring(0);
        }
    }
}
