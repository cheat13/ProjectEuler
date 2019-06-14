using System;
using System.Collections.Generic;
using ProjectEuler.ConsoleApp;
using Xunit;

namespace ProjectEuler.Test
{
    public class Test
    {
        [Theory]
        [InlineData(1634, 9474, 4, 19316)]
        public void CheckDigit(int min, int max, int pow, double expected)
        {
            var sut = new Calculate();
            var result = sut.Calc(min, max, pow);
            Assert.Equal(expected, result);
        }
    }
}
