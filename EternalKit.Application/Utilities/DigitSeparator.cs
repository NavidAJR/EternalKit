namespace EternalKit.Application.Utilities
{
    public static class DigitSeparator
    {
        public static string Separate(this decimal input, int digitsAfterDecimalPoint)
        {
            //To check if the number has decimal point.
            if (!input.ToString().Contains('.'))
                return input.ToString("##,###");


            //Split the number in two part: numbers before decimal point and numbers after decimal point.
            var inputString = input.ToString();
            var beforeDecimalPoint = inputString.Split('.')[0];
            var afterDecimalPoint = inputString.Split('.')[1];


            //Add , character after every 3 number.
            var mainPart = "";
            var separatorIndex = 0;
            foreach (var digit in beforeDecimalPoint.ToCharArray())
            {
                if (separatorIndex == 3)
                {
                    mainPart += ",";
                    separatorIndex = 0;
                }

                mainPart += digit;
                separatorIndex++;
            }


            if (afterDecimalPoint.Length >= digitsAfterDecimalPoint)
                return mainPart + "." + afterDecimalPoint.Substring(0, digitsAfterDecimalPoint);

            return mainPart + "." + afterDecimalPoint.Substring(0);
        }
    }
}
