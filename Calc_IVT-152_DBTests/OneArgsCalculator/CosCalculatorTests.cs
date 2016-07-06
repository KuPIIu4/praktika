using NUnit.Framework;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    [TestFixture]
    public class CosCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            CosCalculator calculator = new CosCalculator();
            double result = calculator.Calculate(0);
            Assert.AreEqual(1,result);
        }
    }
}
