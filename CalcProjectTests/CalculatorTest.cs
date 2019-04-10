using System;
using System.Collections.Generic;
using System.Text;
using CalcProject;
using NUnit.Framework;

namespace CalcProject
{
    class CalculatorTest
    {
        [Test]
        [TestCase(2, 2, 4)]
        [TestCase(0, -2, -2)]
        [TestCase(-5, 2, -3)]
        [TestCase(-2, -2, -4)]
        public void Add_Test(int a, int b, int expectedResult)
        {
            //Preparation
            Calculator calc = new Calculator();

            //Action
            int result = calc.Add(a, b);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        

        [Test]
        [TestCase(2, 2, 1)]
        [TestCase(0, -2, 0)]
        [TestCase(-5, 2, -2)]
        [TestCase(-2, -2, 1)]
        public void Divide_Test(int a, int b, int expectedResult)
        {
            //Preparation
            Calculator calc = new Calculator();

            //Action
            int result = calc.Divide(a, b);

            //Assert
            Assert.AreEqual(expectedResult, result);

        }

        [Test]
        public void Divide_ByZero_Test()
        {
            //Preparation
            Calculator calc = new Calculator();

            //Assert
            Assert.Throws<DivideByZeroException>(() => calc.Divide(2, 0));
        } 
    }
}
