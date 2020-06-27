using NarcissisticNumberDojo;
using System.Collections.Generic;
using Xunit;

namespace NarcissisticNumberDojoTest
{
    public class NarcissisticNumberListShould
    {
        [Fact]
        public void Return_1_to_9_when_n_is_9()
        {
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, NarcissisticNumber.NarcissisticNumberList(9));
        }

        [Fact]
        public void Return_1_to_9_when_n_is_99()
        {
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, NarcissisticNumber.NarcissisticNumberList(99));
        }

        [Fact]
        public void Return_1_to_9_153_when_153()
        {
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 153 }, NarcissisticNumber.NarcissisticNumberList(153));
        }
    }
}
