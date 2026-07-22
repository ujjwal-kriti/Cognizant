using NUnit.Framework;
using CalcLibrary;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Add_Test()
        {
            int result = calc.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestCase(2, 3, 5)]
        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        public void Add_TestCase(int a, int b, int expected)
        {
            int result = calc.Add(a, b);
            Assert.AreEqual(expected, result);
        }

        [TearDown]
        public void Cleanup()
        {
            calc = null;
        }
    }
}