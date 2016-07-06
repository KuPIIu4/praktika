using NUnit.Framework;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    [TestFixture]
    public class LgCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            LgCalculator calculator = new LgCalculator();
            double result = calculator.Calculate(10);
            Assert.AreEqual(1,result);
        }
    }
}

