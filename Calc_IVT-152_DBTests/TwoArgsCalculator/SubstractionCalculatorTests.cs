using NUnit.Framework;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    [TestFixture]
    public class SubstractionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            SubstractionCalculator calculator = new SubstractionCalculator();
            double result = calculator.Calculate(2, 2);
            Assert.AreEqual(0, result);
        }
    }
}
