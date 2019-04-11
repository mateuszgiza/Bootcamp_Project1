using NUnit.Framework;
using CalcProject;

namespace Tests
{
    [TestFixture]
    public class Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2, 3, 5)]
        [TestCase(-2, -3, -5)]
        public void Add_ReturnsProperValue(int z, int x, int expectedValue)
        {
            //arrange
            var calc = new Calculator();

            //act
            var result = calc.Add(z, x);

            //arrange
            Assert.IsTrue(result == expectedValue);
        }

        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        public void Substract_ReturnsProperValue(int z, int x, int expectedValue)
        {
            //arrange
            var calc = new Calculator();

            //act
            var result = calc.Subtract(z, x);

            
             Assert.IsTrue(result == expectedValue);
        }


        [Test]
        public void Division_PositiveInts_ReturnsProperValue()
        {
            
            var calc = new Calculator();

            
            var result = calc.Divide(4, 2);

            
            Assert.IsTrue(result == 2);
        }

        [Test]
        public void Division_DividingByZero_ThrowsException()
        {
            
             var calc = new Calculator();

            
             Assert.Throws<System.DivideByZeroException>(() => calc.Divide(2, 0));
        }
    }
}