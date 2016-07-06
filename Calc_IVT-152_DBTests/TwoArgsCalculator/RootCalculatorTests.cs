using System;
using NUnit.Framework;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    [TestFixture]
    public class RootCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            RootCalculator calculator = new RootCalculator();
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(2, result);
        }
    }
}
