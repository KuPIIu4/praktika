using System;
using NUnit.Framework;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    [TestFixture]
    public class CotCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            CotCalculator calculator = new CotCalculator();
            double result = calculator.Calculate(0);
            Assert.AreEqual((double)1/0,result);
        }
    }
}
