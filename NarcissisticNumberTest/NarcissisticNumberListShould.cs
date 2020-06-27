using NarcissisticNumberDojo;
using System.Collections.Generic;
using System;
using Xunit;

namespace NarcissisticNumberDojoTest
{
    public class NarcissisticNumberListShould
    {
        [Fact]
        public void Return_1_to_9_when_n_is_9()
        {
            Assert.Equal(new List<Int64> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, NarcissisticNumber.NarcissisticNumberList(9));
        }

        [Fact]
        public void Return_1_to_9_when_n_is_99()
        {
            Assert.Equal(new List<Int64> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, NarcissisticNumber.NarcissisticNumberList(99));
        }

        [Fact]
        public void Return_1_to_9_153_when_153()
        {
            Assert.Equal(new List<Int64> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 153 }, NarcissisticNumber.NarcissisticNumberList(153));
        }

        [Fact]
        public void Return_1_to_9_153_370_when_370()
        {
            Assert.Equal(new List<Int64> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 153, 370 }, NarcissisticNumber.NarcissisticNumberList(370));
        }

        [Fact]
        public void Return_good_list_when_93084()
        {
            Assert.Equal(new List<Int64> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 153, 370, 371, 407, 1634, 8208, 9474, 54748, 92727, 93084 }, NarcissisticNumber.NarcissisticNumberList(93084));
        }
    }
}
