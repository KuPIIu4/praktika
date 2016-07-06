using NUnit.Framework;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    [TestFixture]
    public class SinCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            SinCalculator calculator = new SinCalculator();
            double result = calculator.Calculate(0);
            Assert.AreEqual(0,result);
        }
    }
}

