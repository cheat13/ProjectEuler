using System;
using ProjectEuler.ConsoleApp;
using Xunit;

namespace ProjectEuler.Test
{
    public class UnitTest1
    {
        [Fact]
        public void FindSequence()
        {
            var sut = new Calculate();
            var result = sut.FindSequence(90);
            Assert.Equal(new int[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 }, result);
        }

        [Fact]
        public void Calc()
        {
            var sut = new Calculate();
            var result = sut.Calc(90);
            Assert.Equal(44, result);
        }
    }
}
