using System;
using NUnit.Framework;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    [TestFixture]
    public class CotCalculatorTests
    {
        [TestCase(0, double.PositiveInfinity)]
        [TestCase(Math.PI / 4, 1)]
        [TestCase(Math.PI / 2, 0.0)]
        public void CalculateTest(double first, double expected)
        {
            CotCalculator calculator = new CotCalculator();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
