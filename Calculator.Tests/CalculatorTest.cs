using NUnit.Framework;
using CalculatorNamespace;
using System;

namespace Tests
{
    public class CalculatorTest
    {
        [Test]
        public void Add_TwoPositivIntegers_SumOfIntegers()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int expected = 5;
            // Act
            int result = calculator.AddIntegers(3, 2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_TwoNegativIntegers_SumOfIntegers()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int expected = -1;

            // Act
            int result = calculator.AddIntegers(-3, 2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_PositivAndZero_SumOfIntegers()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int expected = 6;

            // Act
            int result = calculator.AddIntegers(6, 0);

            // Asserts
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_PositivIntegerAndZero_CantDivideByZeroException()
        {
            //Arrange
            Calculator calculator = new Calculator();

            // Act
 
            // Assert
            Assert.Throws<DivideByZeroException>(() => calculator.DivideIntegers(6, 0));
        }

        [TestCase(12, 3, 4)]
        [TestCase(12, 2, 6)]
        [TestCase(12, 4, 3)]
        public void Divide_PositivIntegers_ReturnsProperValue(int dividend, int divisor, int expectedQuotient)
        {
            //Arrange
            Calculator calculator = new Calculator();

            // Act
            var quotient = calculator.DivideIntegers(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedQuotient, quotient);
        }
    }
}