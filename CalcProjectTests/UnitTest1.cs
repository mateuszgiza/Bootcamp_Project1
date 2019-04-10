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
            var calc = new CalculatorArek.CalculatorArek();

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
            var calc = new CalculatorArek.CalculatorArek();

            //act
            var result = calc.Substract(z, x);

            //arrange
            Assert.IsTrue(result == expectedValue);
        }


        [Test]
        public void Division_PositiveInts_ReturnsProperValue()
        {
            //arrange
            var calc = new CalculatorArek.CalculatorArek();

            //act
            var result = calc.Division(4, 2);

            //arrange
            Assert.IsTrue(result == 2);
        }

        [Test]
        public void Division_DividingByZero_ThrowsException()
        {
            //arrange
            var calc = new CalculatorArek.CalculatorArek();

            //assert
            Assert.Throws<System.DivideByZeroException>(() => calc.Division(2, 0)); 
        }
    }
}