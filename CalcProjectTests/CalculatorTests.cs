using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_TwoPositiveIntegers_ShouldReturnProperValue()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var result = calc.Add(2, 3);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Add_APositiveAndANegative_ShouldReturnProperValue()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var result = calc.Add(2, -3);

            // Assert
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Divide_TwoPositiveIntegers_ShouldReturnProperValue()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var result = calc.Divide(2, 2);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Divide_DividingByZero_ShouldThrowException()
        {
            // Arrange
            var calc = new Calculator();

            // Assert
            Assert.Throws<DivideByZeroException>(() => calc.Divide(2, 0));
        }

        [Test]
        public void Divide_APositiveAndANegative_ShouldReturnProperValue()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var result = calc.Divide(2, -2);

            // Assert
            Assert.That(result, Is.EqualTo(-1));
        }

        [TestCase(1, 2, 0.5)]
        [TestCase(1, -2, -0.5)]
        public void Divide_ShouldReturnCorrectValues(int x, int y, double expected)
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var result = calc.Divide(x, y);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
