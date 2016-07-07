using System;
using Calc_IVT_152_DB.OneArgsCalculator;
using NUnit.Framework;

namespace Calc_IVT_152_DBTests.OneArgsCalculator
{
    public class OneArgumentCalculatorTests
    {
        [TestCase("buttonSin", typeof(SinCalculator))]
        [TestCase("buttonCos", typeof(CosCalculator))]
        [TestCase("buttonFact", typeof(FactorialCalculator))]
        [TestCase("buttonLn", typeof(LnCalculator))]
        [TestCase("buttonLg", typeof(LgCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentCalculator.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
