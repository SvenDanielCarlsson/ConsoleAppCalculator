using System;
using Xunit;

namespace ConsoleAppCalculator.Tests
{
    public class CalcTests
    {
        //START OF ADD
        [Theory]
        [InlineData(-2, 5, 3)]
        [InlineData(2, -5, -3)]
        [InlineData(2, 5, 7)]
        [InlineData(-2, -5, -7)]
        [InlineData(-24.5, 27.2, 2.7)]
        [InlineData(24.5, -27.2, -2.7)]
        [InlineData(24.5, 27.2, 51.7)]
        [InlineData(-24.5, -27.2, -51.7)]
        public void Add_MixInput(decimal num1, decimal num2, decimal expected)
        {
            //ARRANGE            
            //ACT
            decimal actual = Calc.Add(num1, num2);
            //ASSERT
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Add_Overload_PositiveInput()
        {
            //ARRANGE
            decimal expected = 37.1M;
            decimal[] multiAdd = new decimal[5];
            multiAdd[0] = 20;
            multiAdd[1] = 1;
            multiAdd[2] = 12.4M;
            multiAdd[3] = 1;
            multiAdd[4] = 2.7M;

            //ACT
            decimal actual = Calc.Add(multiAdd);

            //ASSERT
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Add_Overload_NegativeStart()
        {
            //ARRANGE
            decimal expected = -2.9M;
            decimal[] multiAdd = new decimal[5];
            multiAdd[0] = -20;
            multiAdd[1] = 1;
            multiAdd[2] = 12.4M;
            multiAdd[3] = 1;
            multiAdd[4] = 2.7M;

            //ACT
            decimal actual = Calc.Add(multiAdd);

            //ASSERT
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Add_Overload_MixInput()
        {
            //ARRANGE
            decimal expected = 2;
            decimal[] multiAdd = new decimal[5];
            multiAdd[0] = -20;
            multiAdd[1] = 0;
            multiAdd[2] = -5.4M;
            multiAdd[3] = 30.1M;
            multiAdd[4] = -2.7M;

            //ACT
            decimal actual = Calc.Add(multiAdd);

            //ASSERT
            Assert.Equal(expected, actual);
        }//END OF ADD



        //  START OF SUBTRACT
        [Theory]
        [InlineData(0, 5, -5)]
        [InlineData(-2, 5, -7)]
        [InlineData(2, -5, 7)]
        [InlineData(2, 5, -3)]
        [InlineData(-2, -5, 3)]
        [InlineData(-4.5, 7.2, -11.7)]
        [InlineData(4.5, -7.2, 11.7)]
        [InlineData(4.5, 7.2, -2.7)]
        [InlineData(-4.5, -7.2, 2.7)]
        public void Subtract_GoodInput(decimal num1, decimal num2, decimal expected)
        {
            //ARRANGE
            //ACT
            decimal actual = Calc.Subtract(num1, num2);
            //ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subtract_Overload_ZeroStart_01()
        {
            //Arrange
            decimal expected = 2;
            decimal[] multiSub = new decimal[4];
            multiSub[0] = 0;
            multiSub[1] = 5;
            multiSub[2] = 2;
            multiSub[3] = -9;

            //Act
            decimal actual = Calc.Subtract(multiSub);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Subtract_Overload_ZeroStart_02()
        {
            //Arrange
            string B = null;
            decimal testA = Convert.ToDecimal(B);
            decimal expected = 12;
            decimal[] multiSub = new decimal[4];
            multiSub[0] = testA;
            multiSub[1] = -5;
            multiSub[2] = 2;
            multiSub[3] = -9;

            //Act
            decimal actual = Calc.Subtract(multiSub);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Subtract_Overload_PositiveInput()
        {
            //ARRANGE
            decimal expected = 2.9M;
            decimal[] multiSub = new decimal[5];
            multiSub[0] = 20;
            multiSub[1] = 1;
            multiSub[2] = 12.4M;
            multiSub[3] = 1;
            multiSub[4] = 2.7M;

            //ACT
            decimal actual = Calc.Subtract(multiSub);

            //ASSERT
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Subtract_Overload_NegativeStart()
        {
            //ARRANGE
            decimal expected = -37.1M;
            decimal[] multiSub = new decimal[5];
            multiSub[0] = -20;
            multiSub[1] = 1;
            multiSub[2] = 12.4M;
            multiSub[3] = 1;
            multiSub[4] = 2.7M;

            //ACT
            decimal actual = Calc.Subtract(multiSub);

            //ASSERT
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Subtract_Overload_MixInput()
        {
            //ARRANGE
            decimal expected = -42M;
            decimal[] multiSub = new decimal[5];
            multiSub[0] = -20;
            multiSub[1] = 0;
            multiSub[2] = -5.4M;
            multiSub[3] = 30.1M;
            multiSub[4] = -2.7M;

            //ACT
            decimal actual = Calc.Subtract(multiSub);

            //ASSERT
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Subtract_Overload_UlfMix()
        {
            //ARRANGE
            decimal expected = -60.6M;
            decimal[] multiSub = new decimal[4];
            multiSub[0] = -2.2M;
            multiSub[1] = 5.5M;
            multiSub[2] = -8.2M;
            multiSub[3] = 61.1M;

            //ACT
            decimal actual = Calc.Subtract(multiSub);

            //ASSERT
            Assert.Equal(expected, actual);
        }//END OF SUBTRACT


        //START OF DIVIDER
        [Theory]
        [InlineData(0, 1, 0)]
        [InlineData(0, -1, 0)]
        [InlineData(5, 2, 2.5)]
        [InlineData(-5, 2, -2.5)]
        [InlineData(-5, -2, 2.5)]
        public void Divider_MixInputs(decimal num1, decimal num2, decimal expected)
        {
            //ARRANGE
            //ACT
            decimal actual = Calc.Divider(num1, num2);
            //ASSERT
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Divider_DivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => //Still a weird thing
           {
               decimal actual = Calc.Divider(5, 0);
           });
        }// END OF DIVIDER

        //START OF MULTIPLIER
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(-1, -1, 1)]
        [InlineData(-1, 1, -1)]
        [InlineData(1, -1, -1)]
        [InlineData(1.5, -3.7, -5.55)]
        [InlineData(-1.5, 3.7, -5.55)]
        [InlineData(100, -70, -7000)]
        [InlineData(1, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(-1, 0, 0)]
        [InlineData(0,-1, 0)]

        public void Multiplier_MixInputs(decimal num1, decimal num2, decimal expected)
        {
            //ARRANGE
            //ACT
            decimal actual = Calc.Multplier(num1, num2);
            //ASSERT
            Assert.Equal(expected, actual);
        }// END OF MULTIPLYER

        //START OF EXPONENTER
        [Theory]
        [InlineData(1, 0, 1)]
        [InlineData(0, 1, 0)]
        [InlineData(30, 0, 1)]
        [InlineData(30, 1, 30)]
        [InlineData(1, 1.5, 1)]
        [InlineData(10, -1, 0.1)]
        [InlineData(-1, 10, -1)]
        [InlineData(-1, -10, -1)]

        public void Exponenter_MixInputs(decimal num1, decimal num2, decimal expected)
        {
            //Arrange
            //Act
            double actual = Calc.Exponenter(num1, num2);
            //Assert
            Assert.Equal((double)expected, actual);
        }
    }
}
