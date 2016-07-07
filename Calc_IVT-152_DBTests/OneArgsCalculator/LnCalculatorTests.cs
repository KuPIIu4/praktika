using System;
using Calc_IVT_152_DB.OneArgsCalculator;
using NUnit.Framework;

namespace Calc_IVT_152_DBTests.OneArgsCalculator
{
    [TestFixture]
    public class LnCalculatorTests
    {
        [TestCase(1, 0)]
        [TestCase(Math.E, 1)]
        [TestCase(Math.E * Math.E, 2)]
        public void CalculateTest(double first, double expected)
        {
            LnCalculator calculator = new LnCalculator();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
        [Test]
        public void CalculateTestZero()
        {
            LnCalculator calculator = new LnCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-58));
        }
    }
}

