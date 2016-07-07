using System;
using Calc_IVT_152_DB.OneArgsCalculator;
using NUnit.Framework;

namespace Calc_IVT_152_DBTests.OneArgsCalculator
{
    [TestFixture]
    public class LgCalculatorTests
    {
        [TestCase(10, 1)]
        [TestCase(1, 0)]
        [TestCase(100, 2)]
        public void CalculateTest(double first, double expected)
        {
            LgCalculator calculator = new LgCalculator();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
        [Test]
        public void CalculateTestZero()
        {
            LgCalculator calculator = new LgCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-58));
        }
    }
}

