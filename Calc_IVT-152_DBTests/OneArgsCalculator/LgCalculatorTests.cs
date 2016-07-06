using NUnit.Framework;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    [TestFixture]
    public class LgCalculatorTests
    {
        [TestCase(10, 1)]
        [TestCase(1, 0)]
        [TestCase(100, 2)]
        public void CalculateTest(double first, double expected)
        {
            LgCalculator calculator = new LgCalculator();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}

