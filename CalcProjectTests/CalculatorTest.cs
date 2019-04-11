using CalcProject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcProjectTests
{
    class CalculatorTest
    {
        [Test]
        public void Add_Adding_Two_Positive_Numbers_Result()
        {
            //Arrange
            var calculator = new calculator1.Calculator();
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
            var calculator = new calculator1.Calculator();
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
            var calculator = new calculator1.Calculator();

            //Act
            var result = calculator.Add(x, y);

            //Asserts
            Assert.AreEqual(sum, result);
        }

        [Test]
        public void Sub_Sub_Two_Positive_Numbers_Result()
        {
            //Arrange
            var calculator = new calculator1.Calculator();
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
            var calculator = new calculator1.Calculator();
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
            //Arrange
            var calculator = new calculator1.Calculator();
            float x = 5;
            float y = 2;

            //Act
            var result = calculator.Divide(x, y);

            //Asserts
            Assert.AreEqual(2.5, result);
        }

        [TestCase(0, 5, 0)]
        [TestCase(-5, -2, 2.5f)]
        [TestCase(5, -2, -2.5f)]
        [Test]
        public void Divide_DivisionValidNumbers_CorrectResult(int x, int y, float res)
        {
            //Arrange
            var calculator = new calculator1.Calculator();

            //Act
            var result = calculator.Divide(x, y);

            //Asserts
            Assert.AreEqual(res, result);
        }

        [Test]
        public void Divide_DivideByZero_ThrowsException()
        {
            //Arrange
            var calculator = new calculator1.Calculator();
            int x = 5;
            int y = 0;

            //Asserts
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(x, y));
        }

    }
}
