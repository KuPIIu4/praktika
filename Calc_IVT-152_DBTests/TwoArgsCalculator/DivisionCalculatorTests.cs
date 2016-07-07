using System;
using Calc_IVT_152_DB.TwoArgsCalculator;
using NUnit.Framework;

namespace Calc_IVT_152_DBTests.TwoArgsCalculator
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [TestCase(2, 2, 1)]
        [TestCase(-2, 2, -1)]
        [TestCase(9, 3, 3)]
        public void CalculateTest(double first, double second, double expected)
        {
            DivisionCalculator calculator = new DivisionCalculator();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CalculateTestZero()
        {
            DivisionCalculator calculator = new DivisionCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(1,0));
        }
    }
}