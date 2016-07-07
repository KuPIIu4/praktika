using System;
using Calc_IVT_152_DB.OneArgsCalculator;
using NUnit.Framework;

namespace Calc_IVT_152_DBTests.OneArgsCalculator
{
    [TestFixture]
    public class TanCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(Math.PI, 0)]
        [TestCase(Math.PI / 4, 1.0)]
        public void CalculateTest(double first, double expected)
        {
            TanCalculator calculator = new TanCalculator();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
        [Test]
        public void CalculateTestZero()
        {
            TanCalculator calculator = new TanCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(Math.PI/2));
        }
    }
}

