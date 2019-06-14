using System;
using System.Collections.Generic;
using ProjectEuler.ConsoleApp;
using Xunit;

namespace ProjectEuler.Test
{
    public class Test
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1, 2, 3)]
        [InlineData(1, 3, 7)]
        [InlineData(2, 5, 15)]
        public void CheckDigit(int start, int end, int expected)
        {
            var sut = new Calculate();
            var result = sut.Calc(start, end);
            Assert.Equal(expected, result);
        }
    }
}
