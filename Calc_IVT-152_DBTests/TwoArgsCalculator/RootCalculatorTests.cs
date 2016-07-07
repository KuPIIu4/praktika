using System;
using Calc_IVT_152_DB.TwoArgsCalculator;
using NUnit.Framework;

namespace Calc_IVT_152_DBTests.TwoArgsCalculator
{
    [TestFixture]
    public class RootCalculatorTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(8, 3, 2)]
        [TestCase(125, 3, 5)]
        public void CalculateTest(double first, double second, double expected)
        {
            RootCalculator calculator = new RootCalculator();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CalculateTestZero()
        {
            RootCalculator calculator = new RootCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-5, 2));
        }
    }
}
