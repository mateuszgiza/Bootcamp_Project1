using NUnit.Framework;
using System;

namespace CalcProject.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_ValuesBiggerThan0_ShouldReturn5()
        {
            Calculator calc = new Calculator();

            int result = calc.Add(2, 3);

            Assert.AreEqual(5, result);

        }
        [Test]
        public void Add_ValuesLessThan0_ShouldReturnMinus5()
        {
            Calculator calc = new Calculator();

            int result = calc.Add(-2, -3);

            Assert.AreEqual(-5, result);

        }
        [Test]
        public void Add_ValuesBiggerAndLowerThan0_ShouldReturnMinus1()
        {
            Calculator calc = new Calculator();

            int result = calc.Add(2, -3);

            Assert.AreEqual(-1, result);

        }
        [Test]
        public void Add_TwoPositiveIntegers_ShouldReturnProperValue()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int result = calc.Add(2, 3);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Add_APositiveAndANegative_ShouldReturnProperValue()
        {
            // Arrange
            Calculator calc = new CalcProject.Calculator();

            // Act
            int result = calc.Add(2, -3);

            // Assert
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Divide_TwoPositiveIntegers_ShouldReturnProperValue()
        {
            // Arrange
            Calculator calc = new CalcProject.Calculator();

            // Act
            float result = calc.Divide(2, 2);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Divide_DividingByZero_ShouldThrowException()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Assert
            Assert.Throws<DivideByZeroException>(() => calc.Divide(2, 0));
        }

        [Test]
        public void Divide_APositiveAndANegative_ShouldReturnProperValue()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            float result = calc.Divide(2, -2);

            // Assert
            Assert.That(result, Is.EqualTo(-1));
        }

        [TestCase(1D, 2D, 0.5D)]
        [TestCase(3.5D, 2D, 1.75D)]
        [TestCase(1D, -2D, -0.5D)]
        public void Divide_ShouldReturnCorrectValues(double x, double y, double expected)
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            double result = calc.Divide(x, y);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [TestCase(1f, 2f, 0.5f)]
        [TestCase(3.5f, 2f, 1.75f)]
        [TestCase(1f, -2f, -0.5f)]
        public void Divide_ShouldReturnCorrectValues(float x, float y, double expected)
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            float result = calc.Divide(x, y);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [TestCase(1, 2, 0.5)]
        [TestCase(3.5, 2, 1.75)]
        //[TestCase(1f, -2f, -0.5f)]
        public void Divide_ShouldReturnCorrectValues(decimal x, decimal y, decimal expected)
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            decimal result = calc.Divide(x, y);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Divide_ValuesBiggerThan0_ShouldReturn2()
        {
            Calculator calc = new Calculator();

            float result = calc.Divide(4, 2);

            Assert.AreEqual(2, result);

        }
        [Test]
        [TestCase(20, 4, 5)]
        [TestCase(40, 10, 4)]
        [TestCase(0, 10, 0)]
        public void Divide_PositiveValues_ShouldReturnEffect(double a, double b, double effect)
        {
            Calculator calc = new Calculator();

            double result = calc.Divide(a, b);

            Assert.AreEqual(effect, result);

        }
        [Test]
        public void Divide_DivideBy0_ShouldThrowException()
        {
            Calculator calc = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calc.Divide(6, 0));

        }
        [TestCase(10, 0)]
        public void Divide_DivideDecimalBy0_ShouldThrowException(decimal x, decimal y)
        {
            Calculator calc = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calc.Divide(x, y));

        }
    }

}
