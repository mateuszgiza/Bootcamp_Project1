﻿using CalcProject;
using NUnit.Framework;
using System;

namespace CalcProject.Tests
{
    class CalculatorTest
    {
        [Test]
        public void Add_AddingTwoPositiveNumbers_ReturnsResult()
        {
            var a = 2;
            var b = 3;

            var calculator = new Calculator();
            var sum = calculator.Add(a, b);

            Assert.That(sum, Is.EqualTo(5));
        }

        [Test]
        public void Add_Adding_Two_Positive_Numbers_Result()
        {
            //Arrange
            var calculator = new CalcProject.Calculator();
            int x = 2;
            int y = 3;

            //Act
            var result = calculator.Add(x, y);

            //Asserts
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Add_Adding_Two_Negative_Numbers_Result()
        {
            //Arrange
            var calculator = new CalcProject.Calculator();
            int x = -2;
            int y = -3;

            //Act
            var result = calculator.Add(x, y);

            //Asserts
            Assert.AreEqual(-5, result);
        }

        [Test]
        [TestCase(10, 2, 12)]
        public void Add_Adding_Two_Numbers_Result(int x, int y, int sum)
        {
            //Arrange
            var calculator = new CalcProject.Calculator();

            //Act
            var result = calculator.Add(x, y);

            //Asserts
            Assert.AreEqual(sum, result);
        }

        [Test]
        public void Sub_Sub_Two_Positive_Numbers_Result()
        {
            //Arrange
            var calculator = new CalcProject.Calculator();
            int x = 5;
            int y = 2;

            //Act
            var result = calculator.Sub(x, y);

            //Asserts
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Sub_Sub_Two_Negative_Numbers_Result()
        {
            //Arrange
            var calculator = new CalcProject.Calculator();
            int x = -5;
            int y = -2;

            //Act
            var result = calculator.Sub(x, y);

            //Asserts
            Assert.AreEqual(-3, result);
        }



        [Test]
        public void Divide_DivideTwoPositiveNumbers_Result()
        {
            var a = 2;
            var b = 3;

            var calculator = new CalcProject.Calculator();
            var sum = calculator.Subtract(a, b);

            Assert.That(sum, Is.EqualTo(-1));
        }

        [TestCase(0, 5, 0)]
        [TestCase(-5, -2, 2.5f)]
        [TestCase(5, -2, -2.5f)]
        [Test]
        public void Divide_DivisionValidNumbers_CorrectResult(int x, int y, float res)
        {
            //Arrange
            var calculator = new CalcProject.Calculator();

            //Act
            var result = calculator.Divide(x, y);

            //Asserts
            Assert.AreEqual(res, result);
        }

        [Test]
        public void Divide_DividingByZero_ThrowsDivideByZeroException()
        {
            var a = 4;
            var b = 0;

            var calculator = new CalcProject.Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
        }

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
