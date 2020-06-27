using System;
using System.Collections.Generic;

namespace NarcissisticNumberDojo
{
    public class NarcissisticNumber
    {
        public static List<int> NarcissisticNumberList(int maxNumber)
        {
            List<int> narcissisticNumbers = new List<int>();
            for (int number = 1; number <= maxNumber; number++)
            {
                var digits = SplitNumberInDigits(number);
                int resultNarcissisticNumber = 0;
                for (int digitIndex = 0; digitIndex < digits.Count; digitIndex++)
                {
                    resultNarcissisticNumber += (int) Math.Pow(digits[digitIndex], digits.Count);
                }

                if (resultNarcissisticNumber == number)
                    narcissisticNumbers.Add(number);
            }
            return narcissisticNumbers;
        }


        public static List<int> SplitNumberInDigits(int number)
        {
            List<int> result = new List<int>();
            int numberDivedBy10;
            while ((numberDivedBy10 = number / 10) > 0)
            {
                result.Add(number - numberDivedBy10 * 10);
                number = numberDivedBy10;
            }
            result.Add(number);
            return result;
        }
    }
}
