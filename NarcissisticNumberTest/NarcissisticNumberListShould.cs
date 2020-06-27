using NarcissisticNumberDojo;
using System;
using System.Collections.Generic;
using Xunit;

namespace NarcissisticNumberDojoTest
{
    public class NarcissisticNumberListShould
    {
        [Fact]
        public void Return_1_when_1()
        {
            Assert.Equal(new List<int> { 1 }, NarcissisticNumber.NarcissisticNumberList(1));
        }
    }
}
