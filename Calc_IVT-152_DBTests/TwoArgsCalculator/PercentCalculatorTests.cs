using NUnit.Framework;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    [TestFixture]
    public class PercentCalculatorTests
    {
        [TestCase(2, 2, 0.04)]
        [TestCase(-2, 2, -0.04)]
        [TestCase(9, 3, 0.27)]
        public void CalculateTest(double first, double second, double expected)
        {
            PercentCalculator calculator = new PercentCalculator();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
