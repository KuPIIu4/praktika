using System;
using NUnit.Framework;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    [TestFixture]
    public class LogCalculatorTests
    {
        [TestCase(2, 2, 1)]
        [TestCase(1, 2, 0)]
        [TestCase(9, 3, 2)]
        public void CalculateTest(double first, double second, double expected)
        {
            LogCalculator calculator = new LogCalculator();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CalculateTestZero()
        {
            LogCalculator calculator = new LogCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-1, 1));
        }
    }
}
