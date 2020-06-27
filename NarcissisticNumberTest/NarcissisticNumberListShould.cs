using NarcissisticNumberDojo;
using System;
using System.Collections.Generic;
using Xunit;

namespace NarcissisticNumberDojoTest
{
    public class NarcissisticNumberListShould
    {
        [Fact]
        public void Return_1_to_n_when_n_is_digit()
        {
            Assert.Equal(new List<int> {1}, NarcissisticNumber.NarcissisticNumberList(1));
            Assert.Equal(new List<int> {1, 2}, NarcissisticNumber.NarcissisticNumberList(2));
            Assert.Equal(new List<int> {1, 2, 3}, NarcissisticNumber.NarcissisticNumberList(3));
            Assert.Equal(new List<int> {1, 2, 3, 4}, NarcissisticNumber.NarcissisticNumberList(4));
            Assert.Equal(new List<int> {1, 2, 3, 4, 5}, NarcissisticNumber.NarcissisticNumberList(5));
            Assert.Equal(new List<int> {1, 2, 3, 4, 5, 6}, NarcissisticNumber.NarcissisticNumberList(6));
            Assert.Equal(new List<int> {1, 2, 3, 4, 5, 6, 7}, NarcissisticNumber.NarcissisticNumberList(7));
            Assert.Equal(new List<int> {1, 2, 3, 4, 5, 6, 7, 8}, NarcissisticNumber.NarcissisticNumberList(8));
            Assert.Equal(new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9}, NarcissisticNumber.NarcissisticNumberList(9));
        }

        [Fact]
        public void Return_1_to_9_when_n_is_2digits()
        {
            for (int i = 10; i <= 99; i++)
            {
                Assert.Equal(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, NarcissisticNumber.NarcissisticNumberList(i));
            }
        }
    }
}
