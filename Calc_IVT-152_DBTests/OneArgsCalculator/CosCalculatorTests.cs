using System;
using NUnit.Framework;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    [TestFixture]
    public class CosCalculatorTests
    {
        [TestCase(0, 1)]
        [TestCase(Math.PI, -1)]
        [TestCase(Math.PI/2, 0)]
        public void CalculateTest(double first, double expected)
        {
            CosCalculator calculator = new CosCalculator();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
