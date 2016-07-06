using NUnit.Framework;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(-2, 2, 0)]
        [TestCase(9, 3, 12)]
        public void CalculateTest(double first, double second, double expected)
        {
            AdditionCalculator calculator = new AdditionCalculator();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
