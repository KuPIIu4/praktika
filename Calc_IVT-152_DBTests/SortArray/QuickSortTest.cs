
using Calc_IVT_152_DB.SortArray;
using NUnit.Framework;

namespace Calc_IVT_152_DBTests.SortArray
{
    [TestFixture]
    public class QuickSortTests
    {
        [Test]
        public void SortArrayTest()
        {
            double[] unsorted = new double[10] { 9, 8, -7, 6, 5, -4, 3, 2, 1, 0 };
            double[] sorted = new double[10] { -7, -4, 0, 1, 2, 3, 5, 6, 8, 9 };
            QuickSort sort = new QuickSort();
            sort.SortArray(unsorted);
            Assert.AreEqual(sorted, unsorted);
        }
    }
}
