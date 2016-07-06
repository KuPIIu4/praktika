using System;
using NUnit.Framework;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    [TestFixture]
    public class LnCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            LnCalculator calculator = new LnCalculator();
            double result = calculator.Calculate(1);
            Assert.AreEqual(0, result);
        }
    }
}

