using System;
using NUnit.Framework;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    [TestFixture]
    public class FactorialCalculatorTests
    {
        [TestCase(5, 120)]
        [TestCase(1, 1)]
        [TestCase(4, 24)]
        public void CalculateTest(double first, double expected)
        {
            FactorialCalculator calculator = new FactorialCalculator();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CalculateTestZero()
        {
            FactorialCalculator calculator = new FactorialCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-58));
        }
    }
}

