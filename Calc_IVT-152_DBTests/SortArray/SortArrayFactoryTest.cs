using System;
using NUnit.Framework;

namespace Calc_IVT_152_DB.SortArray
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
