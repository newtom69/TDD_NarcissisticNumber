using System;
using System.Collections.Generic;
using System.Text;

namespace NarcissisticNumberDojo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var narcissisticNumbers = NarcissisticNumber.NarcissisticNumberList(5000000000);
            foreach (var number in narcissisticNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
