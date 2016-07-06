using NUnit.Framework;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    [TestFixture]
    public class FactorialCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            FactorialCalculator calculator = new FactorialCalculator();
            double result = calculator.Calculate(4);
            Assert.AreEqual(24,result);
        }
    }
}

