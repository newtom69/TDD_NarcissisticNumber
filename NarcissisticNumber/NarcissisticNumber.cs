using System;
using System.Collections.Generic;
using System.Text;

namespace NarcissisticNumberDojo
{
    public class NarcissisticNumber
    {
        public static List<int> NarcissisticNumberList(int maxNumber)
        {
            List<int> narcissisticNumbers = new List<int>();
            for (int i = 1; i <= maxNumber; i++)
            {
                if ((int)Math.Pow(i,1) == i)
                    narcissisticNumbers.Add(i);
            }


            return narcissisticNumbers;
        }
    }
}
