using NUnit.Framework;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    [TestFixture]
    public class PercentCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            PercentCalculator calculator = new PercentCalculator();
            double result = calculator.Calculate(2, 2);
            Assert.AreEqual(0.04, result);
        }
    }
}
