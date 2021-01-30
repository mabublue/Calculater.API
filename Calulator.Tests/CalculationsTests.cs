using Calculator.Api.Services;
using System;
using Xunit;

namespace Calulator.Tests
{
    public class CalculationsTests
    {
        [Theory]
        [InlineData(-1, 10, 9)]
        [InlineData(0, 0, 0)]
        [InlineData(110.5 ,77.3, 187.8)]
        public void Calculations_Add(decimal value1, decimal value2, decimal expectedResult)
        {
            var actualResult = Calculations.Add(value1, value2);

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(-1, 10, -11)]
        [InlineData(0, 0, 0)]
        [InlineData(110.5, 77.3, 33.2)]
        public void Calculations_Subtract(decimal value1, decimal value2, decimal expectedResult)
        {
            var actualResult = Calculations.Subtract(value1, value2);

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(-1, 10, -10)]
        [InlineData(0, 0, 0)]
        [InlineData(110.5, 77.3, 8541.65)]
        public void Calculations_Multiply(decimal value1, decimal value2, decimal expectedResult)
        {
            var actualResult = Calculations.Multiply(value1, value2);

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(-1, 10, "-0.1")]
        [InlineData(0, 10, "0")]
        [InlineData(110.5, 77.3, "1.4294954721862871927554980595")]
        public void Calculations_Divide(decimal value1, decimal value2, string stringResult)
        {
            var expectedResult = Convert.ToDecimal(stringResult); // Required conversion as InlineData requires constants
                                                                  // and it is not possible to create a decimal as a constant
            var actualResult = Calculations.Divide(value1, value2);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Calculations_Divide_ByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Calculations.Divide(123.456M, 0.0M));
        }
    }
}
