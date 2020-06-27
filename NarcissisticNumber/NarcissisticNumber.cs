using System;
using System.Collections.Generic;

namespace NarcissisticNumberDojo
{
    public class NarcissisticNumber
    {
        public static IEnumerable<Int64> NarcissisticNumberList(Int64 maxNumber)
        {
            List<Int64> narcissisticNumbers = new List<Int64>();
            for (Int64 number = 1; number <= maxNumber; number++)
            {
                if (IsNarcissisticNumber(number))
                    yield return number;
            }
        }

        public static bool IsNarcissisticNumber(Int64 number)
        {
            var digits = SplitNumberInDigits(number);
            Int64 resultNarcissisticNumber = 0;
            for (int digitIndex = 0; digitIndex < digits.Count; digitIndex++)
            {
                resultNarcissisticNumber += (Int64) Math.Pow(digits[digitIndex], digits.Count);
            }
            if (resultNarcissisticNumber == number)
                return true;
            return false;
        }

        public static List<int> SplitNumberInDigits(Int64 number)
        {
            List<int> result = new List<int>();
            Int64 numberDivedBy10;
            while ((numberDivedBy10 = number / 10) > 0)
            {
                result.Add((int) (number - numberDivedBy10 * 10));
                number = numberDivedBy10;
            }
            result.Add((int) number);
            return result;
        }
    }
}
