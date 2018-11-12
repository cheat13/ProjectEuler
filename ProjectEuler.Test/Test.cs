using System;
using ProjectEuler.ConsoleApp;
using Xunit;

namespace ProjectEuler.Test
{
    public class Test
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        [InlineData(10, false)]
        public void CheckIsPrimeNumber(int factors, bool expect)
        {
            var sut = new Calculate();
            var result = sut.IsPrimeNumber(factors);
            Assert.Equal(expect, result);
        }

        [Fact]
        public void FindPrimefactors()
        {
            var sut = new Calculate();
            var result = sut.Primefactors(13195);
            Assert.Equal(new double[] { 5, 7, 13, 29 }, result);
        }

        [Fact]
        public void FindLargestPrimefactors()
        {
            var sut = new Calculate();
            var result = sut.TheLargestPF(13195);
            Assert.Equal(29, result);
        }

        [Fact]
        public void FindLargestPrimefactorsNewVersion()
        {
            var sut = new Calculate();
            var result = sut.Calc(13195);
            Assert.Equal(29, result);
        }
    }
}
