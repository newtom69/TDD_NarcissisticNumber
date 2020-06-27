using NarcissisticNumberDojo;
using System.Collections.Generic;
using Xunit;

namespace NarcissisticNumberDojoTest
{
    public class SplitNumberToDigitsShould
    {
        [Fact]
        public void Return_n_when_n_is_1digit()
        {
            for (int i = 1; i <= 9; i++)
            {
                Assert.Equal(new List<int> { i }, NarcissisticNumber.SplitNumberInDigits(i));
            }
        }

        [Fact]
        public void Return_0_1_when_n_is_10()
        {
            Assert.Equal(new List<int> { 0, 1 }, NarcissisticNumber.SplitNumberInDigits(10));
        }

        [Fact]
        public void Return_3_1_when_n_is_13()
        {
            Assert.Equal(new List<int> { 3, 1 }, NarcissisticNumber.SplitNumberInDigits(13));
        }

        [Fact]
        public void Return_8_5_when_n_is_58()
        {
            Assert.Equal(new List<int> { 8, 5 }, NarcissisticNumber.SplitNumberInDigits(58));
        }

        [Fact]
        public void Return_5_7_8_when_n_is_875()
        {
            Assert.Equal(new List<int> { 5, 7, 8 }, NarcissisticNumber.SplitNumberInDigits(875));
        }
    }
}