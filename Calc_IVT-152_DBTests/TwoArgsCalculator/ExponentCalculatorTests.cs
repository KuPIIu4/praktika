using NUnit.Framework;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    [TestFixture]
    public class ExponentCalculatorTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(-2, 2, 4)]
        [TestCase(9, 3, 729)]
        public void CalculateTest(double first, double second, double expected)
        {
            ExponentCalculator calculator = new ExponentCalculator();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
