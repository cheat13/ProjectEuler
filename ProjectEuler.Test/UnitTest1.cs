using System;
using ProjectEuler.ConsoleApp;
using Xunit;

namespace ProjectEuler.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var sut = new Calculate();
            var result = sut.Calc(10);
            Assert.Equal(23,result);
        }
    }
}
