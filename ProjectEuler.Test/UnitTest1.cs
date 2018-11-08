using System;
using ProjectEuler.ConsoleApp;
using Xunit;

namespace ProjectEuler.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(28, new int[] { 1, 2, 4, 7, 14 })]
        [InlineData(12, new int[] { 1, 2, 3, 4, 6 })]
        public void FindDivisors(int number, int[] expectDivisors)
        {
            var sut = new Calculate();
            var result = sut.FindDivisors(number);
            Assert.Equal(expectDivisors, result);
        }

        [Fact]
        public void FindAbundant()
        {
            var sut = new Calculate();
            var result = sut.IsAbundant(12);
            Assert.Equal(true, result);
        }

        [Fact]
        public void FindListAbundant()
        {
            var sut = new Calculate();
            var result = sut.FindListAbundant(20);
            Assert.Equal(new int[] { 12, 18 }, result);
        }

        [Fact]
        public void FindSumOfTheNumber()
        {
            var sut = new Calculate();
            var result = sut.Calc(31);
            Assert.Equal(411, result);
        }
    }
}
