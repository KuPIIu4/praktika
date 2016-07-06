using NUnit.Framework;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    [TestFixture]
    public class SubstractionCalculatorTests
    {
        [TestCase(2, 2, 0)]
        [TestCase(-2, 2, -4)]
        [TestCase(9, 3, 6)]
        public void CalculateTest(double first, double second, double expected)
        {
            SubstractionCalculator calculator = new SubstractionCalculator();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
