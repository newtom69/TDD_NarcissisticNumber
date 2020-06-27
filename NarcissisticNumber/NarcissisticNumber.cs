using System;
using System.Collections.Generic;

namespace NarcissisticNumberDojo
{
    public class NarcissisticNumber
    {
        public static IEnumerable<UInt64> NarcissisticNumberList(UInt64 maxNumber)
        {
            List<UInt64> narcissisticNumbers = new List<UInt64>();
            for (UInt64 number = 1; number <= maxNumber; number++)
            {
                if (IsNarcissisticNumber(number))
                    yield return number;
            }
        }

        public static bool IsNarcissisticNumber(UInt64 number)
        {
            var digits = SplitNumberToDigits(number);
            UInt64 resultNarcissisticNumber = 0;
            for (int digitIndex = 0; digitIndex < digits.Count; digitIndex++)
            {
                resultNarcissisticNumber += (UInt64) Math.Pow(digits[digitIndex], digits.Count);
            }
            if (resultNarcissisticNumber == number)
                return true;
            return false;
        }

        public static List<int> SplitNumberToDigits(UInt64 number)
        {
            List<int> result = new List<int>();
            UInt64 numberDivedBy10;
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
