using System;
using System.Collections.Generic;
using System.Text;
using CalcProject;
using NUnit.Framework;

namespace TestUnitCalculator
{
    class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestAdd_ToPositive_EqualPositive13()
        {

            var calc = new Calculator();
            var result = calc.Add(5, 8);

            Assert.AreEqual(13, result);

        }

        [Test]
        public void TestAdd_ToNegative_EqualNegative13()
        {

            var calc = new Calculator();
            var result = calc.Add(-5, -8);

            Assert.AreEqual(-13, result);

        }

        [Test]

        public void TestDivide_Equals_1()
        {

            var calc = new Calculator();
            var result = calc.Divide(2, 2);

            Assert.AreEqual(1, result);

        }

        [Test]
        public void TestDivide_EqualsOneNegative_1()
        {

            var calc = new Calculator();
            var result = calc.Divide(-2, 2);

            Assert.AreEqual(-1, result);

        }

        [Test]
        
        public void TestDivide_EqualsTwoNegative_1()
        {

            var calc = new Calculator(); 
            var result = calc.Divide(-10, -2);

            Assert.AreEqual(5, result);

        }


    }
}
