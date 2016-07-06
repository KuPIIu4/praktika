using NUnit.Framework;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            AdditionCalculator calculator = new AdditionCalculator();
            double result = calculator.Calculate(2,2);
            Assert.AreEqual(4,result);
        }
    }
}
