using NUnit.Framework;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    [TestFixture]
    public class TanCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            TanCalculator calculator = new TanCalculator();
            double result = calculator.Calculate(0);
            Assert.AreEqual(0, result);
        }
    }
}

