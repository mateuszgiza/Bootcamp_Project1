using CalcProject;
using NUnit.Framework;
using System;

namespace CalcProjectTests
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
        public void Add_AddingTwoNegativeNumbers_ReturnsResult()
        {
            var a = -1;
            var b = -3;

            var calculator = new Calculator();
            var sum = calculator.Add(a, b);

            Assert.That(sum, Is.EqualTo(-4));
        }

        [Test]
        [TestCase(8, 3, 11)]
        [TestCase(1, int.MaxValue, int.MinValue)]
        public void Add_AddingTwoNumbers_ReturnsResult(int a, int b, int result)
        {
            var calculator = new Calculator();
            var sum = calculator.Add(a, b);

            Assert.That(sum, Is.EqualTo(result));
        }

        [Test]
        public void Subtract_SubstractTwoNumbers_ReturnsResult()
        {
            var a = 2;
            var b = 3;

            var calculator = new Calculator();
            var sum = calculator.Subtract(a, b);

            Assert.That(sum, Is.EqualTo(-1));
        }

        [Test]
        public void Divide_DividingTwoNaturalNumbers_ReturnsResult()
        {
            var a = 4;
            var b = 2;

            var calculator = new Calculator();
            var sum = calculator.Divide(a, b);

            Assert.That(sum, Is.EqualTo(2));
        }

        [Test]
        public void Divide_DividingByZero_ThrowsDivideByZeroException()
        {
            var a = 4;
            var b = 0;

            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
        }
    }
}
