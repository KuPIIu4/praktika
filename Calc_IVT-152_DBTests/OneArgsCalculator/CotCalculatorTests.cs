using System;
using Calc_IVT_152_DB.OneArgsCalculator;
using NUnit.Framework;

namespace Calc_IVT_152_DBTests.OneArgsCalculator
{
    [TestFixture]
    public class CotCalculatorTests
    {
        [TestCase(3 * Math.PI / 2, 0.0)]
        [TestCase(Math.PI / 4, 1)]
        [TestCase(Math.PI / 2, 0.0)]
        public void CalculateTest(double first, double expected)
        {
            CotCalculator calculator = new CotCalculator();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
        [Test]
        public void CalculateTestZero()
        {
            CotCalculator calculator = new CotCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}
