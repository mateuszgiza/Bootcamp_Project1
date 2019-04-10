using NUnit.Framework;
using Calculator.Piotr;

namespace Tests
{
    public class pTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void Add_TwoPositive_PosValue()
        {
            var calc = new Calculator.Piotr.Calculator();
            var result = calc.Add(3, 5);
            Assert.AreEqual(8, result);
        }
        [Test]
        public void Add_TwoNegative_NegValue()
        {
            var calc = new Calculator.Piotr.Calculator();
            var result = calc.Add(-3, -5);
            Assert.AreEqual(-8, result);
        }
        [Test]
        public void Add_OnePosOneNeg_PosValue()
        {
            var calc = new Calculator.Piotr.Calculator();
            var result = calc.Add(-3, 5);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Divide_TwoPos_PosValue()
        {
            var calc = new Calculator.Piotr.Calculator();
            var result = calc.Divide(6, 2);
            Assert.AreEqual(3, result);
        }

        [TestCase(7,2,3.5)]
        [TestCase(7, 7, 1)]
        [TestCase(0,7, 0)]
        public void Divide_Many_sth(double x, double y, double result)
        {
            var calc = new Calculator.Piotr.Calculator();
            var calresult = calc.Divide(x, y);
            Assert.AreEqual(result, calresult);
        }
        [Test]
        public void Divide_byzero_exception()
        {
            var calc = new Calculator.Piotr.Calculator();
            Assert.Throws<System.DivideByZeroException>(() => calc.Divide(6, 0));
        }


    }
}