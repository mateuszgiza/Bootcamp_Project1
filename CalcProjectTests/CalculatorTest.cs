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
        public void CalcProjectTests_Add_ShouldReturn5()
        {
            Calculator calculator = new Calculator();
            var shouldReturn = calculator.Add(2, 3);
            Assert.AreEqual(5,shouldReturn);
        }

        [Test]
        public void CalcProjectTests_Add_ShouldReturnMinusValue()
        {
            Calculator calculator = new Calculator();
            var shouldReturn = calculator.Add(-2, -3);
            Assert.AreEqual(-5, shouldReturn);
        }


    }
}
