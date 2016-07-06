using NUnit.Framework;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            DivisionCalculator calculator = new DivisionCalculator();
            double result = calculator.Calculate(2, 2);
            Assert.AreEqual(1, result);
        }
    }
}
