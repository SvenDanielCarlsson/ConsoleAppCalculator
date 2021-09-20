using System;
using Xunit;

namespace ConsoleAppCalculator.Tests
{
    public class CalcTests
    {
        [Fact]
        public void Add_GoodInput()
        {
            //ARRANGE
            double expected = 8;
            //ACT
            double actual = Calc.Add(-2, 10);
            //ASSERT
            Assert.Equal(expected, actual);
        }
        public void Add_BadInput()
        {
            //ARRANGE

            //ACT

            //ASSERT
        }
    }
}
