using System;
using NUnit.Framework;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    [TestFixture]
    public class SinCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(Math.PI, 0)]
        [TestCase(Math.PI / 2, 1)]
        public void CalculateTest(double first, double expected)
        {
            SinCalculator calculator = new SinCalculator();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}

