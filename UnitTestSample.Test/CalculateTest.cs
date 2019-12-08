using System;
using UnitTestSample.Model;
using Xunit;

namespace UnitTestSample.Test
{
    public class CalculateTest
    {
        [Fact]
        public void Should_Return3_When_Add2And1()
        {
            Calculate calculate = new Calculate();
            int result = calculate.Add(2, 1);
            Assert.Equal(3, result);
        }
    }
}
