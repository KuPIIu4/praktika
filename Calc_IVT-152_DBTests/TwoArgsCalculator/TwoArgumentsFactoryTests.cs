using System;
using NUnit.Framework;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    public class TwoArgumentFactoryTests
    {
        [TestCase("buttonAdd", typeof(AdditionCalculator))]
        [TestCase("buttonSub", typeof(SubstractionCalculator))]
        [TestCase("buttonMult", typeof(MultiplyCalculator))]
        [TestCase("buttonDiv", typeof(DivisionCalculator))]
        [TestCase("buttonRoot", typeof(RootCalculator))]
        [TestCase("buttonExponent", typeof(ExponentCalculator))]
        [TestCase("buttonPercent", typeof(PercentCalculator))]
        [TestCase("buttonLog", typeof(LogCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}