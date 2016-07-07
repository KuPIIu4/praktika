﻿
using NUnit.Framework;

namespace Calc_IVT_152_DB.SortArray
{
    [TestFixture]
    public class BubbleSortTests
    {
        [Test]
        public void SortArrayTest()
        {
            double[] unsorted = new double[10] { 9, 8, -7, 6, 5, -4, 3, 2, 1, 0 };
            double[] sorted = new double[10] { -7, -4, 0, 1, 2, 3, 5, 6, 8, 9 };
            BubbleSort sort = new BubbleSort();
            sort.SortArray(unsorted);
            Assert.AreEqual(sorted, unsorted);
        }
    }
}