using NarcissisticNumberDojo;
using System;
using System.Collections.Generic;
using Xunit;

namespace NarcissisticNumberDojoTest
{
    public class NarcissisticNumberShould
    {
        [Fact]
        public void Test1()
        {
            List<int> expected = new List<int>();
            expected.Add(1);
            Assert.Equal(expected, NarcissisticNumber.NarcissisticNumberList(1));
        }
    }
}
