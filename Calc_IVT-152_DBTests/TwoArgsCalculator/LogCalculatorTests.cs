using NUnit.Framework;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    [TestFixture]
    public class LogCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            LogCalculator calculator = new LogCalculator();
            double result = calculator.Calculate(2, 2);
            Assert.AreEqual(1, result);
        }
    }
}
