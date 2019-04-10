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
           var calculator = new Calculator.Piotr.Calculator();
            var shouldReturn = calculator.Add(2, 3);
            Assert.AreEqual(5,shouldReturn);
        }

        [Test]
        public void CalcProjectTests_Add_ShouldReturnMinusValue()
        {
            var calculator = new Calculator.Piotr.Calculator();
            var shouldReturn = calculator.Add(-2, -3);
            Assert.AreEqual(-5, shouldReturn);
        }


    }
}
