﻿using NUnit.Framework;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    [TestFixture]
    public class MultiplyCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            MultiplyCalculator calculator = new MultiplyCalculator();
            double result = calculator.Calculate(2, 2);
            Assert.AreEqual(4, result);
        }
    }
}