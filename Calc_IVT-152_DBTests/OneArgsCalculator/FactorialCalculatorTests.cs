using NUnit.Framework;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    [TestFixture]
    public class FactorialCalculatorTests
    {
        [TestCase(5, 120)]
        [TestCase(1, 1)]
        [TestCase(4, 24)]
        public void CalculateTest(double first, double expected)
        {
            FactorialCalculator calculator = new FactorialCalculator();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}

