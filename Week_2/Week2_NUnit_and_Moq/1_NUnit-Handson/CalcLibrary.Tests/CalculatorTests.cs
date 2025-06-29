using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new SimpleCalculator();
        }

        [TestCase(2, 3, 5)]
        [TestCase(-1, 1, 0)]
        public void Addition_WhenCalled_ReturnsSum(double a, double b, double expected)
        {
            var result = calc.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TearDown]
        public void Cleanup()
        {
            calc.AllClear();
        }
    }
}
