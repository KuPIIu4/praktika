using Calc_IVT_152_DB.TwoArgsCalculator;
using NUnit.Framework;

namespace Calc_IVT_152_DBTests.TwoArgsCalculator
{
    [TestFixture]
    public class MultiplyCalculatorTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(-2, 2, -4)]
        [TestCase(9, 3, 27)]
        public void CalculateTest(double first, double second, double expected)
        {
            MultiplyCalculator calculator = new MultiplyCalculator();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
