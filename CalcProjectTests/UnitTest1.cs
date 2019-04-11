using CalcProject;
using NUnit.Framework;

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
            Calculator calc = new Calculator();

            //act
            int result = calc.Add(z, x);

            //arrange
            Assert.IsTrue(result == expectedValue);
        }

        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        public void Substract_ReturnsProperValue(int z, int x, int expectedValue)
        {
            //arrange
            Calculator calc = new Calculator();

            //act
            int result = calc.Subtract(z, x);


            Assert.IsTrue(result == expectedValue);
        }
        [Test]
        public void Division_PositiveInts_ReturnsProperValue()
        {

            Calculator calc = new Calculator();


            float result = calc.Divide(4, 2);


            Assert.IsTrue(result == 2);
        }
        [Test]
        public void Division_DividingByZero_ThrowsException()
        {

            Calculator calc = new Calculator();


            Assert.Throws<System.DivideByZeroException>(() => calc.Divide(2, 0));
        }
    }
}