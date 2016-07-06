using NUnit.Framework;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    [TestFixture]
    public class ExponentCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            ExponentCalculator calculator = new ExponentCalculator();
            double result = calculator.Calculate(2, 2);
            Assert.AreEqual(4, result);
        }
    }
}
