using System;
using Xunit;
using System.Linq;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,7,8,16)]
        [InlineData(8, 9, 18, 35)]
        public int Add(int num1, int num2, int num3, int expected)
        {
            //Arrange

            var add = new UnitTestMethods();

            //Act

            var actual = UnitTestMethods.AddMethod(num1, num2, num3);
            return actual;

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(17, 9, 8)]
        [InlineData(45, 10, 35)]
        [InlineData(35, 18, 17)]
        public int Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange

            var subtract = new UnitTestMethods();

            //Act

            var actual = UnitTestMethods.SubtractMethod(minuend, subtrhend);
            return actual;

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(17, 9, 153)]
        [InlineData(45, 10, 450)]
        [InlineData(35, 18, 630)]
        public int Multiply(int factor1, int factor2, int expected)
        {
            //Arrange

            var multipy = new UnitTestMethods();

            //Act

            var actual = UnitTestMethods.MultiplyMethod(factor1, factor2);
            return actual;

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(17, 9, 153)]
        [InlineData(45, 10, 450)]
        [InlineData(35, 18, 630)]
        public int Divide(int dividend, int divisor, int expected)
        {
            //Arrange

            var divide = new UnitTestMethods();

            //Act

            var actual = UnitTestMethods.DivideMethod(dividend, divisor);
            return actual;

            //Assert

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GetHey()
        {
            // Arrange
            var hey = new UnitTestMethods();

            // Act
            string actual = hey.GetHey();

            // Assert
            Assert.Equal("HEY HEY HEY!", actual);
        }

        [Fact]
        public void GetVictory()
        {
            //Arrange

            var victory = new UnitTestMethods();

            //Act

            string actual = victory.GetVictory();

            //Assert

            Assert.Equal("WE WON, AGAIN!", actual);

        }
    }
}
