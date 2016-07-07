using System;
using Calc_IVT_152_DB.SortArray;
using NUnit.Framework;

namespace Calc_IVT_152_DBTests.SortArray
{
    public class SortArrayFactoryTests
    {
        [TestCase("buttonBubble", typeof(BubbleSort))]
        [TestCase("buttonQuick", typeof(QuickSort))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = SortArrayFactory.Create(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
